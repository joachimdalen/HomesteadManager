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

        public bool TryLoadConfig() {
            try {
                if (ConfigExists()) {
                    Storage.Instance.Config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(ConfigFileName));
                    return true;
                }
                Storage.Instance.Config = new Config();
                return true;
            } catch (Exception e) {
                Console.WriteLine(e);
                return false;

            }
        }
        public bool WriteConfig() {
            try {
                var serializer = new JsonSerializer() {
                    NullValueHandling = NullValueHandling.Ignore
                };
                using (var sw = new StreamWriter(ConfigFileName))
                using (var writer = new JsonTextWriter(sw)) {
                    serializer.Serialize(writer, Storage.Instance.Config);
                }
                return true;
            } catch (Exception e) {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool SetConfigItem(string key, string value, bool autosave = false) {
            switch (key) {
                case "homestead":
                    Storage.Instance.Config.HomesteadConfigPath = value;
                    break;
                case "hosts":
                    Storage.Instance.Config.HostsFilePath = value;
                    break;
                case "adminstart":
                    Storage.Instance.Config.RestartAsAdmin = value == "true";
                    break;
                default:
                    return false;
            }
            return !autosave || WriteConfig();
        }
    }
}
