using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SosyalYardimProjesi
{
    public partial class BagisForm : Form
    {
        public BagisForm()
        {
            InitializeComponent();
            LoadEntities(); // Kurumları ve aileleri form yüklenirken listele
        }

        private void LoadEntities()
        {
            // Veritabanından kurumları yükleme işlemi
            using (var connection = DatabaseHelper.GetConnection())
            {
                // Kurumları yükle
                string queryKurum = "SELECT * FROM Kurum";
                var adapterKurum = new SqlDataAdapter(queryKurum, connection);
                var dataSetKurum = new DataSet();
                adapterKurum.Fill(dataSetKurum, "Kurum");

                cmbKurumlar.DataSource = dataSetKurum.Tables["Kurum"];
                cmbKurumlar.DisplayMember = "KurumAdi";
                cmbKurumlar.ValueMember = "KurumID";
                cmbKurumlar.SelectedIndex = -1; // Başlangıçta boş olması için
            }

            // Aileleri veritabanından yükle
            using (var connection = DatabaseHelper.GetConnection())
            {
                string queryAile = "SELECT AileID, AileAdi FROM Aile";
                var adapterAile = new SqlDataAdapter(queryAile, connection);
                var dataSetAile = new DataSet();
                adapterAile.Fill(dataSetAile, "Aile");

                cmbAileler.DataSource = dataSetAile.Tables["Aile"];
                cmbAileler.DisplayMember = "AileAdi";
                cmbAileler.ValueMember = "AileID";
                cmbAileler.SelectedIndex = -1; // Başlangıçta boş olması için
            }
        }

        private void btnBagisYap_Click(object sender, EventArgs e)
        {
            // Aile bağışı yaparken kullanılacak bağlantı nesnesi
            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "";

                if (cmbKurumlar.SelectedIndex != -1)
                {
                    // Kurum seçildiyse kuruma bağış yap
                    int kurumID = (int)cmbKurumlar.SelectedValue;
                    string yardimMiktari = txtYardimMiktari.Text; // TextBox'tan alınan miktar

                    // Seçilen kurumun adını almak için sorgu
                    string kurumAdiQuery = "SELECT KurumAdi FROM Kurum WHERE KurumID = @KurumID";
                    var kurumAdiCommand = new SqlCommand(kurumAdiQuery, connection);
                    kurumAdiCommand.Parameters.AddWithValue("@KurumID", kurumID);

                    connection.Open(); // Bağlantıyı aç

                    string kurumAdi = kurumAdiCommand.ExecuteScalar() as string;

                    query = "INSERT INTO Bagis (KurumID, KurumAdi, YardimMiktari, KayitTarihi) " +
                            "VALUES (@KurumID, @KurumAdi, @YardimMiktari, @KayitTarihi)";
                    var command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@KurumID", kurumID);
                    command.Parameters.AddWithValue("@KurumAdi", kurumAdi); // Kurum adı parametre olarak ekleniyor
                    command.Parameters.AddWithValue("@YardimMiktari", yardimMiktari); // String olarak parametre ekleniyor
                    command.Parameters.AddWithValue("@KayitTarihi", DateTime.Now);

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Kuruma bağış yapıldı!");
                    }
                    else
                    {
                        MessageBox.Show("Kuruma bağış yapılırken bir hata oluştu!");
                    }

                    connection.Close(); // Bağlantıyı kapat
                }
                else if (cmbAileler.SelectedIndex != -1 && cmbYardimTuru.SelectedIndex != -1 && cmbYardimMiktari.SelectedIndex != -1)
                {
                    // Aile ve yardım türü seçildiyse aileye bağış yap
                    int secilenID = (int)cmbAileler.SelectedValue;
                    string yardimTuru = cmbYardimTuru.SelectedItem.ToString();
                    string yardimMiktari = cmbYardimMiktari.SelectedItem.ToString();

                    query = "INSERT INTO AileBagis (AileID, YardimTuru, YardimMiktari, KayitTarihi) " +
                            "VALUES (@AileID, @YardimTuru, @YardimMiktari, @KayitTarihi)";
                    var command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@AileID", secilenID);
                    command.Parameters.AddWithValue("@YardimTuru", yardimTuru);
                    command.Parameters.AddWithValue("@YardimMiktari", yardimMiktari); // String olarak parametre ekleniyor
                    command.Parameters.AddWithValue("@KayitTarihi", DateTime.Now);

                    // Aynı aileye ve yardım türüne sahip bağış yapılıp yapılmadığını kontrol et
                    string checkQuery = "SELECT COUNT(*) FROM AileBagis " +
                                        "WHERE AileID = @AileID AND YardimTuru = @YardimTuru";
                    var checkCommand = new SqlCommand(checkQuery, connection);
                    checkCommand.Parameters.AddWithValue("@AileID", secilenID);
                    checkCommand.Parameters.AddWithValue("@YardimTuru", yardimTuru);

                    connection.Open(); // Bağlantıyı aç

                    int existingCount = (int)checkCommand.ExecuteScalar();

                    if (existingCount > 0)
                    {
                        MessageBox.Show("Bu aileye zaten bu yardım türünde bağış yapılmış!");
                    }
                    else
                    {
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Aileye bağış yapıldı!");
                        }
                        else
                        {
                            MessageBox.Show("Aileye bağış yapılırken bir hata oluştu!");
                        }
                    }

                    connection.Close(); // Bağlantıyı kapat
                }
                else
                {
                    MessageBox.Show("Lütfen kurum veya aile seçiniz!");
                }
            }
        }



        private void cmbYardimTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbYardimTuru.SelectedItem != null)
            {
                string secilenYardimTuru = cmbYardimTuru.SelectedItem as string;

                if (!string.IsNullOrEmpty(secilenYardimTuru))
                {
                    // Burada secilenYardimTuru'ne göre cmbYardimMiktari combo box'ını güncelleyebiliriz
                    cmbYardimMiktari.Items.Clear();

                    if (secilenYardimTuru == "Un" || secilenYardimTuru == "Bakliyat")
                    {
                        cmbYardimMiktari.Items.AddRange(new object[] { "1 Ay", "2 Ay" });
                    }
                    else if (secilenYardimTuru == "Fatura Yardımı")
                    {
                        cmbYardimMiktari.Items.AddRange(new object[] { "Elektrik", "Su", "Doğal Gaz" });
                    }
                    else
                    {
                        // Diğer durumlar için gerekli işlemler
                    }
                }
            }
        }
    }
}
