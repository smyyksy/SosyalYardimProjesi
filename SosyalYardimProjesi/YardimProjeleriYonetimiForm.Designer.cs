namespace SosyalYardimProjesi
{
    partial class YardimProjeleriYonetimiForm
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
            this.lstProjeler = new System.Windows.Forms.ListBox();
            this.btnProjeEkle = new System.Windows.Forms.Button();
            this.btnProjeSil = new System.Windows.Forms.Button();
            this.txtProjeAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProjeGuncelle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProjeAciklama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lstProjeler
            // 
            this.lstProjeler.FormattingEnabled = true;
            this.lstProjeler.ItemHeight = 16;
            this.lstProjeler.Location = new System.Drawing.Point(12, 12);
            this.lstProjeler.Name = "lstProjeler";
            this.lstProjeler.Size = new System.Drawing.Size(289, 484);
            this.lstProjeler.TabIndex = 0;
            this.lstProjeler.SelectedIndexChanged += new System.EventHandler(this.lstProjeler_SelectedIndexChanged);
            // 
            // btnProjeEkle
            // 
            this.btnProjeEkle.Location = new System.Drawing.Point(335, 309);
            this.btnProjeEkle.Name = "btnProjeEkle";
            this.btnProjeEkle.Size = new System.Drawing.Size(75, 23);
            this.btnProjeEkle.TabIndex = 1;
            this.btnProjeEkle.Text = "Ekle";
            this.btnProjeEkle.UseVisualStyleBackColor = true;
            this.btnProjeEkle.Click += new System.EventHandler(this.btnProjeEkle_Click);
            // 
            // btnProjeSil
            // 
            this.btnProjeSil.Location = new System.Drawing.Point(416, 309);
            this.btnProjeSil.Name = "btnProjeSil";
            this.btnProjeSil.Size = new System.Drawing.Size(75, 23);
            this.btnProjeSil.TabIndex = 2;
            this.btnProjeSil.Text = "Sil";
            this.btnProjeSil.UseVisualStyleBackColor = true;
            this.btnProjeSil.Click += new System.EventHandler(this.btnProjeSil_Click);
            // 
            // txtProjeAdi
            // 
            this.txtProjeAdi.Location = new System.Drawing.Point(335, 39);
            this.txtProjeAdi.Name = "txtProjeAdi";
            this.txtProjeAdi.Size = new System.Drawing.Size(246, 22);
            this.txtProjeAdi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Proje Adı";
            // 
            // btnProjeGuncelle
            // 
            this.btnProjeGuncelle.Location = new System.Drawing.Point(497, 309);
            this.btnProjeGuncelle.Name = "btnProjeGuncelle";
            this.btnProjeGuncelle.Size = new System.Drawing.Size(84, 23);
            this.btnProjeGuncelle.TabIndex = 5;
            this.btnProjeGuncelle.Text = "Güncelle";
            this.btnProjeGuncelle.UseVisualStyleBackColor = true;
            this.btnProjeGuncelle.Click += new System.EventHandler(this.btnProjeGuncelle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Proje Açıklama";
            // 
            // txtProjeAciklama
            // 
            this.txtProjeAciklama.Location = new System.Drawing.Point(335, 104);
            this.txtProjeAciklama.Multiline = true;
            this.txtProjeAciklama.Name = "txtProjeAciklama";
            this.txtProjeAciklama.Size = new System.Drawing.Size(246, 176);
            this.txtProjeAciklama.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kategori";
            // 
            // cmbKategori
            // 
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(335, 256);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(246, 24);
            this.cmbKategori.TabIndex = 9;
            // 
            // YardimProjeleriYonetimiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 508);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProjeAciklama);
            this.Controls.Add(this.btnProjeGuncelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProjeAdi);
            this.Controls.Add(this.btnProjeSil);
            this.Controls.Add(this.btnProjeEkle);
            this.Controls.Add(this.lstProjeler);
            this.Name = "YardimProjeleriYonetimiForm";
            this.Text = "Yardım Projeleri Yönetimi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstProjeler;
        private System.Windows.Forms.Button btnProjeEkle;
        private System.Windows.Forms.Button btnProjeSil;
        private System.Windows.Forms.TextBox txtProjeAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProjeGuncelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProjeAciklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbKategori;
    }
}
