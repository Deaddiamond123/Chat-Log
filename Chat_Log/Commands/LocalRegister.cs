using BrokeProtocol.API;
using BrokeProtocol.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary8.Commands
{
    public class LocalRegister : IScript
    {
        public LocalRegister()
        {
            CommandHandler.RegisterCommand("MiniLog", new Action<ShPlayer, string>(LocalCommand));
        }

        private void LocalCommand(ShPlayer player, string Type)
        {
            var results = Core.Instance.MessagesQueue.Messages.Where(x =>x.Type == Type);
            var sb = new StringBuilder();
            foreach (var result in results)
            {
                sb.AppendLine($"{result.Author}: {result.Content}");
            }
            player.svPlayer.SendTextPanel($"Local messages", sb.ToString());
        }

    }
}
