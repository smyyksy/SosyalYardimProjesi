namespace SosyalYardimProjesi
{
    partial class EtkinlikForm
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
            this.dataGridViewEtkinlikler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEtkinlikler)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEtkinlikler
            // 
            this.dataGridViewEtkinlikler.AllowUserToAddRows = false;
            this.dataGridViewEtkinlikler.AllowUserToDeleteRows = false;
            this.dataGridViewEtkinlikler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEtkinlikler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEtkinlikler.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewEtkinlikler.Name = "dataGridViewEtkinlikler";
            this.dataGridViewEtkinlikler.ReadOnly = true;
            this.dataGridViewEtkinlikler.RowHeadersVisible = false;
            this.dataGridViewEtkinlikler.RowHeadersWidth = 51;
            this.dataGridViewEtkinlikler.RowTemplate.Height = 24;
            this.dataGridViewEtkinlikler.Size = new System.Drawing.Size(733, 376);
            this.dataGridViewEtkinlikler.TabIndex = 0;
            this.dataGridViewEtkinlikler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEtkinlikler_CellContentClick);
            // 
            // EtkinlikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 376);
            this.Controls.Add(this.dataGridViewEtkinlikler);
            this.Name = "EtkinlikForm";
            this.Text = "Etkinlikler";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEtkinlikler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEtkinlikler;
    }
}
