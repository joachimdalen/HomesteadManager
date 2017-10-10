using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HomesteadManager.UI.Prefrences;

namespace HomesteadManager.UI {
    public partial class PrefrencesForm : Form {
        private readonly Dictionary<string, UserControl> _controls = new Dictionary<string, UserControl>();
        public PrefrencesForm() {
            InitializeComponent();
        }

        private void PrefrencesForm_Load(object sender, EventArgs e) {
            var general = new GeneralPrefUc();
            var generalNode = AddToTree(null, general);

            var boxSettings = new BoxPrefUc();
            var boxSettingsNode = AddToTree(null, boxSettings);

            var boxKeys = new BoxKeysPrefUc();
            var boxKeysNode = AddToTree(boxSettingsNode, boxKeys);
        
            TvSelector.SelectedNode = generalNode;
        }

        private void TvSelector_AfterSelect(object sender, TreeViewEventArgs e) {
            if (!_controls.ContainsKey(e.Node.Name))
                return;
            ContentPanel.Controls.Clear();
            ContentPanel.Controls.Add(_controls[e.Node.Name]);
        }

        /// <summary>
        /// Add a node to the current tree, and register the user control it belongs to.
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="control"></param>
        /// <returns>Created TreeNode</returns>
        private TreeNode AddToTree(TreeNode parent, UserControl control) {
            var node = new TreeNode {
                Name = control.Name,
                Text = (string)control.Tag
            };
            _controls.Add(control.Name, control);
            if (parent == null) {
                TvSelector.Nodes.Add(node);
            } else {
                parent.Nodes.Add(node);
            }
            return node;
        }
    }
}
