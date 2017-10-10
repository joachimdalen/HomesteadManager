using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomesteadManager.Core.Managers {
    class SetupManager {
        public void Run() {
            var configManager = new ConfigManager();
            var fileSystemManager = new FileSystemManager();
            if (configManager.ConfigExists()) return;
            var dialogResult =
                MessageBox.Show(
                    @"Looks like this is your first time here? Do you wish to try and auto detect file paths?",
                    @"Welcome", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.No) return;

            var instanceConfig = Storage.Instance.Config;
            if (fileSystemManager.DetectHosts()) {
                
            }
            if (fileSystemManager.DetectHomestead()) {
                
            }

        }
    }
}
