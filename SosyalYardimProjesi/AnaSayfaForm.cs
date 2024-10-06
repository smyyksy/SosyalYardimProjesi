using System;
using System.Windows.Forms;

namespace SosyalYardimProjesi
{
    public partial class AnaSayfaForm : Form
    {
        private int kullaniciID;
        private string kullaniciAdi;

        public AnaSayfaForm(int kullaniciID, string kullaniciAdi)
        {
            InitializeComponent();
            this.kullaniciID = kullaniciID;
            this.kullaniciAdi = kullaniciAdi;
        }

        private void BtnBagisSayfasi_Click(object sender, EventArgs e)
        {
            BagisForm bagisForm = new BagisForm();
            bagisForm.Show();
        }

        private void btnEtkinlikSayfasi_Click(object sender, EventArgs e)
        {
            EtkinlikForm etkinlikForm = new EtkinlikForm(kullaniciID, kullaniciAdi);
            etkinlikForm.ShowDialog();
        }

        private void btnYardimProjeleri_Click(object sender, EventArgs e)
        {
            YardimProjeleriForm yardimProjeleriForm = new YardimProjeleriForm(kullaniciID, kullaniciAdi);
            yardimProjeleriForm.ShowDialog();
        }
    }
}
