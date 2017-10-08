using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomesteadManager.Core;
using HomesteadManager.Core.Stylers;
using WeifenLuo.WinFormsUI.Docking;

namespace HomesteadManager.UI {
    public partial class DatabasesFrom : DockContent {
        public DatabasesFrom() {
            InitializeComponent();
        }

        private void DatabasesFrom_Load(object sender, EventArgs e) {
            ControlStyler styler = new ControlStyler();
            styler.StyleButton(btnRemoveDb);
            styler.StyleButton(btnAddDb);
            styler.SetDarkBackgroundAndForground(tableLayoutPanel1);
            styler.SetDarkBackgroundAndForground(tableLayoutPanel2);
            styler.SetBackgroundAndForground(lbDatabases);
            lbDatabases.BorderStyle = BorderStyle.None;
            txtDbName.BorderStyle = BorderStyle.None;
            styler.SetBackgroundAndForground(txtDbName);
            styler.StyleTextBox(txtDbName);
            TextBoxPlaceholder placeholder = new TextBoxPlaceholder();
            placeholder.AddPlaceholder("Enter a database name...", txtDbName);
            this.ShowIcon = true;
        }
    }
}
