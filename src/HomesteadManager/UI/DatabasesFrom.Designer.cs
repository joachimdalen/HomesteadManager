namespace HomesteadManager.UI {
    partial class DatabasesFrom {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabasesFrom));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbDatabases = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbUseMariaDb = new System.Windows.Forms.CheckBox();
            this.btnRemoveDb = new System.Windows.Forms.Button();
            this.btnAddDb = new System.Windows.Forms.Button();
            this.txtDbName = new HomesteadManager.Core.Controls.TextBoxWithHeight();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lbDatabases, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(302, 472);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbDatabases
            // 
            this.lbDatabases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDatabases.FormattingEnabled = true;
            this.lbDatabases.Location = new System.Drawing.Point(3, 62);
            this.lbDatabases.Name = "lbDatabases";
            this.lbDatabases.Size = new System.Drawing.Size(296, 407);
            this.lbDatabases.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.87838F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.51351F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.27027F));
            this.tableLayoutPanel2.Controls.Add(this.cbUseMariaDb, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnRemoveDb, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnAddDb, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtDbName, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(296, 53);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // cbUseMariaDb
            // 
            this.cbUseMariaDb.AutoSize = true;
            this.cbUseMariaDb.Location = new System.Drawing.Point(3, 29);
            this.cbUseMariaDb.Name = "cbUseMariaDb";
            this.cbUseMariaDb.Size = new System.Drawing.Size(89, 17);
            this.cbUseMariaDb.TabIndex = 0;
            this.cbUseMariaDb.Text = "Use MariaDB";
            this.cbUseMariaDb.UseVisualStyleBackColor = true;
            // 
            // btnRemoveDb
            // 
            this.btnRemoveDb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoveDb.Location = new System.Drawing.Point(124, 29);
            this.btnRemoveDb.Name = "btnRemoveDb";
            this.btnRemoveDb.Size = new System.Drawing.Size(108, 21);
            this.btnRemoveDb.TabIndex = 1;
            this.btnRemoveDb.Text = "Remove Selected";
            this.btnRemoveDb.UseVisualStyleBackColor = true;
            // 
            // btnAddDb
            // 
            this.btnAddDb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddDb.Location = new System.Drawing.Point(238, 29);
            this.btnAddDb.Name = "btnAddDb";
            this.btnAddDb.Size = new System.Drawing.Size(55, 21);
            this.btnAddDb.TabIndex = 2;
            this.btnAddDb.Text = "Add";
            this.btnAddDb.UseVisualStyleBackColor = true;
            // 
            // txtDbName
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txtDbName, 3);
            this.txtDbName.CustomAutoSize = true;
            this.txtDbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDbName.Location = new System.Drawing.Point(3, 3);
            this.txtDbName.Name = "txtDbName";
            this.txtDbName.Size = new System.Drawing.Size(290, 20);
            this.txtDbName.TabIndex = 3;
            // 
            // DatabasesFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 472);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)((WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DatabasesFrom";
            this.ShowInTaskbar = false;
            this.Text = "Databases";
            this.Load += new System.EventHandler(this.DatabasesFrom_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox lbDatabases;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox cbUseMariaDb;
        private System.Windows.Forms.Button btnRemoveDb;
        private System.Windows.Forms.Button btnAddDb;
        private Core.Controls.TextBoxWithHeight txtDbName;
    }
}