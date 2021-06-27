using System.Text;
using System.Linq;
using System;
using System.Collections.Generic;
using BrokeProtocol.API;
using BrokeProtocol.Entities;

namespace Chat_Log.Commands
{
    public class SearchByPlayer : IScript
    {
        public SearchByPlayer()
        {
            CommandHandler.RegisterCommand(new List<string>{"searchplayer","searchPl"}, new Action<ShPlayer, string>(OnSearchByPlayer));
        }

        private void OnSearchByPlayer(ShPlayer player, string target)
        {
            string[] LanguageSt = { "Searching for:", "Buscando mensajes de:" };
            var results = Core.Instance.MessagesQueue.Messages.Where(x=>x.Author == target);
            var sb = new StringBuilder();

            foreach(var result in results)
            {
                sb.AppendLine($"{result.Author}: {result.Content}");
            }

            player.svPlayer.SendTextMenu($"Searching for: {target}",sb.ToString());
        }
    }
}