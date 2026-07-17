using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameDefenderKiller
{
    partial class LicenseForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblLicenseTitle;
        private Label lblLicenseBody;
        private Label lblPrivacy;
        private LinkLabel linkCcUrl;
        private LinkLabel linkYouTube;
        private LinkLabel linkVK;
        private LinkLabel linkDzen;
        private LinkLabel linkTelegram;
        private LinkLabel linkBoosty;
        private LinkLabel linkTikTok; // НОВАЯ ССЫЛКА НА TIKTOK
        private Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblLicenseTitle = new Label();
            this.lblLicenseBody = new Label();
            this.lblPrivacy = new Label();
            this.linkCcUrl = new LinkLabel();
            this.linkYouTube = new LinkLabel();
            this.linkVK = new LinkLabel();
            this.linkDzen = new LinkLabel();
            this.linkTelegram = new LinkLabel();
            this.linkBoosty = new LinkLabel();
            this.linkTikTok = new LinkLabel(); // ИНИЦИАЛИЗАЦИЯ
            this.btnClose = new Button();
            this.SuspendLayout();

            // lblLicenseTitle
            this.lblLicenseTitle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            this.lblLicenseTitle.ForeColor = Color.White;
            this.lblLicenseTitle.Location = new Point(20, 20);
            this.lblLicenseTitle.Size = new Size(360, 30);
            this.lblLicenseTitle.TextAlign = ContentAlignment.MiddleCenter;

            // lblLicenseBody
            this.lblLicenseBody.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            this.lblLicenseBody.ForeColor = Color.LightGray;
            this.lblLicenseBody.Location = new Point(20, 60);
            this.lblLicenseBody.Size = new Size(360, 200);
            this.lblLicenseBody.TextAlign = ContentAlignment.TopLeft;

            // linkCcUrl
            this.linkCcUrl.Text = "📜 https://creativecommons.org/licenses/by-nc-nd/4.0/";
            this.linkCcUrl.Tag = "https://creativecommons.org/licenses/by-nc-nd/4.0/";
            this.linkCcUrl.Location = new Point(30, 265);
            this.linkCcUrl.Size = new Size(340, 20);
            this.linkCcUrl.LinkColor = Color.SkyBlue;
            this.linkCcUrl.Click += new EventHandler(this.OpenLink);

            // lblPrivacy
            this.lblPrivacy.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            this.lblPrivacy.ForeColor = Color.LimeGreen;
            this.lblPrivacy.BackColor = Color.FromArgb(20, 40, 20);
            this.lblPrivacy.Location = new Point(20, 300);
            this.lblPrivacy.Size = new Size(360, 45);
            this.lblPrivacy.TextAlign = ContentAlignment.MiddleCenter;

            // linkYouTube
            this.linkYouTube.Text = "▶ YouTube";
            this.linkYouTube.Tag = "https://www.youtube.com/@pavel_daily2";
            this.linkYouTube.Location = new Point(30, 355);
            this.linkYouTube.Size = new Size(340, 20);
            this.linkYouTube.LinkColor = Color.SkyBlue;
            this.linkYouTube.Click += new EventHandler(this.OpenLink);

            // linkVK
            this.linkVK.Text = "📘 VK";
            this.linkVK.Tag = "https://vk.com/pavel_daily2";
            this.linkVK.Location = new Point(30, 380);
            this.linkVK.Size = new Size(340, 20);
            this.linkVK.LinkColor = Color.SkyBlue;
            this.linkVK.Click += new EventHandler(this.OpenLink);

            // linkDzen
            this.linkDzen.Text = "📰 Дзен";
            this.linkDzen.Tag = "https://dzen.ru/pavel_daily2";
            this.linkDzen.Location = new Point(30, 405);
            this.linkDzen.Size = new Size(340, 20);
            this.linkDzen.LinkColor = Color.SkyBlue;
            this.linkDzen.Click += new EventHandler(this.OpenLink);

            // linkTelegram
            this.linkTelegram.Text = "✈ Telegram";
            this.linkTelegram.Tag = "https://t.me/pavel_daily2";
            this.linkTelegram.Location = new Point(30, 430);
            this.linkTelegram.Size = new Size(340, 20);
            this.linkTelegram.LinkColor = Color.SkyBlue;
            this.linkTelegram.Click += new EventHandler(this.OpenLink);

            // linkBoosty
            this.linkBoosty.Text = "⭐ Закрытый канал (Boosty)";
            this.linkBoosty.Tag = "https://boosty.to/kpavels1997/purchase/4003188";
            this.linkBoosty.Location = new Point(30, 455);
            this.linkBoosty.Size = new Size(340, 20);
            this.linkBoosty.LinkColor = Color.Gold;
            this.linkBoosty.Click += new EventHandler(this.OpenLink);

            // ========== НОВАЯ ССЫЛКА НА TIKTOK ==========
            this.linkTikTok.Text = "🎵 TikTok";
            this.linkTikTok.Tag = "https://www.tiktok.com/@pavel_daily1";
            this.linkTikTok.Location = new Point(30, 480);
            this.linkTikTok.Size = new Size(340, 20);
            this.linkTikTok.LinkColor = Color.SkyBlue;
            this.linkTikTok.Click += new EventHandler(this.OpenLink);

            // btnClose
            this.btnClose.Location = new Point(150, 515);
            this.btnClose.Size = new Size(100, 30);
            this.btnClose.BackColor = Color.Gray;
            this.btnClose.ForeColor = Color.White;
            this.btnClose.Click += new EventHandler(this.BtnClose_Click);
            this.btnClose.FlatStyle = FlatStyle.Flat;

            // LicenseForm
            this.ClientSize = new Size(400, 570); // УВЕЛИЧИЛ ВЫСОТУ ОКНА
            this.Controls.Add(this.lblLicenseTitle);
            this.Controls.Add(this.lblLicenseBody);
            this.Controls.Add(this.linkCcUrl);
            this.Controls.Add(this.lblPrivacy);
            this.Controls.Add(this.linkYouTube);
            this.Controls.Add(this.linkVK);
            this.Controls.Add(this.linkDzen);
            this.Controls.Add(this.linkTelegram);
            this.Controls.Add(this.linkBoosty);
            this.Controls.Add(this.linkTikTok); // ДОБАВИЛИ В КОЛЛЕКЦИЮ
            this.Controls.Add(this.btnClose);
            this.BackColor = Color.FromArgb(30, 30, 35);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.ResumeLayout(false);
        }
    }
}