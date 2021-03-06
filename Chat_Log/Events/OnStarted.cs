using BrokeProtocol.API;
using BrokeProtocol.Managers;
using UnityEngine;

namespace Chat_Log.Events
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