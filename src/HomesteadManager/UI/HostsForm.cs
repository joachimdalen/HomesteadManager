using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomesteadManager.Core;
using HomesteadManager.Core.Managers;
using HomesteadManager.Core.Models;
using HomesteadManager.Core.Stylers;
using WeifenLuo.WinFormsUI.Docking;

namespace HomesteadManager.UI {
    public partial class HostsForm : DockContent {
        private HostsFile _hostsFile = new HostsFile();

        public HostsForm() {
            InitializeComponent();
        }

        private void HostsForm_Load(object sender, EventArgs e) {
            this.InitForm();
        }

        public bool InitForm() {
            try {
                ControlStyler styler = new ControlStyler();
                styler.StyleGrid(dataGridView1);
                styler.StylesControlsFromArray(new Control[] { textBoxWithHeight1, textBoxWithHeight3, comDomain });
                styler.SetDarkBackgroundAndForground(tableLayoutPanel1);
                styler.SetBackgroundAndForground(textBoxWithHeight1);
                styler.SetBackgroundAndForground(textBoxWithHeight3);
                styler.SetBackgroundAndForground(comDomain);
                styler.StyleComboBox(comDomain);
                TextBoxPlaceholder placeholder = new TextBoxPlaceholder();
                placeholder.AddPlaceholder("Local IP address..", textBoxWithHeight1);
                placeholder.AddPlaceholder("Comment for the current entry..", textBoxWithHeight3);
                styler.StylesControlsFromArray(new Control[] { btnSave, btnEditSelected, btnRemoveSelected });
                HostsFileManager manager = new HostsFileManager();
                _hostsFile = manager.Deserialize();
                if (_hostsFile == null) {
                    return false;
                }
                PopulateGrid();
                return true;
            } catch (Exception exception) {

                return false;
            }
        }

        private void PopulateGrid() {
            foreach (var hostEntry in _hostsFile.Hosts) {
                if (hostEntry.IsComment)
                    continue;
                dataGridView1.Rows.Add(hostEntry.Host, hostEntry.Domain, hostEntry.Comment, hostEntry.IsComment);
                comDomain.Items.Add(hostEntry.Domain);
            }
        }
    }
}
