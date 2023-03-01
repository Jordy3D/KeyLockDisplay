namespace KeyLockDisplay
{
    partial class AboutForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
			this.aboutBox = new System.Windows.Forms.RichTextBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// aboutBox
			// 
			this.aboutBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.aboutBox.CausesValidation = false;
			this.aboutBox.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.aboutBox.ForeColor = System.Drawing.Color.Black;
			this.aboutBox.HideSelection = false;
			this.aboutBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.aboutBox.Location = new System.Drawing.Point(3, 3);
			this.aboutBox.Name = "aboutBox";
			this.aboutBox.ReadOnly = true;
			this.aboutBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.aboutBox.ShortcutsEnabled = false;
			this.aboutBox.Size = new System.Drawing.Size(276, 138);
			this.aboutBox.TabIndex = 26;
			this.aboutBox.Text = resources.GetString("aboutBox.Text");
			this.aboutBox.TextChanged += new System.EventHandler(this.aboutBox_TextChanged);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.aboutBox);
			this.flowLayoutPanel1.Controls.Add(this.linkLabel1);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(276, 164);
			this.flowLayoutPanel1.TabIndex = 27;
			// 
			// linkLabel1
			// 
			this.linkLabel1.ActiveLinkColor = System.Drawing.Color.White;
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.LinkColor = System.Drawing.Color.CornflowerBlue;
			this.linkLabel1.Location = new System.Drawing.Point(3, 144);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(144, 13);
			this.linkLabel1.TabIndex = 27;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "KeyLock Display on GitHub";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(276, 164);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutForm";
			this.Text = "KeyLockDisplay {0}";
			this.Load += new System.EventHandler(this.AboutForm_Load);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox aboutBox;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.LinkLabel linkLabel1;
	}
}