using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace HomesteadManager.Core.Models {
    public class Network {
        [YamlMember(Alias = "ip")]
        public string Ip { get; set; }
        [YamlMember(Alias = "type")]
        public string Type { get; set; }
        [YamlMember(Alias = "bridge")]
        public string Bridge { get; set; }
        [YamlIgnore]
        [YamlMember(Alias = "dhcp")]
        public bool Dhcp { get; set; }
    }
}
