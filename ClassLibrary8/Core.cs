using System.IO;
using BrokeProtocol.API;
using BrokeProtocol.Managers;
using Newtonsoft.Json;
using UnityEngine;

namespace ClassLibrary8
{
    public class Core : Plugin 
    {
        public static Core Instance { get; internal set; }

        public SvManager SvManager { get; set; }

        public MessagesQueue MessagesQueue { get ; set;}

        public Settings Settings {get;set;} = new Settings();

        public Core()
        {
            Instance = this;
            Info = new PluginInfo("LoggerPlugin", "logger");
            MessagesQueue = new MessagesQueue(); 
            LoadSettings();
            WriteSettings();
        } 

        public void WriteSettings()
        {
            Debug.LogWarning("[ChatLog] Saving Settings...");
            var json =JsonConvert.SerializeObject(Settings, Formatting.Indented);

             if (!File.Exists(Path.Combine("Plugins", "ChatLog", "settings.json")))
                Directory.CreateDirectory(Path.Combine("Plugins","ChatLog"));

            using (StreamWriter file = File.CreateText(Path.Combine("Plugins", "ChatLog", "settings.json")))
            {
                file.Write(json);
            }
        }

        public void LoadSettings()
        {
            Debug.LogWarning("[ChatLog] Loading Settings...");
            if (!File.Exists(Path.Combine("Plugins", "ChatLog", "settings.json"))) return;

            var jsonStr = File.ReadAllText(Path.Combine("Plugins", "ChatLog", "settings.json"));
            Settings = JsonConvert.DeserializeObject<Settings>(jsonStr);
        }
    }
}
