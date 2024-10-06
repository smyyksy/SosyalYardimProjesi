namespace SosyalYardimProjesi
{
    partial class BagisForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKurumlar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbYardimTuru = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBagisYap = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAileler = new System.Windows.Forms.ComboBox();
            this.cmbYardimMiktari = new System.Windows.Forms.ComboBox();
            this.txtYardimMiktari = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kurum Seç";
            // 
            // cmbKurumlar
            // 
            this.cmbKurumlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKurumlar.FormattingEnabled = true;
            this.cmbKurumlar.Location = new System.Drawing.Point(134, 32);
            this.cmbKurumlar.Name = "cmbKurumlar";
            this.cmbKurumlar.Size = new System.Drawing.Size(200, 24);
            this.cmbKurumlar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yardım Türü";
            // 
            // cmbYardimTuru
            // 
            this.cmbYardimTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYardimTuru.FormattingEnabled = true;
            this.cmbYardimTuru.Items.AddRange(new object[] {
            "Un",
            "Bakliyat",
            "Fatura Yardımı"});
            this.cmbYardimTuru.Location = new System.Drawing.Point(134, 130);
            this.cmbYardimTuru.Name = "cmbYardimTuru";
            this.cmbYardimTuru.Size = new System.Drawing.Size(200, 24);
            this.cmbYardimTuru.TabIndex = 3;
            this.cmbYardimTuru.SelectedIndexChanged += new System.EventHandler(this.cmbYardimTuru_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yardım Miktarı";
            // 
            // btnBagisYap
            // 
            this.btnBagisYap.Location = new System.Drawing.Point(260, 269);
            this.btnBagisYap.Name = "btnBagisYap";
            this.btnBagisYap.Size = new System.Drawing.Size(75, 30);
            this.btnBagisYap.TabIndex = 6;
            this.btnBagisYap.Text = "Bağış Yap";
            this.btnBagisYap.UseVisualStyleBackColor = true;
            this.btnBagisYap.Click += new System.EventHandler(this.btnBagisYap_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Aile Seç";
            // 
            // cmbAileler
            // 
            this.cmbAileler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAileler.FormattingEnabled = true;
            this.cmbAileler.Location = new System.Drawing.Point(134, 78);
            this.cmbAileler.Name = "cmbAileler";
            this.cmbAileler.Size = new System.Drawing.Size(200, 24);
            this.cmbAileler.TabIndex = 8;
            // 
            // cmbYardimMiktari
            // 
            this.cmbYardimMiktari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYardimMiktari.FormattingEnabled = true;
            this.cmbYardimMiktari.Items.AddRange(new object[] {
            "Un",
            "Bakliyat",
            "Fatura Yardımı"});
            this.cmbYardimMiktari.Location = new System.Drawing.Point(135, 182);
            this.cmbYardimMiktari.Name = "cmbYardimMiktari";
            this.cmbYardimMiktari.Size = new System.Drawing.Size(200, 24);
            this.cmbYardimMiktari.TabIndex = 9;
            // 
            // txtYardimMiktari
            // 
            this.txtYardimMiktari.Location = new System.Drawing.Point(135, 212);
            this.txtYardimMiktari.Name = "txtYardimMiktari";
            this.txtYardimMiktari.Size = new System.Drawing.Size(100, 22);
            this.txtYardimMiktari.TabIndex = 10;
            this.txtYardimMiktari.Text = "00";
            // 
            // BagisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 334);
            this.Controls.Add(this.txtYardimMiktari);
            this.Controls.Add(this.cmbYardimMiktari);
            this.Controls.Add(this.cmbAileler);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBagisYap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbYardimTuru);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbKurumlar);
            this.Controls.Add(this.label1);
            this.Name = "BagisForm";
            this.Text = "Bağış Yap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKurumlar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbYardimTuru;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBagisYap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbAileler;
        private System.Windows.Forms.ComboBox cmbYardimMiktari;
        private System.Windows.Forms.TextBox txtYardimMiktari;
    }
}
