namespace HomesteadManager.UI.Prefrences {
    partial class GeneralPrefUc {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbPrivMode = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHomestead = new System.Windows.Forms.TextBox();
            this.btnBrowseHomestead = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHosts = new System.Windows.Forms.TextBox();
            this.btnBrowseHosts = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(59, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cbPrivMode
            // 
            this.cbPrivMode.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.cbPrivMode, 3);
            this.cbPrivMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbPrivMode.Location = new System.Drawing.Point(3, 3);
            this.cbPrivMode.Name = "cbPrivMode";
            this.cbPrivMode.Size = new System.Drawing.Size(258, 19);
            this.cbPrivMode.TabIndex = 0;
            this.cbPrivMode.Text = "Automatically start in privileged mode";
            this.cbPrivMode.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(7, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(430, 260);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.cbPrivMode, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtHomestead, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnBrowseHomestead, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtHosts, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnBrowseHosts, 3, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(420, 237);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Homestead Configuration File\r\n";
            // 
            // txtHomestead
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtHomestead, 3);
            this.txtHomestead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHomestead.Location = new System.Drawing.Point(3, 52);
            this.txtHomestead.Name = "txtHomestead";
            this.txtHomestead.Size = new System.Drawing.Size(258, 20);
            this.txtHomestead.TabIndex = 3;
            // 
            // btnBrowseHomestead
            // 
            this.btnBrowseHomestead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBrowseHomestead.Image = global::HomesteadManager.Properties.Resources.folder_search;
            this.btnBrowseHomestead.Location = new System.Drawing.Point(267, 52);
            this.btnBrowseHomestead.Name = "btnBrowseHomestead";
            this.btnBrowseHomestead.Size = new System.Drawing.Size(24, 19);
            this.btnBrowseHomestead.TabIndex = 4;
            this.btnBrowseHomestead.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hosts File";
            // 
            // txtHosts
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtHosts, 3);
            this.txtHosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHosts.Location = new System.Drawing.Point(3, 101);
            this.txtHosts.Name = "txtHosts";
            this.txtHosts.Size = new System.Drawing.Size(258, 20);
            this.txtHosts.TabIndex = 6;
            // 
            // btnBrowseHosts
            // 
            this.btnBrowseHosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBrowseHosts.Image = global::HomesteadManager.Properties.Resources.folder_search;
            this.btnBrowseHosts.Location = new System.Drawing.Point(267, 101);
            this.btnBrowseHosts.Name = "btnBrowseHosts";
            this.btnBrowseHosts.Size = new System.Drawing.Size(24, 19);
            this.btnBrowseHosts.TabIndex = 7;
            this.btnBrowseHosts.UseVisualStyleBackColor = true;
            // 
            // GeneralPrefUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GeneralPrefUc";
            this.Size = new System.Drawing.Size(444, 276);
            this.Tag = "General";
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbPrivMode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtHomestead;
        private System.Windows.Forms.Button btnBrowseHomestead;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHosts;
        private System.Windows.Forms.Button btnBrowseHosts;
    }
}
