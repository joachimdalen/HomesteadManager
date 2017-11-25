using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace HomesteadManager.Core.Models {
    public class SystemHost {
        public string Host { get; set; }
        public string Domain { get; set; }
        public bool IsComment { get; set; }
        public string Comment { get; set; }
        public int Line { get; set; }
    }
}
