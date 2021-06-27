using BrokeProtocol.API;
using BrokeProtocol.Managers;

namespace Chat_Log.Events
{
    public class ManagerSave : IScript
    {
        [Target(GameSourceEvent.ManagerSave, ExecutionMode.Event)]
        public void OnManagerSave(SvManager manager)
        {
            Core.Instance.LoadSettings();
        }
    }
}