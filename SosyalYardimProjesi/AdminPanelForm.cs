using System;
using System.Windows.Forms;

namespace SosyalYardimProjesi
{
    public partial class AdminPanelForm : Form
    {
        private readonly int adminID;
        private readonly string adminKullaniciAdi;

        public AdminPanelForm(int adminID, string adminKullaniciAdi)
        {
            InitializeComponent();
            this.adminID = adminID;
            this.adminKullaniciAdi = adminKullaniciAdi;
        }

        private void btnEtkinlikYonetimi_Click(object sender, EventArgs e)
        {
            EtkinlikYonetimiForm etkinlikForm = new EtkinlikYonetimiForm();
            etkinlikForm.ShowDialog();
        }

        private void btnYardimProjeleriYonetimi_Click(object sender, EventArgs e)
        {
            YardimProjeleriYonetimiForm yardimForm = new YardimProjeleriYonetimiForm();
            yardimForm.ShowDialog();
        }

        private void btnKullaniciYonetimi_Click(object sender, EventArgs e)
        {
            KullaniciYonetimiForm kullaniciForm = new KullaniciYonetimiForm();
            kullaniciForm.ShowDialog();
        }

        private void btnAileYonetimi_Click(object sender, EventArgs e)
        {
            AileYonetimiForm aileForm = new AileYonetimiForm();
            aileForm.ShowDialog();
        }
    }
}
