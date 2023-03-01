using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Threading.Timer;

namespace KeyLockDisplay
{
    static class Program
    {
        static bool _isLightMode = false;

        private static Timer _timer;

        static NotifyIcon _lockIcon;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            _isLightMode = Properties.Settings.Default.LightMode;

            //Create the context menu and its items
            ContextMenu contextMenu = new ContextMenu();
            MenuItem contextItemSettings = new MenuItem();
            MenuItem contextItemAbout = new MenuItem();
            MenuItem contextItemExit = new MenuItem();

            //Setup the context menu items
            contextItemSettings.Text = "&Settings";
            contextItemAbout.Text = "&About";
            contextItemExit.Text = "&Exit";
            contextItemSettings.Click += new EventHandler(contextMenuSettings_Click);
            contextItemAbout.Click += new EventHandler(contextMenuAbout_Click);
            contextItemExit.Click += new EventHandler(contextMenuExit_Click);

            //Add the context menu items to the context menu
            contextMenu.MenuItems.Add(contextItemSettings);
            contextMenu.MenuItems.Add(contextItemAbout);
            contextMenu.MenuItems.Add(contextItemExit);

            //Create system tray icons
            _lockIcon = new NotifyIcon();

            //Setup lockIcon
            _lockIcon.MouseClick += new MouseEventHandler(lockIcon_MouseClick);
            _lockIcon.ContextMenu = contextMenu;
            _lockIcon.Visible = true;

            // run updateLockIcon every n ms
            _timer = new Timer(UpdateLockIcon, null, 0, Properties.Settings.Default.RefreshTime);

            //Launch
            Application.Run();
        }

        private static void UpdateLockIcon(object state)
        {
            Icon lockStateIcon = KeyStateIcon();
            String lockStateString = KeyStateString();

            _lockIcon.Icon = lockStateIcon;
            _lockIcon.Text = lockStateString;
        }

        private static Icon KeyStateIcon()
        {
            string lockString = "";

            // if capslock, numlock, scrolllock or insert is on, add a letter to the string
            if (Control.IsKeyLocked(Keys.CapsLock)) lockString += "C";
            if (Control.IsKeyLocked(Keys.NumLock)) lockString += "N";
            if (Control.IsKeyLocked(Keys.Insert)) lockString += "I";
            if (Control.IsKeyLocked(Keys.Scroll)) lockString += "S";

            // if the string is empty, return the default icon
            if (lockString == "")
                lockString = "None";

            // Add the appropriate suffix for the current theme mode
            lockString += _isLightMode ? "_W" : "_B";

            if (Properties.Settings.Default.UseCustomIcons)
            {
                // get icon from folder stored in Properties
                string path = Properties.Settings.Default.CustomIconPath;
                string iconPath = $"{path}/Active_{lockString}.ico";
                return new Icon(iconPath);
            }
            else
            {
                return (Icon)Properties.Resources.ResourceManager.GetObject("Active_" + lockString);
            }
        }
        private static string KeyStateString()
        {
            string lockString = "";

            // get program name and version
            lockString += $"{Application.ProductName} {Application.ProductVersion}\n\n";

            if (Control.IsKeyLocked(Keys.CapsLock)) lockString += "CapsLock\n";
            if (Control.IsKeyLocked(Keys.NumLock)) lockString += "NumLock\n";
            if (Control.IsKeyLocked(Keys.Insert)) lockString += "Insert\n";
            if (Control.IsKeyLocked(Keys.Scroll)) lockString += "ScrollLock";

            return lockString;
        }

        #region Icon Click
        private static void lockIcon_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    break;
                case MouseButtons.Right:
                    break;
                case MouseButtons.Middle:
                    break;
            }
        }
        #endregion

        #region Context Menu
        private static void contextMenuSettings_Click(object sender, System.EventArgs e) => new SettingsForm().ShowDialog();
        private static void contextMenuAbout_Click(object sender, System.EventArgs e) => new AboutForm().ShowDialog();
        private static void contextMenuExit_Click(object sender, System.EventArgs e) => Application.Exit();
        #endregion

        [DllImport("user32.dll", SetLastError = true)]
        public static extern void keybd_event(byte virtualKey, byte scanCode, uint flags, IntPtr extraInfo);
    }

}
