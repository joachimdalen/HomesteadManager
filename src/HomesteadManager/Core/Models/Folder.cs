using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace HomesteadManager.Core.Models {
    public class Folder {
        [YamlMember(Alias = "map")]
        public string Map { get; set; }
        [YamlMember(Alias = "to")]
        public string To { get; set; }
        [YamlMember(Alias = "type")]
        public string Type { get; set; }
    }
}
