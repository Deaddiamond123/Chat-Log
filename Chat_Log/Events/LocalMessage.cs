using BrokeProtocol.API;
using BrokeProtocol.Entities;

namespace Chat_Log.Events
{
    public class LocalMessage : IScript
    {
        [Target(GameSourceEvent.PlayerLocalChatMessage, ExecutionMode.Event)]
        public void OnLocalMessage(ShPlayer player, string message, string Type)
        {
            Core.Instance.MessagesQueue.AddMessage(new Message(player.username,message,Type));
        }
    }
}