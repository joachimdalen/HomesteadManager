using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomesteadManager.Core.Models {
    public class HostsFile {
        public string Header { get; set; }
        public SystemHost[] Hosts { get; set; }
    }
}
