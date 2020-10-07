using BrokeProtocol.API;
using BrokeProtocol.Managers;

namespace ClassLibrary8.Events
{
    public class OnStarted : IScript
    {
        [Target(GameSourceEvent.ManagerStart, ExecutionMode.Event)]
        public void OnStart(SvManager svManager)
        {
            Core.Instance.SvManager = svManager;
        }
    }
}