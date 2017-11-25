using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HomesteadManager.Core.Models;

namespace HomesteadManager.Core.Managers {
    class HostsFileManager {
        private readonly string _hostsRegex =
            @"(?<COMMENT>#.*)|(?<IP>\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3})\s+(?<HOSTNAME>\S+)";

        public HostsFile Deserialize() {
            var paths = new FileSystemManager();
            var file = new HostsFile();
            var fileContent = string.Empty;
            var hostsList = new List<SystemHost>();
            using (var reader = new StreamReader(paths.GetHostsPath())) {
                fileContent = reader.ReadToEnd();
            }
            foreach (var line in fileContent.Split('\n')) {
                var host = new SystemHost();
                var match = Regex.Match(line, _hostsRegex, RegexOptions.IgnoreCase | RegexOptions.Multiline);
                if (!match.Success)
                    continue;
                // 1 - Full, 2 - Comment, 3 - IP, 4 - Hostname
                // We match on IP and HOSTNAME
                if (match.Groups[2].Success && match.Groups[3].Success) {
                    host.IsComment = false;
                    host.Domain = match.Groups[3].Value;
                    host.Host = match.Groups[2].Value;
                    if (match.Groups[1].Success) {
                        host.Comment = match.Groups[1].Value;
                    }
                } else {
                    host.IsComment = true;
                    host.Comment = match.Groups[0].Value;
                }
                hostsList.Add(host);
            }
            file.Hosts = hostsList.ToArray();
            return file;
        }

        public bool Serialize() {

            return false;
        }
    }
}
