using System;
using System.Drawing.Design;
using System.IO;

namespace HomesteadManager.Core.Managers {
    internal class FileSystemManager {
        private readonly string _hostsPath =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.SystemX86), "drivers", "etc");

        public FileSystemManager() {
        }

        public bool DetectHosts() {
            return File.Exists(Path.Combine(_hostsPath, "hosts"));
        }

        public bool DetectHomestead() {
            return false;
        }
    }
}