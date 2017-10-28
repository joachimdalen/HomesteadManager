using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomesteadManager.UI;

namespace HomesteadManager.Core.Managers {
    internal class OutputManager {
        private static readonly OutputForm OutputForm = new OutputForm();

        public OutputForm GetForm() {
            return OutputForm;
        }

        public void Write(string text, bool forceView) {
            
        }

    }
}
