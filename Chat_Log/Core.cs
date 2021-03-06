﻿using BrokeProtocol.API;
using System.IO;
using BrokeProtocol.Managers;
using Newtonsoft.Json;
using UnityEngine;

namespace Chat_Log
{
    public class Core : Plugin
    {
        public static Core Instance { get; internal set; }

        public SvManager SvManager { get; set; }

        public MessagesQueue MessagesQueue { get; set; }

        public Settings Settings { get; set; } = new Settings();


        public Core()
        {
            Instance = this;
            Info = new PluginInfo("Chatlog", "CL");
            MessagesQueue = new MessagesQueue();
            LoadSettings();
            SaveSettings();
            Debug.LogError(Settings.MaxLogMessages);
        }

        public void SaveSettings()
        {
            Debug.LogWarning("[ChatLog] Saving Settings...");
            var json = JsonConvert.SerializeObject(Settings, Formatting.Indented);

            if (!File.Exists(Path.Combine("Plugins", "ChatLog", "settings.json")))
                Directory.CreateDirectory(Path.Combine("Plugins", "ChatLog"));

            using (StreamWriter file = File.CreateText(Path.Combine("Plugins", "ChatLog", "settings.json")))
            {
                file.Write(json);
            }
            Debug.LogWarning("[ChatLog] Saved correctly.");
        }

        public void LoadSettings()
        {
            Debug.LogWarning("[ChatLog] Loading Settings...");
            if (!File.Exists(Path.Combine("Plugins", "ChatLog", "settings.json"))) return;

            var jsonStr = File.ReadAllText(Path.Combine("Plugins", "ChatLog", "settings.json"));
            Settings = JsonConvert.DeserializeObject<Settings>(jsonStr);
            Debug.LogWarning("[ChatLog] Loaded correctly.");
        }
    }
}