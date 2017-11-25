using System;
using System.Windows.Forms;
using HomesteadManager.Core.Controls;

namespace HomesteadManager.Core.Stylers {
    internal class ControlStyler {
        internal void StyleControlsFromCollection(Control.ControlCollection collection, Type type) {
            foreach (var control in collection) {
                if (control == null)
                    continue;
                if (control.GetType() != type)
                    continue;
                if (type == typeof(Button)) {
                    StyleButton(control as Button);
                } else if (type == typeof(DataGridView)) {
                    StyleGrid(control as DataGridView);
                }
            }
        }

        internal void StylesControlsFromArray(Control[] controls) {
            foreach (var control in controls) {
                if (control == null)
                    continue;
                if (control.GetType() == typeof(Button)) {
                    StyleButton(control as Button);
                } else if (control.GetType() == typeof(DataGridView)) {
                    StyleGrid(control as DataGridView);
                } else if (control.GetType() == typeof(TextBox) || control.GetType() == typeof(TextBoxWithHeight)) {
                    StyleTextBox(control as TextBox);
                }
            }
        }
        internal void StyleButton(Button btn) {
            btn.FlatStyle = FlatStyle.Popup;
            btn.ForeColor = Colors.Text;
            btn.BackColor = Colors.Background;
        }

        internal void StyleComboBox(ComboBox box) {
            box.BackColor = Colors.Background;
            box.FlatStyle = FlatStyle.Popup;
        }

        internal void StyleGrid(DataGridView view) {
            var styleOne = new DataGridViewCellStyle {
                BackColor = Colors.DarkBackground,
                ForeColor = Colors.Text
            };
            var styleTwo = new DataGridViewCellStyle {
                BackColor = Colors.DarkBackground,
                ForeColor = Colors.Text
            };
            view.BackgroundColor = Colors.Background;
            view.BorderStyle = BorderStyle.None;
            view.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            view.ColumnHeadersDefaultCellStyle = styleOne;
            view.RowsDefaultCellStyle = styleOne;
            view.RowHeadersDefaultCellStyle = styleOne;
            view.RowTemplate.DefaultCellStyle = styleOne;
            view.RowHeadersDefaultCellStyle = styleTwo;
            view.GridColor = Colors.Grey;
            //Not styles, but it applies to all grids
            view.AllowUserToAddRows = false;
            view.AllowUserToDeleteRows = false;
            view.AllowUserToOrderColumns = false;
            view.AllowUserToResizeColumns = false;
            view.AllowUserToResizeRows = false;
            view.RowHeadersVisible = false;
            view.ShowEditingIcon = false;
            view.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            view.MultiSelect = false;
            view.EnableHeadersVisualStyles = false;
            view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        internal void StyleForm(Form form) {
            form.BackColor = Colors.Background;
        }

        internal void SetDarkBackgroundAndForground(Control control) {
            control.BackColor = Colors.DarkBackground;
            control.ForeColor = Colors.Text;
        }

        internal void SetBackgroundAndForground(Control control) {
            control.BackColor = Colors.Background;
            control.ForeColor = Colors.Text;
        }

        internal void StyleTextBox(TextBox textBox) {
            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.ForeColor = Colors.GreyText;
        }
    }
}
