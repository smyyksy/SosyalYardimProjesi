namespace SosyalYardimProjesi
{
    partial class AdminPanelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.btnAileYonetimi = new System.Windows.Forms.Button();
            this.btnEtkinlikYonetimi = new System.Windows.Forms.Button();
            this.btnYardimProjeleri = new System.Windows.Forms.Button();
            this.lblSurum = new System.Windows.Forms.Label();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.btnKullaniciYonetimi = new System.Windows.Forms.Button();
            this.btnYardimProjeleriYonetimi = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.Control;
            this.panel.Controls.Add(this.btnYardimProjeleriYonetimi);
            this.panel.Controls.Add(this.btnKullaniciYonetimi);
            this.panel.Controls.Add(this.btnAileYonetimi);
            this.panel.Controls.Add(this.btnEtkinlikYonetimi);
            this.panel.Controls.Add(this.btnYardimProjeleri);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 84);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(800, 366);
            this.panel.TabIndex = 3;
            // 
            // btnAileYonetimi
            // 
            this.btnAileYonetimi.Location = new System.Drawing.Point(43, 43);
            this.btnAileYonetimi.Name = "btnAileYonetimi";
            this.btnAileYonetimi.Size = new System.Drawing.Size(150, 50);
            this.btnAileYonetimi.TabIndex = 0;
            this.btnAileYonetimi.Text = "Aile Yönetim";
            this.btnAileYonetimi.Click += new System.EventHandler(this.btnAileYonetimi_Click);
            // 
            // btnEtkinlikYonetimi
            // 
            this.btnEtkinlikYonetimi.Location = new System.Drawing.Point(202, 94);
            this.btnEtkinlikYonetimi.Name = "btnEtkinlikYonetimi";
            this.btnEtkinlikYonetimi.Size = new System.Drawing.Size(150, 50);
            this.btnEtkinlikYonetimi.TabIndex = 1;
            this.btnEtkinlikYonetimi.Text = "Etkinlik Yönetimi";
            this.btnEtkinlikYonetimi.Click += new System.EventHandler(this.btnEtkinlikYonetimi_Click);
            // 
            // btnYardimProjeleri
            // 
            this.btnYardimProjeleri.Location = new System.Drawing.Point(806, 131);
            this.btnYardimProjeleri.Name = "btnYardimProjeleri";
            this.btnYardimProjeleri.Size = new System.Drawing.Size(150, 50);
            this.btnYardimProjeleri.TabIndex = 2;
            this.btnYardimProjeleri.Text = "Yardım Projeleri";
            // 
            // lblSurum
            // 
            this.lblSurum.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSurum.Font = new System.Drawing.Font("Arial", 12F);
            this.lblSurum.Location = new System.Drawing.Point(0, 43);
            this.lblSurum.Name = "lblSurum";
            this.lblSurum.Size = new System.Drawing.Size(800, 41);
            this.lblSurum.TabIndex = 4;
            this.lblSurum.Text = "Sürüm 1.0";
            this.lblSurum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBaslik
            // 
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(800, 43);
            this.lblBaslik.TabIndex = 5;
            this.lblBaslik.Text = "Sosyal Yardım ve Gönüllü Yönetim Sistemi";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKullaniciYonetimi
            // 
            this.btnKullaniciYonetimi.Location = new System.Drawing.Point(358, 143);
            this.btnKullaniciYonetimi.Name = "btnKullaniciYonetimi";
            this.btnKullaniciYonetimi.Size = new System.Drawing.Size(150, 50);
            this.btnKullaniciYonetimi.TabIndex = 3;
            this.btnKullaniciYonetimi.Text = "Kullanici Yonetimi";
            this.btnKullaniciYonetimi.Click += new System.EventHandler(this.btnKullaniciYonetimi_Click);
            // 
            // btnYardimProjeleriYonetimi
            // 
            this.btnYardimProjeleriYonetimi.Location = new System.Drawing.Point(504, 199);
            this.btnYardimProjeleriYonetimi.Name = "btnYardimProjeleriYonetimi";
            this.btnYardimProjeleriYonetimi.Size = new System.Drawing.Size(150, 50);
            this.btnYardimProjeleriYonetimi.TabIndex = 4;
            this.btnYardimProjeleriYonetimi.Text = "YardimProjeleri Yonetimi";
            this.btnYardimProjeleriYonetimi.Click += new System.EventHandler(this.btnYardimProjeleriYonetimi_Click);
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lblSurum);
            this.Controls.Add(this.lblBaslik);
            this.Name = "AdminPanelForm";
            this.Text = "AdminPanelForm";
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnAileYonetimi;
        private System.Windows.Forms.Button btnEtkinlikYonetimi;
        private System.Windows.Forms.Button btnYardimProjeleri;
        private System.Windows.Forms.Label lblSurum;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnYardimProjeleriYonetimi;
        private System.Windows.Forms.Button btnKullaniciYonetimi;
    }
}