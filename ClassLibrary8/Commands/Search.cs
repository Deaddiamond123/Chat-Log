using System;
using System.Linq;
using System.Text;
using BrokeProtocol.API;
using BrokeProtocol.Entities;

namespace ClassLibrary8.Commands
{
    public class Search : IScript
    {
        public Search()
        {
            CommandHandler.RegisterCommand("search", new Action<ShPlayer, string>(OnSearchMessage));
        }

        private void OnSearchMessage(ShPlayer player, string message)
        {
            var results = Core.Instance.MessagesQueue.Messages.Where(x=>x.Type == "Local");
            var sb = new StringBuilder();
            foreach(var result in results)
            {
                sb.AppendLine($"{result.Author}: {result.Content}");
            }
            player.svPlayer.SendTextPanel($"Searching: {message}", sb.ToString());
        }
    }
}