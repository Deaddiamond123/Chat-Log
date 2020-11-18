using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using BrokeProtocol.API;
using BrokeProtocol.Entities;
using Chat_Log;

namespace Chat_Log.Commands
{
    class Logs : IScript
    {
        public Logs()
        {
            CommandHandler.RegisterCommand("logs", new Action<ShPlayer>(OnLogs));
        }

        private void OnLogs(ShPlayer player)
        {
            var sb = new StringBuilder();
            foreach (var message in Core.Instance.MessagesQueue.Messages)
            {
                sb.AppendLine($"{message.Author}: {message.Content}");
            }
            player.svPlayer.SendTextMenu("Chat Log", sb.ToString());
        }
    }
}