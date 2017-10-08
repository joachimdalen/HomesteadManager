using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomesteadManager.Core {
    internal class TextBoxPlaceholder {
        internal void AddPlaceholder(string placeholder, TextBox textBox) {
            textBox.Tag = placeholder;
            textBox.Text = placeholder;
            textBox.MouseClick += (s, e) => {
                if (textBox.Text == textBox.Tag as string) {
                    textBox.Text = string.Empty;
                }
            };
            textBox.LostFocus += (s, e) => {
                if (textBox.Text == string.Empty) {
                    textBox.Text = (string)textBox.Tag;
                }
            };
            //textBox.TextChanged += (s, e) => {
            //    if (textBox.Text == string.Empty) {
            //        textBox.Text = (string)textBox.Tag;
            //    }
            //};
        }

    }
}
