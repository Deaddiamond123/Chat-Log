using System;
using System.Linq;
using System.Text;
using BrokeProtocol.API;
using BrokeProtocol.Entities;

namespace Chat_Log.Commands
{
    public class Search : IScript
    {
        public Search()
        {
            CommandHandler.RegisterCommand("search", new Action<ShPlayer, string>(OnSearchMessage));
        }

        private void OnSearchMessage(ShPlayer player, string message)
        {
            string[] LanguageSt = { "Searching:", "Buscando:" };
            var results = Core.Instance.MessagesQueue.Messages.Where(x => x.Content.Contains(message));
            var sb = new StringBuilder();
            foreach(var result in results)
            {
                sb.AppendLine($"{result.Author}: {result.Content}");
            }
            player.svPlayer.SendTextMenu(LanguageSt[Core.Instance.Settings.Language],message, sb.ToString());
        }
    }
}