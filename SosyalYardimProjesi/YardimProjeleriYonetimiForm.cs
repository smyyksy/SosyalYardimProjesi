using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SosyalYardimProjesi
{
    public partial class YardimProjeleriYonetimiForm : Form
    {
        public YardimProjeleriYonetimiForm()
        {
            InitializeComponent();
            PopulateProjeList(); // Proje listesini form yüklendiğinde doldur
            PopulateKategoriComboBox(); // Kategori ComboBox'ını doldur
        }

        private void PopulateProjeList()
        {
            string query = "SELECT ProjeID, ProjeAdi, ProjeAciklama, Kategori FROM Proje";
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
                        lstProjeler.DisplayMember = "ProjeAdi";
                        lstProjeler.ValueMember = "ProjeID";
                        lstProjeler.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanından projeler alınamadı: " + ex.Message);
                }
            }
        }

        private void PopulateKategoriComboBox()
        {
            cmbKategori.Items.Clear(); // ComboBox'ı temizle

            // Kategori seçeneklerini ekleyin
            cmbKategori.Items.Add("Eğitim");
            cmbKategori.Items.Add("Yurtdışı");
            cmbKategori.Items.Add("Sağlık");

            // Başlangıçta boş seçili olsun
            cmbKategori.SelectedIndex = -1;
        }

        private void btnProjeEkle_Click(object sender, EventArgs e)
        {
            string projeAdi = txtProjeAdi.Text;
            string projeAciklama = txtProjeAciklama.Text;
            string kategori = cmbKategori.SelectedItem as string;

            if (string.IsNullOrEmpty(projeAdi) || string.IsNullOrEmpty(projeAciklama) || string.IsNullOrEmpty(kategori))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "INSERT INTO Proje (ProjeAdi, ProjeAciklama, Kategori) VALUES (@ProjeAdi, @ProjeAciklama, @Kategori)";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProjeAdi", projeAdi);
                command.Parameters.AddWithValue("@ProjeAciklama", projeAciklama);
                command.Parameters.AddWithValue("@Kategori", kategori);

                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Proje başarıyla eklendi.");
                        PopulateProjeList(); // Liste güncellensin
                        ClearInputFields();
                    }
                    else
                    {
                        MessageBox.Show("Proje eklenirken bir hata oluştu.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Proje eklenirken bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void btnProjeGuncelle_Click(object sender, EventArgs e)
        {
            if (lstProjeler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen güncellenecek proje seçiniz.");
                return;
            }

            DataRowView selectedRow = lstProjeler.SelectedItem as DataRowView;
            int projeID = Convert.ToInt32(selectedRow["ProjeID"]);
            string projeAdi = txtProjeAdi.Text;
            string projeAciklama = txtProjeAciklama.Text;
            string kategori = cmbKategori.SelectedItem as string;

            if (string.IsNullOrEmpty(projeAdi) || string.IsNullOrEmpty(projeAciklama) || string.IsNullOrEmpty(kategori))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "UPDATE Proje SET ProjeAdi = @ProjeAdi, ProjeAciklama = @ProjeAciklama, Kategori = @Kategori WHERE ProjeID = @ProjeID";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProjeID", projeID);
                command.Parameters.AddWithValue("@ProjeAdi", projeAdi);
                command.Parameters.AddWithValue("@ProjeAciklama", projeAciklama);
                command.Parameters.AddWithValue("@Kategori", kategori);

                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Proje başarıyla güncellendi.");
                        PopulateProjeList(); // Liste güncellensin
                        ClearInputFields();
                    }
                    else
                    {
                        MessageBox.Show("Proje güncellenirken bir hata oluştu.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Proje güncellenirken bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void btnProjeSil_Click(object sender, EventArgs e)
        {
            if (lstProjeler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen silinecek proje seçiniz.");
                return;
            }

            DataRowView selectedRow = lstProjeler.SelectedItem as DataRowView;
            int projeID = Convert.ToInt32(selectedRow["ProjeID"]);

            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "DELETE FROM Proje WHERE ProjeID = @ProjeID";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProjeID", projeID);

                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Proje başarıyla silindi.");
                        PopulateProjeList(); // Liste güncellensin
                    }
                    else
                    {
                        MessageBox.Show("Proje silinirken bir hata oluştu.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Proje silinirken bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void lstProjeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProjeler.SelectedItem != null)
            {
                DataRowView selectedRow = lstProjeler.SelectedItem as DataRowView;
                txtProjeAdi.Text = selectedRow["ProjeAdi"].ToString();
                txtProjeAciklama.Text = selectedRow["ProjeAciklama"].ToString();
                cmbKategori.SelectedItem = selectedRow["Kategori"].ToString();
            }
        }

        private void ClearInputFields()
        {
            txtProjeAdi.Text = "";
            txtProjeAciklama.Text = "";
            cmbKategori.SelectedIndex = -1;
        }
    }
}
