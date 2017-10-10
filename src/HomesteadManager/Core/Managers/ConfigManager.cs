using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomesteadManager.Core.Models;
using Newtonsoft.Json;

namespace HomesteadManager.Core.Managers {
    public class ConfigManager {

        private const string ConfigFileName = "config.json";

        public bool ConfigExists() {
            return File.Exists(ConfigFileName);
        }

        public void TryLoadConfig() {
            if (ConfigExists()) {
                Storage.Instance.Config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(ConfigFileName));
                return;
            }
            Storage.Instance.Config = new Config();
        }
        public void SaveConfig() {
            var serializer = new JsonSerializer() {
                NullValueHandling = NullValueHandling.Ignore
            };
            using (var sw = new StreamWriter(ConfigFileName))
            using (var writer = new JsonTextWriter(sw)) {
                serializer.Serialize(writer, Storage.Instance.Config);
            }
        }
    }
}
