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
using HomesteadManager.Core.Extensions;
using HomesteadManager.Core.Stylers;
using WeifenLuo.WinFormsUI.Docking;

namespace HomesteadManager.UI {
    public partial class DatabasesForm : DockContent {
        private const string Placeholder = "Enter a database name...";
        public DatabasesForm() {
            InitializeComponent();
        }

        private void DatabasesFrom_Load(object sender, EventArgs e) {
            var styler = new ControlStyler();
            styler.StyleButton(BtnRemoveDb);
            styler.StyleButton(BtnAddDb);
            styler.SetDarkBackgroundAndForground(tableLayoutPanel1);
            styler.SetDarkBackgroundAndForground(tableLayoutPanel2);
            styler.SetBackgroundAndForground(LbDatabases);
            LbDatabases.BorderStyle = BorderStyle.None;
            TxtDbName.BorderStyle = BorderStyle.None;
            styler.SetBackgroundAndForground(TxtDbName);
            styler.StyleTextBox(TxtDbName);
            var placeholder = new TextBoxPlaceholder();
            placeholder.AddPlaceholder(Placeholder, TxtDbName);
        }

        private void BtnAddDb_Click(object sender, EventArgs e) {
            if(TxtDbName.Text.IsEmpty() || TxtDbName.Text == Placeholder) {
                return;
            }
            if(LbDatabases.Items.Contains(TxtDbName.Text.StripSpaces().ToLower())) return;
            LbDatabases.Items.Add(TxtDbName.Text.StripSpaces());
            TxtDbName.Clear();
        }

        private void BtnRemoveDb_Click(object sender, EventArgs e) {
            var index = LbDatabases.SelectedIndex;
            if(index == -1) return;
            LbDatabases.Items.RemoveAt(index);
        }
    }
}
