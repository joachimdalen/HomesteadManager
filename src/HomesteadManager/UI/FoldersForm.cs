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
    public partial class FoldersForm : DockContent {
        public FoldersForm() {
            InitializeComponent();
        }

        private void FoldersForm_Load(object sender, EventArgs e) {
            ControlStyler styler = new ControlStyler();
            styler.StyleGrid(dataGridView1);

            //styler.SetDarkBackgroundAndForground(tableLayoutPanel1);
            styler.StylesControlsFromArray(new Control[] { textBoxWithHeight1, textBoxWithHeight2 });
            styler.SetDarkBackgroundAndForground(tableLayoutPanel1);
            styler.SetBackgroundAndForground(textBoxWithHeight1);
            styler.SetBackgroundAndForground(comType);
            styler.SetBackgroundAndForground(textBoxWithHeight2);
            styler.StyleComboBox(comType);
            TextBoxPlaceholder placeholder = new TextBoxPlaceholder();
            placeholder.AddPlaceholder("Local folder path..", textBoxWithHeight1);
            placeholder.AddPlaceholder("Remote folder path..", textBoxWithHeight2);

            styler.StylesControlsFromArray(new Control[] { button1, btnSave, btnEditSelected,btnRemoveSelected });
           

            dataGridView1.Rows.Add(new object[] { "1","2","3","4"});
            dataGridView1.Rows.Add(new object[] { "1", "2", "3", "4" });
            dataGridView1.Rows.Add(new object[] { "1", "2", "3", "4" });
            dataGridView1.Rows.Add(new object[] { "1", "2", "3", "4" });
        }
    }
}
