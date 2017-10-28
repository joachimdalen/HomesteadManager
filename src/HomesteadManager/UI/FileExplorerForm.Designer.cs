namespace HomesteadManager.UI {
    partial class FileExplorerForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileExplorerForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TvExplorer = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(284, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TvExplorer
            // 
            this.TvExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TvExplorer.ImageIndex = 0;
            this.TvExplorer.ImageList = this.imageList1;
            this.TvExplorer.Location = new System.Drawing.Point(0, 25);
            this.TvExplorer.Name = "TvExplorer";
            this.TvExplorer.SelectedImageIndex = 0;
            this.TvExplorer.Size = new System.Drawing.Size(284, 531);
            this.TvExplorer.TabIndex = 1;
            this.TvExplorer.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.TvExplorer_BeforeExpand);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder_blue.png");
            this.imageList1.Images.SetKeyName(1, "folder_red.png");
            this.imageList1.Images.SetKeyName(2, "folder_green.png");
            this.imageList1.Images.SetKeyName(3, "drive.png");
            this.imageList1.Images.SetKeyName(4, "drive_cd.png");
            this.imageList1.Images.SetKeyName(5, "drive_network.png");
            this.imageList1.Images.SetKeyName(6, "flashdisk.png");
            // 
            // FileExplorerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 556);
            this.Controls.Add(this.TvExplorer);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FileExplorerForm";
            this.Text = "FileExplorerForm";
            this.Load += new System.EventHandler(this.FileExplorerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TreeView TvExplorer;
        private System.Windows.Forms.ImageList imageList1;
    }
}