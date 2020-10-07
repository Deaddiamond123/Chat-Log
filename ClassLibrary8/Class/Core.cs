using BrokeProtocol.API;
using BrokeProtocol.Managers;

namespace ClassLibrary8
{
    public class Core : Plugin 
    {
        public static Core Instance { get; internal set; }

        public SvManager SvManager { get; set; }

        public MessagesQueue messagesQueue { get ; set;}

        public Core()
        {
            Instance = this;
            Info = new PluginInfo("LoggerPlugin", "logger");
            messagesQueue = new MessagesQueue(); 
        } 
    }
}