namespace SosyalYardimProjesi
{
    partial class YardimProjeleriForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbProjeler;
        private System.Windows.Forms.ComboBox cmbKurumlar;
        private System.Windows.Forms.TextBox txtBagisMiktari;
        private System.Windows.Forms.Button btnBagisYap;
        private System.Windows.Forms.Label lblProje;
        private System.Windows.Forms.Label lblKurum;
        private System.Windows.Forms.Label lblBagisMiktari;

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
            this.cmbProjeler = new System.Windows.Forms.ComboBox();
            this.cmbKurumlar = new System.Windows.Forms.ComboBox();
            this.txtBagisMiktari = new System.Windows.Forms.TextBox();
            this.btnBagisYap = new System.Windows.Forms.Button();
            this.lblProje = new System.Windows.Forms.Label();
            this.lblKurum = new System.Windows.Forms.Label();
            this.lblBagisMiktari = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // cmbProjeler
            // 
            this.cmbProjeler.FormattingEnabled = true;
            this.cmbProjeler.Location = new System.Drawing.Point(150, 30);
            this.cmbProjeler.Name = "cmbProjeler";
            this.cmbProjeler.Size = new System.Drawing.Size(200, 24);
            this.cmbProjeler.TabIndex = 0;
            this.cmbProjeler.SelectedIndexChanged += new System.EventHandler(this.cmbProjeler_SelectedIndexChanged);

            // 
            // cmbKurumlar
            // 
            this.cmbKurumlar.FormattingEnabled = true;
            this.cmbKurumlar.Location = new System.Drawing.Point(150, 70);
            this.cmbKurumlar.Name = "cmbKurumlar";
            this.cmbKurumlar.Size = new System.Drawing.Size(200, 24);
            this.cmbKurumlar.TabIndex = 1;

            // 
            // txtBagisMiktari
            // 
            this.txtBagisMiktari.Location = new System.Drawing.Point(150, 110);
            this.txtBagisMiktari.Name = "txtBagisMiktari";
            this.txtBagisMiktari.Size = new System.Drawing.Size(200, 22);
            this.txtBagisMiktari.TabIndex = 2;

            // 
            // btnBagisYap
            // 
            this.btnBagisYap.Location = new System.Drawing.Point(150, 150);
            this.btnBagisYap.Name = "btnBagisYap";
            this.btnBagisYap.Size = new System.Drawing.Size(200, 30);
            this.btnBagisYap.TabIndex = 3;
            this.btnBagisYap.Text = "Bağış Yap";
            this.btnBagisYap.UseVisualStyleBackColor = true;
            this.btnBagisYap.Click += new System.EventHandler(this.btnBagisYap_Click);

            // 
            // lblProje
            // 
            this.lblProje.AutoSize = true;
            this.lblProje.Location = new System.Drawing.Point(30, 30);
            this.lblProje.Name = "lblProje";
            this.lblProje.Size = new System.Drawing.Size(44, 16);
            this.lblProje.TabIndex = 4;
            this.lblProje.Text = "Proje:";

            // 
            // lblKurum
            // 
            this.lblKurum.AutoSize = true;
            this.lblKurum.Location = new System.Drawing.Point(30, 70);
            this.lblKurum.Name = "lblKurum";
            this.lblKurum.Size = new System.Drawing.Size(50, 16);
            this.lblKurum.TabIndex = 5;
            this.lblKurum.Text = "Kurum:";

            // 
            // lblBagisMiktari
            // 
            this.lblBagisMiktari.AutoSize = true;
            this.lblBagisMiktari.Location = new System.Drawing.Point(30, 110);
            this.lblBagisMiktari.Name = "lblBagisMiktari";
            this.lblBagisMiktari.Size = new System.Drawing.Size(84, 16);
            this.lblBagisMiktari.TabIndex = 6;
            this.lblBagisMiktari.Text = "Bağış Miktarı:";

            // 
            // YardimProjeleriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.lblBagisMiktari);
            this.Controls.Add(this.lblKurum);
            this.Controls.Add(this.lblProje);
            this.Controls.Add(this.btnBagisYap);
            this.Controls.Add(this.txtBagisMiktari);
            this.Controls.Add(this.cmbKurumlar);
            this.Controls.Add(this.cmbProjeler);
            this.Name = "YardimProjeleriForm";
            this.Text = "Yardım Projeleri";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
