using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using BrokeProtocol.API;
using BrokeProtocol.Entities;
using ClassLibrary8;

namespace ClassLibrary8.Commands
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
            player.svPlayer.SendTextPanel("Chat Log", sb.ToString());
        }
    }
}