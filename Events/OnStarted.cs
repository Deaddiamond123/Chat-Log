using BrokeProtocol.API;
using BrokeProtocol.Managers;
using ClassLibrary8;

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