namespace SosyalYardimProjesi
{
    partial class AileYonetimiForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lstAileler = new System.Windows.Forms.ListBox();
            this.btnAileEkle = new System.Windows.Forms.Button();
            this.btnAileSil = new System.Windows.Forms.Button();
            this.txtAileAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAileGuncelle = new System.Windows.Forms.Button();
            this.btnBagisGoruntule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAileler
            // 
            this.lstAileler.FormattingEnabled = true;
            this.lstAileler.ItemHeight = 16;
            this.lstAileler.Location = new System.Drawing.Point(12, 12);
            this.lstAileler.Name = "lstAileler";
            this.lstAileler.Size = new System.Drawing.Size(289, 484);
            this.lstAileler.TabIndex = 0;
            this.lstAileler.SelectedIndexChanged += new System.EventHandler(this.lstAileler_SelectedIndexChanged);
            // 
            // btnAileEkle
            // 
            this.btnAileEkle.Location = new System.Drawing.Point(321, 121);
            this.btnAileEkle.Name = "btnAileEkle";
            this.btnAileEkle.Size = new System.Drawing.Size(137, 32);
            this.btnAileEkle.TabIndex = 1;
            this.btnAileEkle.Text = "Aile Ekle";
            this.btnAileEkle.UseVisualStyleBackColor = true;
            this.btnAileEkle.Click += new System.EventHandler(this.btnAileEkle_Click);
            // 
            // btnAileSil
            // 
            this.btnAileSil.Location = new System.Drawing.Point(321, 170);
            this.btnAileSil.Name = "btnAileSil";
            this.btnAileSil.Size = new System.Drawing.Size(137, 32);
            this.btnAileSil.TabIndex = 2;
            this.btnAileSil.Text = "Aile Sil";
            this.btnAileSil.UseVisualStyleBackColor = true;
            this.btnAileSil.Click += new System.EventHandler(this.btnAileSil_Click);
            // 
            // txtAileAdi
            // 
            this.txtAileAdi.Location = new System.Drawing.Point(321, 68);
            this.txtAileAdi.Name = "txtAileAdi";
            this.txtAileAdi.Size = new System.Drawing.Size(240, 22);
            this.txtAileAdi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Aile Adı:";
            // 
            // btnAileGuncelle
            // 
            this.btnAileGuncelle.Location = new System.Drawing.Point(321, 218);
            this.btnAileGuncelle.Name = "btnAileGuncelle";
            this.btnAileGuncelle.Size = new System.Drawing.Size(137, 32);
            this.btnAileGuncelle.TabIndex = 5;
            this.btnAileGuncelle.Text = "Aile Güncelle";
            this.btnAileGuncelle.UseVisualStyleBackColor = true;
            this.btnAileGuncelle.Click += new System.EventHandler(this.btnAileGuncelle_Click);
            // 
            // btnBagisGoruntule
            // 
            this.btnBagisGoruntule.Location = new System.Drawing.Point(321, 268);
            this.btnBagisGoruntule.Name = "btnBagisGoruntule";
            this.btnBagisGoruntule.Size = new System.Drawing.Size(137, 32);
            this.btnBagisGoruntule.TabIndex = 6;
            this.btnBagisGoruntule.Text = "Bağışları Görüntüle";
            this.btnBagisGoruntule.UseVisualStyleBackColor = true;
            this.btnBagisGoruntule.Click += new System.EventHandler(this.btnBagisGoruntule_Click);
            // 
            // AileYonetimiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.btnBagisGoruntule);
            this.Controls.Add(this.btnAileGuncelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAileAdi);
            this.Controls.Add(this.btnAileSil);
            this.Controls.Add(this.btnAileEkle);
            this.Controls.Add(this.lstAileler);
            this.Name = "AileYonetimiForm";
            this.Text = "Aile Yönetimi";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox lstAileler;
        private System.Windows.Forms.Button btnAileEkle;
        private System.Windows.Forms.Button btnAileSil;
        private System.Windows.Forms.TextBox txtAileAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAileGuncelle;
        private System.Windows.Forms.Button btnBagisGoruntule;
    }
}
