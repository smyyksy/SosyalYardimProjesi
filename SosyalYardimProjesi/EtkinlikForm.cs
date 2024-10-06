using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SosyalYardimProjesi
{
    public partial class EtkinlikForm : Form
    {

        private int kullaniciID; // Oturum açmış kullanıcının ID'si
        private string kullaniciAdi;

        public EtkinlikForm(int kullaniciID, string kullaniciAdi)
        {
            InitializeComponent();
            this.kullaniciID = kullaniciID;
            this.kullaniciAdi = kullaniciAdi; // Kullanıcı adını saklayalım
            ListeleEtkinlikler(); // Etkinlikleri listeleme metodu çağrılıyor
        }

        private void ListeleEtkinlikler()
        {
            // Veritabanından etkinlikleri çekerek listeleyelim
            string query = "SELECT EtkinlikID, EtkinlikAdi, EtkinlikAciklama, EtkinlikTuru FROM Etkinlikler";

            // SqlConnection ve SqlCommand kullanarak veritabanı bağlantısı yapılabilir
            // Örnek olarak DataGridView kullanalım
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // KullaniciAdi sütununu ekleyelim ve değerleri güncelleyelim
                dt.Columns.Add("KullaniciAdi", typeof(string)); // KullaniciAdi sütunu ekleniyor

                // DataGridView'e etkinlikleri ekleme
                dataGridViewEtkinlikler.DataSource = dt;

                // DataGridView'de sadece istenilen sütunların gösterilmesi
                dataGridViewEtkinlikler.Columns["EtkinlikID"].Visible = false; // EtkinlikID sütunu gizlenir
                dataGridViewEtkinlikler.Columns["EtkinlikAdi"].HeaderText = "Etkinlik Adı";
                dataGridViewEtkinlikler.Columns["EtkinlikAciklama"].HeaderText = "Açıklama";
                dataGridViewEtkinlikler.Columns["EtkinlikTuru"].HeaderText = "Türü";
                dataGridViewEtkinlikler.Columns["KullaniciAdi"].Visible = false; // KullaniciAdi sütunu gizlenir

                // Katıl butonunu ekleyelim
                DataGridViewButtonColumn btnKatilColumn = new DataGridViewButtonColumn();
                btnKatilColumn.HeaderText = "Katıl";
                btnKatilColumn.Text = "Katıl";
                btnKatilColumn.UseColumnTextForButtonValue = true;
                dataGridViewEtkinlikler.Columns.Add(btnKatilColumn);

                // DataGridView'e buton eklendikten sonra her satır için kullanıcı adını güncelleyelim
                foreach (DataGridViewRow row in dataGridViewEtkinlikler.Rows)
                {
                    row.Cells["KullaniciAdi"].Value = kullaniciAdi;
                }
            }
        }

        private void BasvuruYap(int etkinlikID, string etkinlikAdi)
        {
            // Örnek olarak EtkinlikBasvurulari tablosuna başvuru eklemek
            string checkQuery = "SELECT COUNT(1) FROM EtkinlikBasvurulari WHERE EtkinlikID = @EtkinlikID AND KullaniciID = @KullaniciID";
            string insertQuery = "INSERT INTO EtkinlikBasvurulari (EtkinlikID, KullaniciID, KullaniciAdi) VALUES (@EtkinlikID, @KullaniciID, @KullaniciAdi)";

            using (SqlConnection connection = DatabaseHelper.GetConnection())
            {
                // Başvuru yapılmış mı kontrol et
                SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("@EtkinlikID", etkinlikID);
                checkCommand.Parameters.AddWithValue("@KullaniciID", kullaniciID);

                // Başvuru yap
                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                insertCommand.Parameters.AddWithValue("@EtkinlikID", etkinlikID);
                insertCommand.Parameters.AddWithValue("@KullaniciID", kullaniciID);
                insertCommand.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);

                try
                {
                    connection.Open();
                    int existingCount = (int)checkCommand.ExecuteScalar();

                    if (existingCount > 0)
                    {
                        MessageBox.Show("Bu etkinliğe zaten başvurdunuz!");
                    }
                    else
                    {
                        int rowsAffected = insertCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"'{etkinlikAdi}' etkinliğine başvuru yapıldı.");
                        }
                        else
                        {
                            MessageBox.Show("Başvuru sırasında bir hata oluştu.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }



        private void dataGridViewEtkinlikler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Katıl butonuna tıklanırsa işlem yapılabilir
            if (dataGridViewEtkinlikler.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int etkinlikID = (int)dataGridViewEtkinlikler.Rows[e.RowIndex].Cells["EtkinlikID"].Value;
                string etkinlikAdi = dataGridViewEtkinlikler.Rows[e.RowIndex].Cells["EtkinlikAdi"].Value.ToString();

                // Başvuru işlemi yapılabilir, örneğin EtkinlikBasvurulari tablosuna kayıt eklenebilir
                BasvuruYap(etkinlikID, etkinlikAdi);
            }
        }

        

    }
}
