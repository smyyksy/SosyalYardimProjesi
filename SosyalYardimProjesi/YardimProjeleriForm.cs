using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SosyalYardimProjesi
{
    public partial class YardimProjeleriForm : Form
    {
        private int kullaniciID;
        private string kullaniciAdi;
        private int secilenProjeID;

        public YardimProjeleriForm(int kullaniciID, string kullaniciAdi)
        {
            InitializeComponent();
            this.kullaniciID = kullaniciID;
            this.kullaniciAdi = kullaniciAdi;
            ListeleYardimProjeleri();
        }

        private void ListeleYardimProjeleri()
        {
            string query = "SELECT ProjeID, ProjeAdi FROM Proje";

            using (SqlConnection connection = DatabaseHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmbProjeler.DisplayMember = "ProjeAdi";
                cmbProjeler.ValueMember = "ProjeID";
                cmbProjeler.DataSource = dt;
            }
        }

        private void cmbProjeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProjeler.SelectedIndex != -1)
            {
                secilenProjeID = Convert.ToInt32(cmbProjeler.SelectedValue);
                ListeleKurumlar(secilenProjeID);
            }
        }

        private void ListeleKurumlar(int projeID)
        {
            string query = "SELECT KurumID, KurumAdi FROM Kurum";

            using (SqlConnection connection = DatabaseHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmbKurumlar.DisplayMember = "KurumAdi";
                cmbKurumlar.ValueMember = "KurumID";
                cmbKurumlar.DataSource = dt;
            }
        }

        private void btnBagisYap_Click(object sender, EventArgs e)
        {
            if (cmbKurumlar.SelectedIndex == -1 || !int.TryParse(txtBagisMiktari.Text, out int bagisMiktari) || bagisMiktari <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir bağış miktarı ve kurum seçin.");
                return;
            }

            int kurumID = Convert.ToInt32(cmbKurumlar.SelectedValue);
            string kurumAdi = cmbKurumlar.Text;

            BagisiKaydet(secilenProjeID, kurumID, kurumAdi, bagisMiktari);
        }

        private void BagisiKaydet(int projeID, int kurumID, string kurumAdi, int bagisMiktari)
        {
            string query = "INSERT INTO Bagis (KurumID, KurumAdi, YardimMiktari, KayitTarihi) " +
                           "VALUES (@KurumID, @KurumAdi, @YardimMiktari, @KayitTarihi)";

            using (SqlConnection connection = DatabaseHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@KurumID", kurumID);
                command.Parameters.AddWithValue("@KurumAdi", kurumAdi);
                command.Parameters.AddWithValue("@YardimMiktari", bagisMiktari.ToString());
                command.Parameters.AddWithValue("@KayitTarihi", DateTime.Now);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"{bagisMiktari} TL bağış yapıldı.\nKurum: {kurumAdi}\nProje: {cmbProjeler.Text}");
                    }
                    else
                    {
                        MessageBox.Show("Bağış sırasında bir hata oluştu.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }
    }
}
