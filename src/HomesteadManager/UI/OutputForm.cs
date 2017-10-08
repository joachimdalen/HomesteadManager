using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomesteadManager.Core.Stylers;
using WeifenLuo.WinFormsUI.Docking;

namespace HomesteadManager.UI {
    public partial class OutputForm : DockContent {
        public OutputForm() {
            InitializeComponent();
        }

        private void OutputForm_Load(object sender, EventArgs e) {
            ControlStyler styler = new ControlStyler();
            styler.SetDarkBackgroundAndForground(richTextBox1);
        }
    }
}
