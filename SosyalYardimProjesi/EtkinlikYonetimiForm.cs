using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SosyalYardimProjesi
{
    public partial class EtkinlikYonetimiForm : Form
    {
        public EtkinlikYonetimiForm()
        {
            InitializeComponent();
            PopulateEtkinlikList(); // Etkinlik listesini form yüklendiğinde doldur
        }

        private void PopulateEtkinlikList()
        {
            string query = "SELECT EtkinlikID, EtkinlikAdi, EtkinlikYeri, EtkinlikSaati, EtkinlikTuru, EtkinlikAciklama FROM Etkinlikler";
            DataTable dt = new DataTable();

            using (var connection = DatabaseHelper.GetConnection())
            {
                var adapter = new SqlDataAdapter(query, connection);

                try
                {
                    connection.Open();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        lstEtkinlikler.DisplayMember = "EtkinlikAdi";
                        lstEtkinlikler.ValueMember = "EtkinlikID";
                        lstEtkinlikler.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanından etkinlikler alınamadı: " + ex.Message);
                }
            }
        }

        private void btnEtkinlikEkle_Click(object sender, EventArgs e)
        {
            string etkinlikAdi = txtEtkinlikAdi.Text;
            string etkinlikYeri = txtEtkinlikYeri.Text;
            string etkinlikSaati = txtEtkinlikSaati.Text;
            string etkinlikTuru = txtEtkinlikTuru.Text;
            string etkinlikAciklama = txtEtkinlikAciklama.Text;

            if (string.IsNullOrEmpty(etkinlikAdi) || string.IsNullOrEmpty(etkinlikYeri) || string.IsNullOrEmpty(etkinlikSaati) || string.IsNullOrEmpty(etkinlikTuru) || string.IsNullOrEmpty(etkinlikAciklama))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "INSERT INTO Etkinlikler (EtkinlikAdi, EtkinlikYeri, EtkinlikSaati, EtkinlikTuru, EtkinlikAciklama) VALUES (@EtkinlikAdi, @EtkinlikYeri, @EtkinlikSaati, @EtkinlikTuru, @EtkinlikAciklama)";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EtkinlikAdi", etkinlikAdi);
                command.Parameters.AddWithValue("@EtkinlikYeri", etkinlikYeri);
                command.Parameters.AddWithValue("@EtkinlikSaati", etkinlikSaati);
                command.Parameters.AddWithValue("@EtkinlikTuru", etkinlikTuru);
                command.Parameters.AddWithValue("@EtkinlikAciklama", etkinlikAciklama);

                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Etkinlik başarıyla eklendi.");
                        PopulateEtkinlikList(); // Liste güncellensin
                        ClearInputFields();
                    }
                    else
                    {
                        MessageBox.Show("Etkinlik eklenirken bir hata oluştu.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Etkinlik eklenirken bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void btnEtkinlikGuncelle_Click(object sender, EventArgs e)
        {
            if (lstEtkinlikler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen güncellenecek etkinliği seçiniz.");
                return;
            }

            DataRowView selectedRow = lstEtkinlikler.SelectedItem as DataRowView;
            int etkinlikID = Convert.ToInt32(selectedRow["EtkinlikID"]);
            string etkinlikAdi = txtEtkinlikAdi.Text;
            string etkinlikYeri = txtEtkinlikYeri.Text;
            string etkinlikSaati = txtEtkinlikSaati.Text;
            string etkinlikTuru = txtEtkinlikTuru.Text;
            string etkinlikAciklama = txtEtkinlikAciklama.Text;

            if (string.IsNullOrEmpty(etkinlikAdi) || string.IsNullOrEmpty(etkinlikYeri) || string.IsNullOrEmpty(etkinlikSaati) || string.IsNullOrEmpty(etkinlikTuru) || string.IsNullOrEmpty(etkinlikAciklama))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "UPDATE Etkinlikler SET EtkinlikAdi = @EtkinlikAdi, EtkinlikYeri = @EtkinlikYeri, EtkinlikSaati = @EtkinlikSaati, EtkinlikTuru = @EtkinlikTuru, EtkinlikAciklama = @EtkinlikAciklama WHERE EtkinlikID = @EtkinlikID";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EtkinlikID", etkinlikID);
                command.Parameters.AddWithValue("@EtkinlikAdi", etkinlikAdi);
                command.Parameters.AddWithValue("@EtkinlikYeri", etkinlikYeri);
                command.Parameters.AddWithValue("@EtkinlikSaati", etkinlikSaati);
                command.Parameters.AddWithValue("@EtkinlikTuru", etkinlikTuru);
                command.Parameters.AddWithValue("@EtkinlikAciklama", etkinlikAciklama);

                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Etkinlik başarıyla güncellendi.");
                        PopulateEtkinlikList(); // Liste güncellensin
                        ClearInputFields();
                    }
                    else
                    {
                        MessageBox.Show("Etkinlik güncellenirken bir hata oluştu.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Etkinlik güncellenirken bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void btnEtkinlikSil_Click(object sender, EventArgs e)
        {
            if (lstEtkinlikler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen silinecek etkinliği seçiniz.");
                return;
            }

            DataRowView selectedRow = lstEtkinlikler.SelectedItem as DataRowView;
            int etkinlikID = Convert.ToInt32(selectedRow["EtkinlikID"]);

            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "DELETE FROM Etkinlikler WHERE EtkinlikID = @EtkinlikID";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EtkinlikID", etkinlikID);

                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Etkinlik başarıyla silindi.");
                        PopulateEtkinlikList(); // Liste güncellensin
                    }
                    else
                    {
                        MessageBox.Show("Etkinlik silinirken bir hata oluştu.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Etkinlik silinirken bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void lstEtkinlikler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEtkinlikler.SelectedItem != null)
            {
                DataRowView selectedRow = lstEtkinlikler.SelectedItem as DataRowView;
                txtEtkinlikAdi.Text = selectedRow["EtkinlikAdi"].ToString();
                txtEtkinlikYeri.Text = selectedRow["EtkinlikYeri"].ToString();
                txtEtkinlikSaati.Text = selectedRow["EtkinlikSaati"].ToString();
                txtEtkinlikTuru.Text = selectedRow["EtkinlikTuru"].ToString();
                txtEtkinlikAciklama.Text = selectedRow["EtkinlikAciklama"].ToString();
            }
        }

        private void ClearInputFields()
        {
            txtEtkinlikAdi.Text = "";
            txtEtkinlikYeri.Text = "";
            txtEtkinlikSaati.Text = "";
            txtEtkinlikTuru.Text = "";
            txtEtkinlikAciklama.Text = "";
        }
    }
}
