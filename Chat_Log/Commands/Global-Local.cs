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
            string[] Test = { "Global Logs", "Registro del chat global", "Logs globales", "Globalne Logi" };
            var results = Core.Instance.MessagesQueue.Messages.Where(x => x.Type == "Global");
            var sb = new StringBuilder();
            foreach (var result in results)
            {
                sb.AppendLine($"{result.Author}: {result.Content}");
            }
            player.svPlayer.SendTextMenu(Test[Core.Instance.Settings.Language], sb.ToString());
        }
    } 
}
