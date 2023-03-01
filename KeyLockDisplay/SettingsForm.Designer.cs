namespace KeyLockDisplay
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOK = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.restartLabel = new System.Windows.Forms.Label();
			this.checkBoxLight = new System.Windows.Forms.CheckBox();
			this.checkBoxAutorun = new System.Windows.Forms.CheckBox();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.button1 = new System.Windows.Forms.Button();
			this.checkBoxCustomIcons = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxRefreshRate = new System.Windows.Forms.TextBox();
			this.textBoxResourcePath = new System.Windows.Forms.TextBox();
			this.flowLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCancel.Location = new System.Drawing.Point(161, 3);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 2;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonOK
			// 
			this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonOK.Location = new System.Drawing.Point(80, 3);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 3;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.buttonCancel);
			this.flowLayoutPanel1.Controls.Add(this.buttonOK);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 152);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(239, 30);
			this.flowLayoutPanel1.TabIndex = 4;
			// 
			// restartLabel
			// 
			this.restartLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.restartLabel.AutoSize = true;
			this.restartLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.restartLabel.ForeColor = System.Drawing.Color.Red;
			this.restartLabel.Location = new System.Drawing.Point(9, 133);
			this.restartLabel.Name = "restartLabel";
			this.restartLabel.Size = new System.Drawing.Size(205, 13);
			this.restartLabel.TabIndex = 7;
			this.restartLabel.Text = "Application will restart when pressing OK.";
			// 
			// checkBoxLight
			// 
			this.checkBoxLight.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.checkBoxLight, 2);
			this.checkBoxLight.Location = new System.Drawing.Point(8, 31);
			this.checkBoxLight.Name = "checkBoxLight";
			this.checkBoxLight.Size = new System.Drawing.Size(89, 17);
			this.checkBoxLight.TabIndex = 6;
			this.checkBoxLight.Text = "Light Theme";
			this.checkBoxLight.UseVisualStyleBackColor = true;
			this.checkBoxLight.CheckedChanged += new System.EventHandler(this.checkBoxLight_CheckedChanged);
			// 
			// checkBoxAutorun
			// 
			this.checkBoxAutorun.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.checkBoxAutorun, 2);
			this.checkBoxAutorun.Location = new System.Drawing.Point(8, 8);
			this.checkBoxAutorun.Name = "checkBoxAutorun";
			this.checkBoxAutorun.Size = new System.Drawing.Size(208, 17);
			this.checkBoxAutorun.TabIndex = 5;
			this.checkBoxAutorun.Text = "Start KeyLockDisplay with Windows";
			this.checkBoxAutorun.UseVisualStyleBackColor = true;
			// 
			// folderBrowserDialog1
			// 
			this.folderBrowserDialog1.ShowNewFolderButton = false;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Controls.Add(this.checkBoxLight, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.checkBoxAutorun, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.button1, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.checkBoxCustomIcons, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.textBoxRefreshRate, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.textBoxResourcePath, 0, 3);
			this.tableLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
			this.tableLayoutPanel1.RowCount = 5;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.42857F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.57143F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(236, 132);
			this.tableLayoutPanel1.TabIndex = 9;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.Location = new System.Drawing.Point(158, 57);
			this.button1.Name = "button1";
			this.tableLayoutPanel1.SetRowSpan(this.button1, 2);
			this.button1.Size = new System.Drawing.Size(70, 37);
			this.button1.TabIndex = 8;
			this.button1.Text = "Icon Source";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// checkBoxCustomIcons
			// 
			this.checkBoxCustomIcons.AutoSize = true;
			this.checkBoxCustomIcons.Location = new System.Drawing.Point(8, 57);
			this.checkBoxCustomIcons.Name = "checkBoxCustomIcons";
			this.checkBoxCustomIcons.Size = new System.Drawing.Size(117, 15);
			this.checkBoxCustomIcons.TabIndex = 7;
			this.checkBoxCustomIcons.Text = "Use Custom Icons";
			this.checkBoxCustomIcons.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 105);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(144, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Refresh Time (ms)";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxRefreshRate
			// 
			this.textBoxRefreshRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxRefreshRate.Location = new System.Drawing.Point(158, 101);
			this.textBoxRefreshRate.Name = "textBoxRefreshRate";
			this.textBoxRefreshRate.Size = new System.Drawing.Size(70, 22);
			this.textBoxRefreshRate.TabIndex = 11;
			this.textBoxRefreshRate.TextChanged += new System.EventHandler(this.textBoxRefreshRate_TextChanged);
			// 
			// textBoxResourcePath
			// 
			this.textBoxResourcePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxResourcePath.Location = new System.Drawing.Point(8, 78);
			this.textBoxResourcePath.Name = "textBoxResourcePath";
			this.textBoxResourcePath.Size = new System.Drawing.Size(144, 22);
			this.textBoxResourcePath.TabIndex = 12;
			// 
			// SettingsForm
			// 
			this.AcceptButton = this.buttonOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(239, 182);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.restartLabel);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsForm";
			this.Text = "KeyLockDisplay Settings";
			this.Load += new System.EventHandler(this.SettingsForm_Load);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label restartLabel;
        private System.Windows.Forms.CheckBox checkBoxLight;
        private System.Windows.Forms.CheckBox checkBoxAutorun;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckBox checkBoxCustomIcons;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxRefreshRate;
		private System.Windows.Forms.TextBox textBoxResourcePath;
	}
}