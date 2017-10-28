namespace HomesteadManager.UI {
    partial class DatabasesForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabasesForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LbDatabases = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CbUseMariaDb = new System.Windows.Forms.CheckBox();
            this.BtnRemoveDb = new System.Windows.Forms.Button();
            this.BtnAddDb = new System.Windows.Forms.Button();
            this.TxtDbName = new HomesteadManager.Core.Controls.TextBoxWithHeight();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.LbDatabases, 0, 1);
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
            // LbDatabases
            // 
            this.LbDatabases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbDatabases.FormattingEnabled = true;
            this.LbDatabases.Location = new System.Drawing.Point(3, 62);
            this.LbDatabases.Name = "LbDatabases";
            this.LbDatabases.Size = new System.Drawing.Size(296, 407);
            this.LbDatabases.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.87838F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.51351F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.27027F));
            this.tableLayoutPanel2.Controls.Add(this.CbUseMariaDb, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtnRemoveDb, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtnAddDb, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.TxtDbName, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(296, 53);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // CbUseMariaDb
            // 
            this.CbUseMariaDb.AutoSize = true;
            this.CbUseMariaDb.Location = new System.Drawing.Point(3, 29);
            this.CbUseMariaDb.Name = "CbUseMariaDb";
            this.CbUseMariaDb.Size = new System.Drawing.Size(89, 17);
            this.CbUseMariaDb.TabIndex = 0;
            this.CbUseMariaDb.Text = "Use MariaDB";
            this.CbUseMariaDb.UseVisualStyleBackColor = true;
            // 
            // BtnRemoveDb
            // 
            this.BtnRemoveDb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnRemoveDb.Location = new System.Drawing.Point(124, 29);
            this.BtnRemoveDb.Name = "BtnRemoveDb";
            this.BtnRemoveDb.Size = new System.Drawing.Size(108, 21);
            this.BtnRemoveDb.TabIndex = 1;
            this.BtnRemoveDb.Text = "Remove Selected";
            this.BtnRemoveDb.UseVisualStyleBackColor = true;
            this.BtnRemoveDb.Click += new System.EventHandler(this.BtnRemoveDb_Click);
            // 
            // BtnAddDb
            // 
            this.BtnAddDb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAddDb.Location = new System.Drawing.Point(238, 29);
            this.BtnAddDb.Name = "BtnAddDb";
            this.BtnAddDb.Size = new System.Drawing.Size(55, 21);
            this.BtnAddDb.TabIndex = 2;
            this.BtnAddDb.Text = "Add";
            this.BtnAddDb.UseVisualStyleBackColor = true;
            this.BtnAddDb.Click += new System.EventHandler(this.BtnAddDb_Click);
            // 
            // TxtDbName
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.TxtDbName, 3);
            this.TxtDbName.CustomAutoSize = true;
            this.TxtDbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtDbName.Location = new System.Drawing.Point(3, 3);
            this.TxtDbName.Name = "TxtDbName";
            this.TxtDbName.Size = new System.Drawing.Size(290, 20);
            this.TxtDbName.TabIndex = 3;
            // 
            // DatabasesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 472);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)((WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DatabasesForm";
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
        private System.Windows.Forms.ListBox LbDatabases;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox CbUseMariaDb;
        private System.Windows.Forms.Button BtnRemoveDb;
        private System.Windows.Forms.Button BtnAddDb;
        private Core.Controls.TextBoxWithHeight TxtDbName;
    }
}