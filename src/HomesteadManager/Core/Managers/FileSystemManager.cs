using System;
using System.Drawing.Design;
using System.IO;

namespace HomesteadManager.Core.Managers {
    internal class FileSystemManager {
        private readonly string _hostsPath =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers", "etc");

        private readonly string _homesteadPath =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".homestead");

        public FileSystemManager() {
        }

        public bool DetectHosts() {
            return File.Exists(Path.Combine(_hostsPath, "hosts"));
        }

        public bool DetectHomestead() {
            return File.Exists(Path.Combine(_homesteadPath, "homestead.yaml"));
        }

        public string GetHostsPath() {
            return Path.Combine(_hostsPath, "hosts");
        }
    }
}