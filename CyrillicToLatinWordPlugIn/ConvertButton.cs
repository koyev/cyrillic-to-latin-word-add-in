using CyrillicToLatinWordPlugIn.Utilities;
using Microsoft.Office.Tools.Ribbon;
using Microsoft.Win32;
using Word = Microsoft.Office.Interop.Word;
using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace CyrillicToLatinWordPlugIn
{
    public partial class ConvertButton
    {
        private Thread registryMonitorThread;
        private string officeVersion;
        private int themeCode;
        private CancellationTokenSource cancellationTokenSource;

        // Declare and define an external method from a DLL, allows Windows API call 
        // provides security calls and functions for manipulating the Windows Registry
        [DllImport("advapi32.dll", SetLastError = true)]
        private static extern int RegNotifyChangeKeyValue(
            IntPtr hKey,
            bool bWatchSubtree,
            uint dwNotifyFilter,
            IntPtr hEvent,
            bool fAsynchronous
        );
        private const uint REG_NOTIFY_CHANGE_LAST_SET = 0x00000004; // Notify the caller of changes to a value of the key        

        private void ConvertButton_Load(object sender, RibbonUIEventArgs e)
        {
            officeVersion = Globals.ThisPlugIn.Application.Version;
            themeCode = GetOfficeThemeCode();

            UpdateButtonImage(themeCode);

            cancellationTokenSource = new CancellationTokenSource();
            registryMonitorThread = new Thread(() => MonitorRegistryKey(cancellationTokenSource.Token));
            registryMonitorThread.IsBackground = true;
            registryMonitorThread.Start();
        }

        private void convertBtn_Click(object sender, RibbonControlEventArgs e)
        {
            Word.Document doc = Globals.ThisPlugIn.Application.ActiveDocument;
            Word.Selection selection = Globals.ThisPlugIn.Application.Selection;

            if (selection != null && selection.Text.Length > 0)
            {
                string selectedText = selection.Text.TrimEnd('\r', '\n');
                string convertedText = TextConverter.DetectAndConvert(selection.Text);
                selection.Text = convertedText;
            }
        }

        private int GetOfficeThemeCode()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Office\" + officeVersion + @"\Common"))
            {
                return (int)key.GetValue("UI Theme", 0); // Default to 0 if the value doesn't exist
            }
        }

        private void UpdateButtonImage(int themeCode)
        {
            // The themeCode is an integer that represents the current Office theme
            // COLORFUL = 0, DARKGREY = 3, WHITE = 5, BLACK = 4
            // COLORFUL, DARKGREY AND WHITE use the light theme icon

            if (themeCode == 4)
            {
                this.convertBtn.Image = Properties.Resources.dark_theme_icon;
            }
            else
            {
                this.convertBtn.Image = Properties.Resources.light_theme_icon;
            }
        }

        private void MonitorRegistryKey(CancellationToken cancellationToken)
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Office\" + officeVersion + @"\Common", writable: false))
            {
                if (key != null)
                {
                    IntPtr hKey = key.Handle.DangerousGetHandle();
                    while (!cancellationToken.IsCancellationRequested)
                    {
                        RegNotifyChangeKeyValue(hKey, false, REG_NOTIFY_CHANGE_LAST_SET, IntPtr.Zero, true);
                        int currentThemeCode = GetOfficeThemeCode();
                        if (currentThemeCode != themeCode)
                        {
                            themeCode = currentThemeCode;
                            UpdateButtonImage(currentThemeCode);
                            this.RibbonUI?.InvalidateControl("convertBtn");
                        }
                    }
                }
            }
        }

        public void ConvertButton_Unload()
        {
            cancellationTokenSource?.Cancel();
        }
    }   
}
