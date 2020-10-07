using BrokeProtocol.API;
using BrokeProtocol.Managers;

namespace ClassLibrary8
{
    public class Core : Plugin 
    {
        public static Core Instance { get; internal set; }

        public SvManager SvManager { get; set; }

        public MessagesQueue MessagesQueue { get ; set;}

        public Core()
        {
            Instance = this;
            Info = new PluginInfo("LoggerPlugin", "logger");
            MessagesQueue = new MessagesQueue(); 
        } 
    }
}
