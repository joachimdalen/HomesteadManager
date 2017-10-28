using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace HomesteadManager.Core.Models {
    public class HomesteadConfig {
        [YamlMember(Alias = "ip")]
        public string Ip { get; set; }
        [YamlMember(Alias = "memory")]
        public int Memory { get; set; }
        [YamlMember(Alias = "cpus")]
        public int Cpus { get; set; }
        [YamlMember(Alias = "provider")]
        public string Provider { get; set; }
        [YamlMember(Alias = "mariadb")]
        public bool Mariadb { get; set; }
        [YamlMember(Alias = "authorize")]
        public string Authorize { get; set; }
        [YamlMember(Alias = "keys")]
        public string[] Keys { get; set; }
        [YamlMember(Alias = "folders")]
        public Folder[] Folders { get; set; }
        [YamlMember(Alias = "sites")]
        public Site[] Sites { get; set; }
        [YamlMember(Alias = "databases")]
        public string[] Databases { get; set; }
        [YamlMember(Alias = "ports")]
        public Port[] Ports { get; set; }
        [YamlMember(Alias = "networks")]
        public Network[] Networks { get; set; }
       
    }
}
