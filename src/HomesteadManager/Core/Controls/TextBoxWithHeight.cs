using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomesteadManager.Core.Controls {
    public class TextBoxWithHeight : TextBox {
        public bool CustomAutoSize {
            get => AutoSize; set => AutoSize = value;
        }
    }
}
