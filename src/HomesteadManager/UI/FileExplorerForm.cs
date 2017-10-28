using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomesteadManager.Core.Stylers;
using WeifenLuo.WinFormsUI.Docking;

namespace HomesteadManager.UI {
    public partial class FileExplorerForm : DockContent {
        public FileExplorerForm() {
            InitializeComponent();
        }

        private void FileExplorerForm_Load(object sender, EventArgs e) {
            ControlStyler styler = new ControlStyler();
            styler.SetBackgroundAndForground(TvExplorer);
            LoadTree();
        }

        private void LoadTree() {
            var drives = Environment.GetLogicalDrives();
            foreach (var drive in drives) {
                var driveInfo = new DriveInfo(drive);
                var driveType = 2;
                switch (driveInfo.DriveType) {
                    case DriveType.Network:
                        driveType = 5;
                        break;
                    case DriveType.CDRom:
                        driveType = 4;
                        break;
                    case DriveType.Removable:
                        driveType = 6;
                        break;
                    default:
                        driveType = 3;
                        break;

                }

                var driveNode = ConfigureNode(drive.Substring(0, 1), drive, driveType, driveType);
                TvExplorer.Nodes.Add(driveNode);
                if (driveInfo.IsReady)
                    driveNode.Nodes.Add("...");


            }
        }
        private TreeNode ConfigureNode(string displayName, string tag, int imageIndex, int selectedImageIndex) {
            return new TreeNode {
                Text = displayName,
                Tag = tag,
                ImageIndex = imageIndex,
                SelectedImageIndex = selectedImageIndex,
                ToolTipText = ToolTipText
            };
        }

        private void TvExplorer_BeforeExpand(object sender, TreeViewCancelEventArgs e) {
            if (e.Node.Nodes.Count <= 0) return;
            if (e.Node.Nodes[0].Text != @"..." || e.Node.Nodes[0].Tag != null) return;
            e.Node.Nodes.Clear();

            //get the list of sub direcotires
            var dirs = Directory.GetDirectories(e.Node.Tag.ToString());

            foreach (var dir in dirs) {
                var di = new DirectoryInfo(dir);
                var node = new TreeNode(di.Name, 0, 1);

                try {
                    //keep the directory's full path in the tag for use later
                    node.Tag = dir;

                    //if the directory has sub directories add the place holder
                    if (di.GetDirectories().Any())
                        node.Nodes.Add(null, "...", 0, 0);

                    //foreach (var file in di.GetFiles()) {
                    //    var n = new TreeNode(file.Name, 13, 13);
                    //    node.Nodes.Add(n);
                    //}

                } catch (UnauthorizedAccessException) {
                    //display a locked folder icon
                    node.ImageIndex = 12;
                    node.SelectedImageIndex = 12;
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message, @"DirectoryLister",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                } finally {
                    e.Node.Nodes.Add(node);
                }
            }
        }
    }

}
