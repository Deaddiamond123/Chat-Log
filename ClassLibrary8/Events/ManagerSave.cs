using BrokeProtocol.API;
using BrokeProtocol.Managers;

namespace ClassLibrary8.Events
{
    public class ManagerSave : IScript
    {
        [Target(GameSourceEvent.ManagerSave, ExecutionMode.Event)]
        public void OnManagerSave(SvManager manager)
        {
            Core.Instance.WriteSettings();
        }
    }
}