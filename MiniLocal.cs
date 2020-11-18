using BrokeProtocol.API;
using BrokeProtocol.Entities;
using Chat_Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Chat_Log.Commands
{
    public class MiniLocal : IScript
    {
        public MiniLocal()
        {
            CommandHandler.RegisterCommand(new List<string> { "Local", "ml" }, new Action<ShPlayer>(MiniLocalCommand));

        }
        public void MiniLocalCommand(ShPlayer player)
        {
            var results = Core.Instance.MessagesQueue.Messages.Where(x=>x.Type =="Local");
            var sb = new StringBuilder();
            foreach (var result in results)
            {
                sb.AppendLine($"{result.Author}: {result.Content}");
            }
            player.svPlayer.SendTextMenu($"Local Messages", sb.ToString());
        }
    

    }
}
