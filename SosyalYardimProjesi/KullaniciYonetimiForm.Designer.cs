namespace SosyalYardimProjesi
{
    partial class KullaniciYonetimiForm
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
            this.lstKullanicilar = new System.Windows.Forms.ListBox();
            this.btnKullaniciEkle = new System.Windows.Forms.Button();
            this.btnKullaniciSil = new System.Windows.Forms.Button();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKullaniciGuncelle = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstKullanicilar
            // 
            this.lstKullanicilar.FormattingEnabled = true;
            this.lstKullanicilar.ItemHeight = 16;
            this.lstKullanicilar.Location = new System.Drawing.Point(12, 12);
            this.lstKullanicilar.Name = "lstKullanicilar";
            this.lstKullanicilar.Size = new System.Drawing.Size(289, 484);
            this.lstKullanicilar.TabIndex = 0;
            this.lstKullanicilar.SelectedIndexChanged += new System.EventHandler(this.lstKullanicilar_SelectedIndexChanged);
            // 
            // btnKullaniciEkle
            // 
            this.btnKullaniciEkle.Location = new System.Drawing.Point(321, 121);
            this.btnKullaniciEkle.Name = "btnKullaniciEkle";
            this.btnKullaniciEkle.Size = new System.Drawing.Size(137, 32);
            this.btnKullaniciEkle.TabIndex = 1;
            this.btnKullaniciEkle.Text = "Kullanıcı Ekle";
            this.btnKullaniciEkle.UseVisualStyleBackColor = true;
            this.btnKullaniciEkle.Click += new System.EventHandler(this.btnKullaniciEkle_Click);
            // 
            // btnKullaniciSil
            // 
            this.btnKullaniciSil.Location = new System.Drawing.Point(321, 170);
            this.btnKullaniciSil.Name = "btnKullaniciSil";
            this.btnKullaniciSil.Size = new System.Drawing.Size(137, 32);
            this.btnKullaniciSil.TabIndex = 2;
            this.btnKullaniciSil.Text = "Kullanıcı Sil";
            this.btnKullaniciSil.UseVisualStyleBackColor = true;
            this.btnKullaniciSil.Click += new System.EventHandler(this.btnKullaniciSil_Click);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(321, 38);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(206, 22);
            this.txtKullaniciAdi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // btnKullaniciGuncelle
            // 
            this.btnKullaniciGuncelle.Location = new System.Drawing.Point(321, 219);
            this.btnKullaniciGuncelle.Name = "btnKullaniciGuncelle";
            this.btnKullaniciGuncelle.Size = new System.Drawing.Size(137, 32);
            this.btnKullaniciGuncelle.TabIndex = 5;
            this.btnKullaniciGuncelle.Text = "Kullanıcı Güncelle";
            this.btnKullaniciGuncelle.UseVisualStyleBackColor = true;
            this.btnKullaniciGuncelle.Click += new System.EventHandler(this.btnKullaniciGuncelle_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(321, 89);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(206, 22);
            this.txtSifre.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Şifre";
            // 
            // KullaniciYonetimiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 510);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.btnKullaniciGuncelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.btnKullaniciSil);
            this.Controls.Add(this.btnKullaniciEkle);
            this.Controls.Add(this.lstKullanicilar);
            this.Name = "KullaniciYonetimiForm";
            this.Text = "Kullanıcı Yönetimi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstKullanicilar;
        private System.Windows.Forms.Button btnKullaniciEkle;
        private System.Windows.Forms.Button btnKullaniciSil;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKullaniciGuncelle;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label2;
    }
}
