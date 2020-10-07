using BrokeProtocol.API;
using System;
using System.Collections.Generic;
using System.Text;
using BrokeProtocol.Entities;
using BrokeProtocol.Utility;
using BrokeProtocol.Client.UI;
using ClassLibrary8;

namespace ClassLibrary8
{
    public class ChatPlugin : IScript
    {
        [Target(GameSourceEvent.PlayerGlobalChatMessage, ExecutionMode.Event)]
        public void OnGlobalMessage(ShPlayer player, string message)
        {
            if (message.StartsWith("/"))
                Core.Instance.messagesQueue.AddMessage(new Message() { Author = player.username, Content = message, Type = MessageType.Local }) ;
        }
        [Target(GameSourceEvent.PlayerLocalChatMessage, ExecutionMode.Event)]
        
        public void OnLocalMessage(ShPlayer player, string message)
        {
            Core.Instance.messagesQueue.AddMessage(new Message() { Author = player.username, Content = ("LocalMessage"+message) });
        }

    }
}