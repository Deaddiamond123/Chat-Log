using BrokeProtocol.API;
using BrokeProtocol.Entities;

namespace ClassLibrary8.Events
{
    public class LocalMessage : IScript
    {
        [Target(GameSourceEvent.PlayerLocalChatMessage, ExecutionMode.Event)]
        public void OnLocalMessage(ShPlayer player, string message)
        {
            Core.Instance.MessagesQueue.AddMessage(new Message(player.username, message, "Local"));
        }
    }
}