using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameDefenderKiller
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnOff;
        private Button btnOn;
        private Button btnLicense;
        private Button btnLang;
        private Label lblStatus;

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
            this.btnOff = new Button();
            this.btnOn = new Button();
            this.btnLicense = new Button();
            this.btnLang = new Button();
            this.lblStatus = new Label();
            this.SuspendLayout();

            // btnOff
            this.btnOff.Location = new System.Drawing.Point(20, 20);
            this.btnOff.Size = new System.Drawing.Size(150, 70);
            this.btnOff.BackColor = System.Drawing.Color.DarkRed;
            this.btnOff.ForeColor = System.Drawing.Color.White;
            this.btnOff.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.btnOff.Click += new System.EventHandler(this.BtnOff_Click);

            // btnOn
            this.btnOn.Location = new System.Drawing.Point(180, 20);
            this.btnOn.Size = new System.Drawing.Size(150, 70);
            this.btnOn.BackColor = System.Drawing.Color.DarkGreen;
            this.btnOn.ForeColor = System.Drawing.Color.White;
            this.btnOn.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.btnOn.Click += new System.EventHandler(this.BtnOn_Click);

            // btnLicense
            this.btnLicense.Location = new System.Drawing.Point(340, 20);
            this.btnLicense.Size = new System.Drawing.Size(80, 70);
            this.btnLicense.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.btnLicense.ForeColor = System.Drawing.Color.White;
            this.btnLicense.Font = new System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Regular);
            this.btnLicense.Click += new System.EventHandler(this.BtnLicense_Click);

            // btnLang
            this.btnLang.Location = new System.Drawing.Point(430, 20);
            this.btnLang.Size = new System.Drawing.Size(60, 70);
            this.btnLang.BackColor = System.Drawing.Color.FromArgb(50, 50, 60);
            this.btnLang.ForeColor = System.Drawing.Color.White;
            this.btnLang.Font = new System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Regular);
            this.btnLang.Click += new System.EventHandler(this.BtnLang_Click);

            // lblStatus
            this.lblStatus.Location = new System.Drawing.Point(20, 100);
            this.lblStatus.Size = new System.Drawing.Size(470, 40);
            this.lblStatus.ForeColor = System.Drawing.Color.LightGray;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // MainForm
            this.ClientSize = new System.Drawing.Size(510, 160);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.btnOn);
            this.Controls.Add(this.btnLicense);
            this.Controls.Add(this.btnLang);
            this.Controls.Add(this.lblStatus);
            this.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
        }
    }
}