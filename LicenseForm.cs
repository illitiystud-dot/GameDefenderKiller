using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace GameDefenderKiller
{
    public partial class LicenseForm : Form
    {
        public LicenseForm()
        {
            InitializeComponent();
            UpdateLanguage();
            LanguageHelper.LanguageChanged += OnLanguageChanged;
        }

        private void OnLanguageChanged()
        {
            UpdateLanguage();
        }

        private void UpdateLanguage()
        {
            this.Text = LanguageHelper.GetLicenseFormTitle();
            this.lblLicenseTitle.Text = LanguageHelper.GetLicenseTitle();
            this.lblLicenseBody.Text = LanguageHelper.GetLicenseBody();
            this.lblPrivacy.Text = LanguageHelper.GetPrivacyText();
            this.btnClose.Text = LanguageHelper.GetBtnCloseText();
        }

        private void OpenLink(object sender, EventArgs e)
        {
            LinkLabel link = sender as LinkLabel;
            if (link == null) return;

            // Получаем URL из свойства Tag
            string url = link.Tag as string;
            if (string.IsNullOrEmpty(url))
            {
                // Если Tag пустой, пробуем извлечь из текста (для обратной совместимости)
                string text = link.Text;
                int spaceIndex = text.IndexOf(' ');
                if (spaceIndex > 0 && text.Length > spaceIndex + 1)
                {
                    url = text.Substring(spaceIndex + 1).Trim();
                }
                else
                {
                    url = text.Trim();
                }
            }

            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show(
                    "Не удалось определить ссылку.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // Открываем ссылку
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Не удалось открыть ссылку:\n{url}\n\nОшибка: {ex.Message}",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}