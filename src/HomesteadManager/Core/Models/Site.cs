using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace HomesteadManager.Core.Models {
    public class Site {
        [YamlMember(Alias = "map")]
        public string Map { get; set; }
        [YamlMember(Alias = "to")]
        public string To { get; set; }
        [YamlMember(Alias = "type")]
        public string Type { get; set; }
        [YamlMember(Alias = "schedule")]
        public bool Schedule { get; set; }
        [YamlMember(Alias = "params")]
        public SiteParam[] Parameters { get; set; }
    }
}
