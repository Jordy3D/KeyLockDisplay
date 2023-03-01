using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace KeyLockDisplay
{
    public partial class SettingsForm : Form
    {
        Microsoft.Win32.RegistryKey autorun;

        bool needToRestart = false;

        bool _isLightMode = Properties.Settings.Default.LightMode;

        public SettingsForm()
        {
            InitializeComponent();
            autorun = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);

            restartLabel.Visible = false;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            checkBoxAutorun.Checked = (autorun.GetValue("KeyLockDisplay") != null);
            checkBoxLight.Checked = Properties.Settings.Default.LightMode;

            checkBoxCustomIcons.Checked = Properties.Settings.Default.UseCustomIcons;
            textBoxResourcePath.Text = Properties.Settings.Default.CustomIconPath;

            textBoxRefreshRate.Text = Properties.Settings.Default.RefreshTime.ToString();

			ApplyTheme();
        }

        void ApplyTheme()
        {
            this.BackColor = ColorTranslator.FromHtml(_isLightMode ? "#f0f0f0" : "#1f1f1f");
            this.ForeColor = ColorTranslator.FromHtml(_isLightMode ? "#000" : "#fff");

            foreach (Control c in tableLayoutPanel1.Controls)
            {
                if (c is Button)
                {
                    c.BackColor = ColorTranslator.FromHtml(_isLightMode ? "#ffffff" : "#2e2e2e");
                    c.ForeColor = ColorTranslator.FromHtml(_isLightMode ? "#000" : "#fff");
                }
            }
        }

        private void SaveSettings()
        {
            if (checkBoxAutorun.Checked)
                autorun.SetValue("KeyLockDisplay", Application.ExecutablePath);
            else
                autorun.DeleteValue("KeyLockDisplay", false);

            Properties.Settings.Default.LightMode = checkBoxLight.Checked;

            if (checkBoxCustomIcons.Checked)
			{
                Properties.Settings.Default.UseCustomIcons = true;
                Properties.Settings.Default.CustomIconPath = textBoxResourcePath.Text;
			}
            else
			{
				Properties.Settings.Default.UseCustomIcons = false;
			}

            string refreshText = textBoxRefreshRate.Text;
            // if refreshText is a number
            if (Regex.IsMatch(refreshText, @"^\d+$"))
			    Properties.Settings.Default.RefreshTime = int.Parse(refreshText);

			Properties.Settings.Default.Save();

            if (needToRestart)
                Application.Restart();
        }

        #region Buttons
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Close();
        }
        #endregion



        private void checkBoxLight_CheckedChanged(object sender, EventArgs e)
        {
            needToRestart = checkBoxLight.Checked != Properties.Settings.Default.LightMode;
            restartLabel.Visible = needToRestart;
        }

        private void checkBoxCustomIcons_CheckChanged(object sender, EventArgs e)
        {
			needToRestart = checkBoxLight.Checked != Properties.Settings.Default.UseCustomIcons;
			restartLabel.Visible = needToRestart;
		}

        private void textBoxRefreshRate_TextChanged(object sender, EventArgs e)
        {
            needToRestart = textBoxRefreshRate.Text != Properties.Settings.Default.RefreshTime.ToString();
			restartLabel.Visible = needToRestart;
		}

		private void button1_Click(object sender, EventArgs e)
        {
			DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrEmpty(folderBrowserDialog1.SelectedPath))
			{
				textBoxResourcePath.Text = folderBrowserDialog1.SelectedPath;
			}

		}
	}
}
