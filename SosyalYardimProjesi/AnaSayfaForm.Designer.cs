namespace SosyalYardimProjesi
{
    partial class AnaSayfaForm
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
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblSurum = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.btnBagisSayfasi = new System.Windows.Forms.Button();
            this.btnEtkinlikSayfasi = new System.Windows.Forms.Button();
            this.btnYardimProjeleri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIcerik = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(1045, 43);
            this.lblBaslik.TabIndex = 2;
            this.lblBaslik.Text = "Sosyal Yardım ve Gönüllü Yönetim Sistemi";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSurum
            // 
            this.lblSurum.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSurum.Font = new System.Drawing.Font("Arial", 12F);
            this.lblSurum.Location = new System.Drawing.Point(0, 43);
            this.lblSurum.Name = "lblSurum";
            this.lblSurum.Size = new System.Drawing.Size(1045, 41);
            this.lblSurum.TabIndex = 1;
            this.lblSurum.Text = "Sürüm 1.0";
            this.lblSurum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.Control;
            this.panel.Controls.Add(this.btnBagisSayfasi);
            this.panel.Controls.Add(this.btnEtkinlikSayfasi);
            this.panel.Controls.Add(this.btnYardimProjeleri);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 84);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1045, 425);
            this.panel.TabIndex = 0;
            // 
            // btnBagisSayfasi
            // 
            this.btnBagisSayfasi.Location = new System.Drawing.Point(75, 131);
            this.btnBagisSayfasi.Name = "btnBagisSayfasi";
            this.btnBagisSayfasi.Size = new System.Drawing.Size(150, 50);
            this.btnBagisSayfasi.TabIndex = 0;
            this.btnBagisSayfasi.Text = "Bağış Sayfası";
            this.btnBagisSayfasi.Click += new System.EventHandler(this.BtnBagisSayfasi_Click);
            // 
            // btnEtkinlikSayfasi
            // 
            this.btnEtkinlikSayfasi.Location = new System.Drawing.Point(450, 131);
            this.btnEtkinlikSayfasi.Name = "btnEtkinlikSayfasi";
            this.btnEtkinlikSayfasi.Size = new System.Drawing.Size(150, 50);
            this.btnEtkinlikSayfasi.TabIndex = 1;
            this.btnEtkinlikSayfasi.Text = "Etkinlik Sayfası";
            this.btnEtkinlikSayfasi.Click += new System.EventHandler(this.btnEtkinlikSayfasi_Click);
            // 
            // btnYardimProjeleri
            // 
            this.btnYardimProjeleri.Location = new System.Drawing.Point(806, 131);
            this.btnYardimProjeleri.Name = "btnYardimProjeleri";
            this.btnYardimProjeleri.Size = new System.Drawing.Size(150, 50);
            this.btnYardimProjeleri.TabIndex = 2;
            this.btnYardimProjeleri.Text = "Yardım Projeleri";
            this.btnYardimProjeleri.Click += new System.EventHandler(this.btnYardimProjeleri_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(0, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1045, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = " Hakkında:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIcerik
            // 
            this.lblIcerik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblIcerik.Font = new System.Drawing.Font("Arial", 10F);
            this.lblIcerik.Location = new System.Drawing.Point(0, 125);
            this.lblIcerik.Name = "lblIcerik";
            this.lblIcerik.Size = new System.Drawing.Size(1045, 41);
            this.lblIcerik.TabIndex = 5;
            this.lblIcerik.Text = "Bu proje, sosyal yardım ve gönüllü yönetimini kolaylaştırmayı amaçlamaktadır. Gel" +
    "iştiren: Sümeyye Aksoy";
            this.lblIcerik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnaSayfaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 509);
            this.Controls.Add(this.lblIcerik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lblSurum);
            this.Controls.Add(this.lblBaslik);
            this.Name = "AnaSayfaForm";
            this.Text = "AnaSayfaForm";
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblSurum;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnBagisSayfasi;
        private System.Windows.Forms.Button btnEtkinlikSayfasi;
        private System.Windows.Forms.Button btnYardimProjeleri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIcerik;
    }
}
