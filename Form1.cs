using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiteBlocker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Check if admin
            if (!Blocker.IsAdministrator())
            {
                Blocker.ShowMessage("This program needs Administrator privileges to work.\nPlease read through the source code, compile your own binary, and rerun the program as Administrator!\nMake sure you downloaded Site Blocker from bramtechs/brambasiel's Github and not from a sketchy website!\n\nThank you for listening to my TED talk.");
                BlockButton.Enabled = false;
                AllowButton.Enabled = false;
                warningLabel.BackColor = Color.LawnGreen;
                warningLabel.Text = "Administrator privileges required.";
                return;
            }

            SitesBox.Text = Blocker.LoadSites();
        }

        //UI Interaction
        private void BlockButton_Click(object sender, EventArgs e)
        {
            Blocker.WriteHosts(SitesBox.Text);
            NotifyIcon.ShowBalloonTip(3, "Sites Blocked", "Sites are now blocked.", ToolTipIcon.Warning);
        }

        private void AllowButton_Click(object sender, EventArgs e)
        {
            NotifyIcon.ShowBalloonTip(3, "Sites Allowed", "Sites are now accessible.", ToolTipIcon.Info);
        }

        private void SitesBox_TextChanged(object sender, EventArgs e)
        {
            Blocker.StoreSites(SitesBox.Text);
        }
        private void viewHostLabel_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", "C:\\Windows\\System32\\drivers\\etc\\hosts");
        }

        private void editHostsLabel_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", "Keep.txt");
        }
    }
}
