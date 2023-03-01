using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KeyLockDisplay
{
    public partial class AboutForm : Form
    {
        bool _isLightMode = Properties.Settings.Default.LightMode;

        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            this.Text = String.Format("KeyLockDisplay {0}", Application.ProductVersion);
            _isLightMode = Properties.Settings.Default.LightMode;

            ApplyTheme();
        }

        void ApplyTheme()
        {
            this.BackColor = ColorTranslator.FromHtml(_isLightMode ? "#f0f0f0" : "#1f1f1f");
            this.ForeColor = ColorTranslator.FromHtml(_isLightMode ? "#000" : "#fff");

            aboutBox.BackColor = ColorTranslator.FromHtml(_isLightMode ? "#f0f0f0" : "#1f1f1f");
            aboutBox.ForeColor = ColorTranslator.FromHtml(_isLightMode ? "#000" : "#fff");
        }

		private void aboutBox_TextChanged(object sender, EventArgs e)
        {

        }

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
            Process.Start("https://github.com/Jordy3D/KeyLockDisplay");
        }
	}
}
