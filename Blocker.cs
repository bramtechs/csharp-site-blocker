using System;
using System.Diagnostics;
using System.IO;
using System.Security.Principal;
using System.Windows.Forms;

namespace SiteBlocker
{
    public static class Blocker
    {
        const string HOSTS_PATH = "C:/Windows/System32/drivers/etc/hosts";
        const string SITES_PATH = "Sites.txt";

        public static string[] SplitString(string text)
        {
            return text.Split('\n');
        }
        public static string GetCustomHostText()
        {
            try
            {
                return File.ReadAllText("Keep.txt");
            }
            catch (Exception e)
            {
                ShowError(e);
                return "";
            }
        }
        public static bool IsAdministrator()
        {
            return (new WindowsPrincipal(WindowsIdentity.GetCurrent()))
                      .IsInRole(WindowsBuiltInRole.Administrator);
        }
        public static void ShowError(Exception e)
        {
            MessageBox.Show(e.ToString(), "Site Blocker Error!");
        }
        public static void ShowMessage(string message)
        {
            MessageBox.Show(message, "Site Blocker Error!");
        }

        public static void WriteHosts(string hosts)
        {
            string text = GetCustomHostText();
            string[] sites = SplitString(hosts);

            foreach (var site in sites)
            {
                text += $"\n0.0.0.0 {site}";
            }
            try
            {
                File.WriteAllText(HOSTS_PATH, text);
                FlushDNS();
            }
            catch (Exception ex)
            {
                Blocker.ShowError(ex);
            }
        }
        public static void WriteCleanHosts()
        {
            try
            {
                File.WriteAllText(HOSTS_PATH, GetCustomHostText());
                FlushDNS();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        public static void StoreSites(string text)
        {
            try
            {
                File.WriteAllText(SITES_PATH, text);
            }catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        public static string LoadSites()
        {
            return File.ReadAllText(SITES_PATH);
        }
        public static void FlushDNS()
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "ipconfig /flushdns";
            process.StartInfo = startInfo;
            process.Start();
            Debug.WriteLine("DNS flushed");
        }
    }
}
