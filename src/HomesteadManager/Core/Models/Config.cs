using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomesteadManager.Core.Models {
    public class Config {
        public string HomesteadConfigPath { get; set; }
        public string HostsFilePath { get; set; }
        public string GitPath { get; set; }
        public bool RestartAsAdmin { get; set; } = false;
    }
}
