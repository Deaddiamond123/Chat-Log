using BrokeProtocol.API;
using BrokeProtocol.Entities;

namespace ClassLibrary8.Events
{
    public class GlobalMessage : IScript
    {
        [Target(GameSourceEvent.PlayerGlobalChatMessage,ExecutionMode.Event)]
        public void OnGlobalMessage(ShPlayer player, string message)
        {
            Core.Instance.MessagesQueue.AddMessage(new Message(player.username,message, "Global"));
        }
    }
}