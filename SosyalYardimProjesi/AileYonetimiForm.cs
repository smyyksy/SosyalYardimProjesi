using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SosyalYardimProjesi
{
    public partial class AileYonetimiForm : Form
    {
        public AileYonetimiForm()
        {
            InitializeComponent();
            PopulateAileList(); // List the families when the form loads
        }

        private void PopulateAileList()
        {
            string query = "SELECT AileID, AileAdi FROM Aile";
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
                        lstAileler.DisplayMember = "AileAdi";
                        lstAileler.ValueMember = "AileID";
                        lstAileler.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanından aileler alınamadı: " + ex.Message);
                }
            }
        }

        private void btnAileEkle_Click(object sender, EventArgs e)
        {
            string aileAdi = txtAileAdi.Text;

            if (string.IsNullOrEmpty(aileAdi))
            {
                MessageBox.Show("Lütfen aile adını giriniz.");
                return;
            }

            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "INSERT INTO Aile (AileAdi) VALUES (@AileAdi)";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AileAdi", aileAdi);

                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Aile başarıyla eklendi.");
                        PopulateAileList(); // Refresh the list after adding
                        ClearInputFields();
                    }
                    else
                    {
                        MessageBox.Show("Aile eklenirken bir hata oluştu.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Aile eklenirken bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void btnAileGuncelle_Click(object sender, EventArgs e)
        {
            if (lstAileler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen güncellenecek aileyi seçiniz.");
                return;
            }

            DataRowView selectedRow = lstAileler.SelectedItem as DataRowView;
            int aileID = Convert.ToInt32(selectedRow["AileID"]);
            string aileAdi = txtAileAdi.Text;

            if (string.IsNullOrEmpty(aileAdi))
            {
                MessageBox.Show("Lütfen aile adını giriniz.");
                return;
            }

            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "UPDATE Aile SET AileAdi = @AileAdi WHERE AileID = @AileID";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AileID", aileID);
                command.Parameters.AddWithValue("@AileAdi", aileAdi);

                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Aile başarıyla güncellendi.");
                        PopulateAileList(); // Refresh the list after update
                        ClearInputFields();
                    }
                    else
                    {
                        MessageBox.Show("Aile güncellenirken bir hata oluştu.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Aile güncellenirken bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void btnAileSil_Click(object sender, EventArgs e)
        {
            if (lstAileler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen silinecek aileyi seçiniz.");
                return;
            }

            DataRowView selectedRow = lstAileler.SelectedItem as DataRowView;
            int aileID = Convert.ToInt32(selectedRow["AileID"]);

            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "DELETE FROM Aile WHERE AileID = @AileID";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AileID", aileID);

                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Aile başarıyla silindi.");
                        PopulateAileList(); // Refresh the list after deletion
                    }
                    else
                    {
                        MessageBox.Show("Aile silinirken bir hata oluştu.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Aile silinirken bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void btnBagisGoruntule_Click(object sender, EventArgs e)
        {
            if (lstAileler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bağışlarını görmek istediğiniz aileyi seçiniz.");
                return;
            }

            DataRowView selectedRow = lstAileler.SelectedItem as DataRowView;
            int aileID = Convert.ToInt32(selectedRow["AileID"]);

            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "SELECT YardimTuru, YardimMiktari, KayitTarihi FROM AileBagis WHERE AileID = @AileID";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AileID", aileID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        string bagislar = "Bağışlar:\n";
                        while (reader.Read())
                        {
                            bagislar += $"Tür: {reader["YardimTuru"]}, Miktar: {reader["YardimMiktari"]}, Tarih: {reader["KayitTarihi"]}\n";
                        }
                        MessageBox.Show(bagislar);
                    }
                    else
                    {
                        MessageBox.Show("Bu aileye ait bağış bulunamadı.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bağışlar görüntülenirken bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void lstAileler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAileler.SelectedItem != null)
            {
                DataRowView selectedRow = lstAileler.SelectedItem as DataRowView;
                txtAileAdi.Text = selectedRow["AileAdi"].ToString();
            }
        }

        private void ClearInputFields()
        {
            txtAileAdi.Text = "";
        }
    }
}
