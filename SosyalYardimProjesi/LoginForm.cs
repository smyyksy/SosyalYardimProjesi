using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SosyalYardimProjesi
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            InitializeForm(); // Form başlatıldığında gerekli ayarları yap
        }

        private void InitializeForm()
        {
            // Kullanıcı Tipi combobox'ına seçenekler ekleyin ve başlangıçta "Kullanıcı" seçili olsun
            cmbKullaniciTipi.Items.AddRange(new object[] { "Admin", "Kullanıcı" });
            cmbKullaniciTipi.SelectedIndex = 1; // "Kullanıcı"yı seçili hale getirin
        }

        // LoginForm içinde btnGiris_Click metodu
        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;
            string kullaniciTipi = cmbKullaniciTipi.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre) || string.IsNullOrEmpty(kullaniciTipi))
            {
                MessageBox.Show("Lütfen kullanıcı adı, şifre ve kullanıcı tipi seçiniz.");
                return;
            }

            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "SELECT KullaniciID, KullaniciTipi FROM Kullanici WHERE KullaniciAdi = @KullaniciAdi AND Sifre = @Sifre";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                command.Parameters.AddWithValue("@Sifre", sifre);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string dbKullaniciTipi = reader["KullaniciTipi"].ToString();

                        if (dbKullaniciTipi == kullaniciTipi)
                        {
                            int kullaniciID = Convert.ToInt32(reader["KullaniciID"]);

                            MessageBox.Show("Giriş başarılı!");

                            if (kullaniciTipi == "Admin")
                            {
                                AdminPanelForm adminPanel = new AdminPanelForm(kullaniciID, kullaniciAdi);
                                this.Hide();
                                adminPanel.ShowDialog();
                            }
                            else if (kullaniciTipi == "Kullanıcı")
                            {
                                AnaSayfaForm anaSayfa = new AnaSayfaForm(kullaniciID, kullaniciAdi);
                                this.Hide();
                                anaSayfa.ShowDialog();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı tipi uyuşmuyor!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Giriş başarısız! Bilgilerinizi kontrol ediniz.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;
            string kullaniciTipi = cmbKullaniciTipi.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre) || string.IsNullOrEmpty(kullaniciTipi))
            {
                MessageBox.Show("Lütfen kullanıcı adı, şifre ve kullanıcı tipi seçiniz.");
                return;
            }

            using (var connection = DatabaseHelper.GetConnection())
            {
                // Kullanıcı adının daha önce kullanılıp kullanılmadığını kontrol et
                string checkQuery = "SELECT COUNT(1) FROM Kullanici WHERE KullaniciAdi = @KullaniciAdi";
                var checkCommand = new SqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);

                try
                {
                    connection.Open();
                    int existingCount = (int)checkCommand.ExecuteScalar();

                    if (existingCount > 0)
                    {
                        MessageBox.Show("Bu kullanıcı adı zaten mevcut. Lütfen başka bir kullanıcı adı seçin.");
                        return;
                    }

                    // Kullanıcı adı mevcut değilse yeni kullanıcı kaydı yap
                    string insertQuery = "INSERT INTO Kullanici (KullaniciAdi, Sifre, KullaniciTipi) VALUES (@KullaniciAdi, @Sifre, @KullaniciTipi)";
                    var insertCommand = new SqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                    insertCommand.Parameters.AddWithValue("@Sifre", sifre);
                    insertCommand.Parameters.AddWithValue("@KullaniciTipi", kullaniciTipi);

                    int result = insertCommand.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Kayıt başarılı!");
                    }
                    else
                    {
                        MessageBox.Show("Kayıt başarısız!");
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
