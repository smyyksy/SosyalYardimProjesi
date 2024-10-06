namespace SosyalYardimProjesi
{
    partial class EtkinlikYonetimiForm
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
            this.lstEtkinlikler = new System.Windows.Forms.ListBox();
            this.btnEtkinlikEkle = new System.Windows.Forms.Button();
            this.btnEtkinlikSil = new System.Windows.Forms.Button();
            this.txtEtkinlikAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEtkinlikGuncelle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEtkinlikYeri = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEtkinlikSaati = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEtkinlikTuru = new System.Windows.Forms.TextBox();
            this.txtEtkinlikAciklama = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstEtkinlikler
            // 
            this.lstEtkinlikler.FormattingEnabled = true;
            this.lstEtkinlikler.ItemHeight = 16;
            this.lstEtkinlikler.Location = new System.Drawing.Point(12, 12);
            this.lstEtkinlikler.Name = "lstEtkinlikler";
            this.lstEtkinlikler.Size = new System.Drawing.Size(289, 484);
            this.lstEtkinlikler.TabIndex = 0;
            this.lstEtkinlikler.SelectedIndexChanged += new System.EventHandler(this.lstEtkinlikler_SelectedIndexChanged);
            // 
            // btnEtkinlikEkle
            // 
            this.btnEtkinlikEkle.Location = new System.Drawing.Point(385, 301);
            this.btnEtkinlikEkle.Name = "btnEtkinlikEkle";
            this.btnEtkinlikEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEtkinlikEkle.TabIndex = 1;
            this.btnEtkinlikEkle.Text = "Ekle";
            this.btnEtkinlikEkle.UseVisualStyleBackColor = true;
            this.btnEtkinlikEkle.Click += new System.EventHandler(this.btnEtkinlikEkle_Click);
            // 
            // btnEtkinlikSil
            // 
            this.btnEtkinlikSil.Location = new System.Drawing.Point(466, 301);
            this.btnEtkinlikSil.Name = "btnEtkinlikSil";
            this.btnEtkinlikSil.Size = new System.Drawing.Size(87, 23);
            this.btnEtkinlikSil.TabIndex = 2;
            this.btnEtkinlikSil.Text = "Sil";
            this.btnEtkinlikSil.UseVisualStyleBackColor = true;
            this.btnEtkinlikSil.Click += new System.EventHandler(this.btnEtkinlikSil_Click);
            // 
            // txtEtkinlikAdi
            // 
            this.txtEtkinlikAdi.Location = new System.Drawing.Point(307, 39);
            this.txtEtkinlikAdi.Name = "txtEtkinlikAdi";
            this.txtEtkinlikAdi.Size = new System.Drawing.Size(246, 22);
            this.txtEtkinlikAdi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Etkinlik Adı";
            // 
            // btnEtkinlikGuncelle
            // 
            this.btnEtkinlikGuncelle.Location = new System.Drawing.Point(304, 301);
            this.btnEtkinlikGuncelle.Name = "btnEtkinlikGuncelle";
            this.btnEtkinlikGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnEtkinlikGuncelle.TabIndex = 5;
            this.btnEtkinlikGuncelle.Text = "Guncelle";
            this.btnEtkinlikGuncelle.UseVisualStyleBackColor = true;
            this.btnEtkinlikGuncelle.Click += new System.EventHandler(this.btnEtkinlikGuncelle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Etkinlik Yeri";
            // 
            // txtEtkinlikYeri
            // 
            this.txtEtkinlikYeri.Location = new System.Drawing.Point(307, 206);
            this.txtEtkinlikYeri.Name = "txtEtkinlikYeri";
            this.txtEtkinlikYeri.Size = new System.Drawing.Size(246, 22);
            this.txtEtkinlikYeri.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Etkinlik Saati";
            // 
            // txtEtkinlikSaati
            // 
            this.txtEtkinlikSaati.Location = new System.Drawing.Point(307, 261);
            this.txtEtkinlikSaati.Name = "txtEtkinlikSaati";
            this.txtEtkinlikSaati.Size = new System.Drawing.Size(246, 22);
            this.txtEtkinlikSaati.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Etkinlik Açıklama";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Etkinlik Türü";
            // 
            // txtEtkinlikTuru
            // 
            this.txtEtkinlikTuru.Location = new System.Drawing.Point(307, 93);
            this.txtEtkinlikTuru.Name = "txtEtkinlikTuru";
            this.txtEtkinlikTuru.Size = new System.Drawing.Size(246, 22);
            this.txtEtkinlikTuru.TabIndex = 12;
            // 
            // txtEtkinlikAciklama
            // 
            this.txtEtkinlikAciklama.Location = new System.Drawing.Point(307, 149);
            this.txtEtkinlikAciklama.Name = "txtEtkinlikAciklama";
            this.txtEtkinlikAciklama.Size = new System.Drawing.Size(246, 22);
            this.txtEtkinlikAciklama.TabIndex = 13;
            // 
            // EtkinlikYonetimiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 508);
            this.Controls.Add(this.txtEtkinlikAciklama);
            this.Controls.Add(this.txtEtkinlikTuru);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEtkinlikSaati);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEtkinlikYeri);
            this.Controls.Add(this.btnEtkinlikGuncelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEtkinlikAdi);
            this.Controls.Add(this.btnEtkinlikSil);
            this.Controls.Add(this.btnEtkinlikEkle);
            this.Controls.Add(this.lstEtkinlikler);
            this.Name = "EtkinlikYonetimiForm";
            this.Text = "Etkinlik Yönetimi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstEtkinlikler;
        private System.Windows.Forms.Button btnEtkinlikEkle;
        private System.Windows.Forms.Button btnEtkinlikSil;
        private System.Windows.Forms.TextBox txtEtkinlikAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEtkinlikGuncelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEtkinlikYeri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEtkinlikSaati;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEtkinlikTuru;
        private System.Windows.Forms.TextBox txtEtkinlikAciklama;
    }
}
