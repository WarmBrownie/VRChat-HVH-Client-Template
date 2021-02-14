using HVH.Utils;
using Newtonsoft.Json;
using System.ComponentModel.Design;
using System.IO;
using UnityEngine;

namespace HVH.Settings
{
    public static class Configuration
    {
        public const string ConfigLocation = "HVH-Mod\\Config.json";

        private static Config _Config { get; set; }

        public static void SaveConfiguration() =>
            File.WriteAllText(ConfigLocation, JsonConvert.SerializeObject(_Config, Formatting.Indented));

        public static void CheckExistence()
        {
            if (!File.Exists(ConfigLocation))
            {
                var config = new Config();
                File.WriteAllText(ConfigLocation, JsonConvert.SerializeObject(config, Formatting.Indented));
            }
            LoadConfiguration();
        }

        public static void LoadConfiguration()
        {
            _Config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(ConfigLocation));
        }

        public static Config GetConfig() => _Config;
    }
}