using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomesteadManager.UI;
using WeifenLuo.WinFormsUI.Docking;

namespace HomesteadManager {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            visualStudioToolStripExtender.DefaultRenderer = _toolStripProfessionalRenderer;
        }
        private readonly ToolStripRenderer _toolStripProfessionalRenderer = new ToolStripProfessionalRenderer();
        private void EnableVsRenderer(VisualStudioToolStripExtender.VsVersion version, ThemeBase theme) {
            visualStudioToolStripExtender.SetStyle(menuStrip, version, theme);
            visualStudioToolStripExtender.SetStyle(statusStrip, version, theme);
        }
        private void MainForm_Load(object sender, EventArgs e) {
            var theme = new VS2015DarkTheme();
            this.dockPanel.Theme = theme;
            this.EnableVsRenderer(VisualStudioToolStripExtender.VsVersion.Vs2015, vS2015DarkTheme);
            SetStatus("Ready");
        }
        private void ShowForm(DockContent form, DockState dockState) {
            if (dockPanel.Contents.Any(content => content.GetType().ToString() == form.GetType().ToString())) {
                return;
            }
            form.Show(dockPanel, dockState);
        }
        private void HomesteadBoxControlsToolStripMenuItem_Click(object sender, EventArgs e) {
            var homesteadControlsForm = new HomesteadControlsForm();
            ShowForm(homesteadControlsForm, DockState.DockLeft);
        }

        private void DatabasesToolStripMenuItem_Click(object sender, EventArgs e) {
            var databasesFrom = new DatabasesFrom();
            ShowForm(databasesFrom, DockState.DockRight);
        }

        private void OutputToolStripMenuItem_Click(object sender, EventArgs e) {
            var outputForm = new OutputForm();
            ShowForm(outputForm, DockState.DockBottom);
        }

        private void PrefrencesToolStripMenuItem_Click(object sender, EventArgs e) {
            var prefrencesForm = new PrefrencesForm();
            prefrencesForm.ShowDialog();
        }

        private void SetStatus(string status) {
            if (status == string.Empty)
                return;
            toolStripStatusLabel.Text = status;
        }

        private void FoldersToolStripMenuItem_Click(object sender, EventArgs e) {
            var folderForm = new FoldersForm();
            ShowForm(folderForm, DockState.Document);
        }
    }
}
