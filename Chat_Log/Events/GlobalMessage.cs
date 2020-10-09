using BrokeProtocol.API;
using BrokeProtocol.Entities;

namespace Chat_Log.Events
{
    public class GlobalMessage : IScript
    {
        [Target(GameSourceEvent.PlayerGlobalChatMessage,ExecutionMode.Event)]
        public void OnGlobalMessage(ShPlayer player, string message, string Type)
        {
            Core.Instance.MessagesQueue.AddMessage(new Message(player.username,message,Type));
        }
    }
}