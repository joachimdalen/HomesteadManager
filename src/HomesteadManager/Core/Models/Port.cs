using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace HomesteadManager.Core.Models {
    public class Port {
        [YamlMember(Alias = "send")]
        public int Send { get; set; }
        [YamlMember(Alias = "to")]
        public int To { get; set; }
        [YamlMember(Alias = "protocol")]
        public string Protocol { get; set; }
    }
}
