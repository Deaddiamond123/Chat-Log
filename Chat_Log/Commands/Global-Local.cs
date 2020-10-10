using BrokeProtocol.API;
using BrokeProtocol.Entities;
using Chat_Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chat_Log.Commands
{
    public class Global_Local : IScript
    {
        public Global_Local()
        {
            CommandHandler.RegisterCommand(new List<string> { "gl", "global" }, new Action<ShPlayer>(OnGlobalCommand));
        }
        public void OnGlobalCommand(ShPlayer player)
        {
            var results = Core.Instance.MessagesQueue.Messages.Where(x => x.Type == "Global");
            var sb = new StringBuilder();
            foreach (var result in results)
            {
                sb.AppendLine($"{result.Author}: {result.Content}");
            }
            player.svPlayer.SendTextPanel($"Global & Local Logs", sb.ToString());
        }
    } 
}
