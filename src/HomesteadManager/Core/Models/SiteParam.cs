using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace HomesteadManager.Core.Models {
    public class SiteParam {
        [YamlMember(Alias = "key")]
        public string Key { get; set; }
        [YamlMember(Alias = "value")]
        public string Value { get; set; }
    }
}
