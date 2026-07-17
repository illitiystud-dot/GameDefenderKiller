using System;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Win32;

namespace GameDefenderKiller
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UpdateLanguage();
            this.Text = LanguageHelper.GetMainFormTitle();

            // Подписываемся на событие смены языка
            LanguageHelper.LanguageChanged += OnLanguageChanged;
        }

        // ========== ОБНОВЛЕНИЕ ИНТЕРФЕЙСА ПРИ СМЕНЕ ЯЗЫКА ==========
        private void OnLanguageChanged()
        {
            UpdateLanguage();
        }

        private void UpdateLanguage()
        {
            this.btnOff.Text = LanguageHelper.GetBtnOffText();
            this.btnOn.Text = LanguageHelper.GetBtnOnText();
            this.btnLicense.Text = LanguageHelper.GetBtnLicenseText();
            this.btnLang.Text = LanguageHelper.GetBtnLangText();
            this.lblStatus.Text = LanguageHelper.GetStatusReady();
            this.Text = LanguageHelper.GetMainFormTitle();
        }

        // ========== КНОПКА СМЕНЫ ЯЗЫКА ==========
        private void BtnLang_Click(object sender, EventArgs e)
        {
            string newLang = LanguageHelper.CurrentLanguage == "ru" ? "en" : "ru";
            LanguageHelper.SetLanguage(newLang);
        }

        // ==================== ОТКЛЮЧЕНИЕ ====================
        private void BtnOff_Click(object sender, EventArgs e)
        {
            if (!IsAdmin())
            {
                MessageBox.Show(
                    LanguageHelper.GetMsgNeedAdmin_Text(),
                    LanguageHelper.GetMsgNeedAdmin_Title(),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var key = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows Defender"))
                    if (key != null) key.SetValue("DisableAntiSpyware", 1, RegistryValueKind.DWord);

                using (var key = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection"))
                    if (key != null) key.SetValue("DisableRealtimeMonitoring", 1, RegistryValueKind.DWord);

                SetServiceStart("WinDefend", 4);
                SetServiceStart("WdNisSvc", 4);
                RunCmd("net stop WinDefend /y");
                RunCmd("net stop WdNisSvc /y");
                RunCmd("netsh advfirewall set allprofiles state off");

                lblStatus.Text = LanguageHelper.GetStatusOff();
                MessageBox.Show(
                    LanguageHelper.GetMsgSuccessOff_Text(),
                    LanguageHelper.GetMsgSuccessOff_Title(),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    LanguageHelper.GetMsgError_Title(),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ==================== ВКЛЮЧЕНИЕ ====================
        private void BtnOn_Click(object sender, EventArgs e)
        {
            if (!IsAdmin())
            {
                MessageBox.Show(
                    LanguageHelper.GetMsgNeedAdmin_Text(),
                    LanguageHelper.GetMsgNeedAdmin_Title(),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            try
            {
                SetServiceStart("WinDefend", 2);
                SetServiceStart("WdNisSvc", 2);
                RunCmd("net start WinDefend");
                RunCmd("net start WdNisSvc");

                using (var key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows Defender", true))
                    if (key != null) key.DeleteValue("DisableAntiSpyware", false);

                using (var key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection", true))
                    if (key != null) key.DeleteValue("DisableRealtimeMonitoring", false);

                RunCmd("netsh advfirewall set allprofiles state on");

                lblStatus.Text = LanguageHelper.GetStatusOn();
                MessageBox.Show(
                    LanguageHelper.GetMsgSuccessOn_Text(),
                    LanguageHelper.GetMsgSuccessOn_Title(),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    LanguageHelper.GetMsgError_Title(),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ========== ВСПОМОГАТЕЛЬНЫЕ МЕТОДЫ ==========
        private bool IsAdmin()
        {
            using (var identity = System.Security.Principal.WindowsIdentity.GetCurrent())
            {
                var principal = new System.Security.Principal.WindowsPrincipal(identity);
                return principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator);
            }
        }

        private void SetServiceStart(string serviceName, int startType)
        {
            try
            {
                using (var key = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\" + serviceName, true))
                    if (key != null) key.SetValue("Start", startType, RegistryValueKind.DWord);
            }
            catch { }
        }

        private void RunCmd(string command)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C " + command;
            startInfo.Verb = "runas";
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
        }

        private void BtnLicense_Click(object sender, EventArgs e)
        {
            LicenseForm licenseForm = new LicenseForm();
            licenseForm.ShowDialog();
        }
    }
}