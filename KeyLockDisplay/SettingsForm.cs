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

        private bool SaveSettings()
        {
            if (checkBoxAutorun.Checked)
                autorun.SetValue("KeyLockDisplay", Application.ExecutablePath);
            else
                autorun.DeleteValue("KeyLockDisplay", false);

            Properties.Settings.Default.LightMode = checkBoxLight.Checked;

            if (checkBoxCustomIcons.Checked)
            {
                // check if there's an Active_None_B.ico file in the folder
                if (!File.Exists(textBoxResourcePath.Text + @"\Active_None_B.ico"))
                {
                    MessageBox.Show("The folder you selected does not seem to contain valid icon files. \nPlease check your folder again, or sleect a different folder.", "Key Lock Display - Icon Folder Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }

                Properties.Settings.Default.UseCustomIcons = true;
                Properties.Settings.Default.CustomIconPath = textBoxResourcePath.Text;
            }
            else
            {
                Properties.Settings.Default.UseCustomIcons = false;
            }

            string refreshText = textBoxRefreshRate.Text;

            // tryparse refreshText
            if (int.TryParse(refreshText, out int newRefreshTime) && newRefreshTime > 0)
            {
                if (newRefreshTime < 100)
                    MessageBox.Show("The refresh rate supports values below 100, but it is not recommended as it may cause performance issues.", "Key Lock Display - Refresh Rate Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                Properties.Settings.Default.RefreshTime = newRefreshTime;
            }
            else
            {
                MessageBox.Show("The refresh rate must be a positive integer.", "Key Lock Display - Refresh Rate Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxRefreshRate.Text = Properties.Settings.Default.RefreshTime.ToString();
                return false;
            }

            Properties.Settings.Default.Save();

            if (needToRestart)
                Application.Restart();

            return true;
        }

        #region Buttons

        private void updateRestartLabel(bool state)
        {
            needToRestart = state;
            restartLabel.Visible = needToRestart;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (SaveSettings())
                Close();
        }
        #endregion

        private void checkBoxLight_CheckedChanged(object sender, EventArgs e)
        {
            updateRestartLabel(checkBoxLight.Checked != Properties.Settings.Default.LightMode);
        }

        private void checkBoxCustomIcons_CheckChanged(object sender, EventArgs e)
        {
            // updateRestartLabel(checkBoxCustomIcons.Checked != Properties.Settings.Default.UseCustomIcons);
        }

        private void textBoxRefreshRate_TextChanged(object sender, EventArgs e)
        {
            updateRestartLabel(textBoxRefreshRate.Text != Properties.Settings.Default.RefreshTime.ToString());
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
