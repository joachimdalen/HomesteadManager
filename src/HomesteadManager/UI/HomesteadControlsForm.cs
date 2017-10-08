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
    public partial class HomesteadControlsForm : DockContent {
        public HomesteadControlsForm() {
            InitializeComponent();
        }

        private void HomesteadControlsForm_Load(object sender, EventArgs e) {
            ControlStyler styler = new ControlStyler();
            styler.StyleControlsFromCollection(flowLayoutPanel1.Controls, typeof(Button));
        }
    }
}
