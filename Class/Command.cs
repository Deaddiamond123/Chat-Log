using System;
using System.Collections.Generic;
using System.Text;
using BrokeProtocol.API;
using BrokeProtocol.Entities;
using ClassLibrary8;

namespace ClassLibrary8
{
    class Command : IScript
    {
        public Command()
        {
            CommandHandler.RegisterCommand("logs", new Action<ShPlayer>(OnLogs));
        }

        private void OnLogs(ShPlayer player)
        {
            var sb = new StringBuilder();
            foreach (var message in Core.Instance.messagesQueue.Messages)
            {
                sb.AppendLine($"{message.Author}: {message.Content}");
            }
            player.svPlayer.SendTextPanel("Chat Log", sb.ToString());
        }
    }
}