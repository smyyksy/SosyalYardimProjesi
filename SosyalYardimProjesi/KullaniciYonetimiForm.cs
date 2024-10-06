using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SosyalYardimProjesi
{
    public partial class KullaniciYonetimiForm : Form
    {
        public KullaniciYonetimiForm()
        {
            InitializeComponent();
            PopulateKullaniciList(); // List the users when the form loads
        }

        private void PopulateKullaniciList()
        {
            string query = "SELECT KullaniciID, KullaniciAdi, Sifre FROM Kullanici WHERE KullaniciTipi <> 'Admin'";
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
                        lstKullanicilar.DisplayMember = "KullaniciAdi";
                        lstKullanicilar.ValueMember = "KullaniciID";
                        lstKullanicilar.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanından kullanıcılar alınamadı: " + ex.Message);
                }
            }
        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen kullanıcı adını ve şifresini giriniz.");
                return;
            }

            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "INSERT INTO Kullanici (KullaniciAdi, Sifre, KullaniciTipi) VALUES (@KullaniciAdi, @Sifre, 'Kullanıcı')";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                command.Parameters.AddWithValue("@Sifre", sifre);

                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Kullanıcı başarıyla eklendi.");
                        PopulateKullaniciList(); // Refresh the list after adding
                        ClearInputFields();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı eklenirken bir hata oluştu.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kullanıcı eklenirken bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void btnKullaniciGuncelle_Click(object sender, EventArgs e)
        {
            if (lstKullanicilar.SelectedItem == null)
            {
                MessageBox.Show("Lütfen güncellenecek kullanıcıyı seçiniz.");
                return;
            }

            DataRowView selectedRow = lstKullanicilar.SelectedItem as DataRowView;
            int kullaniciID = Convert.ToInt32(selectedRow["KullaniciID"]);
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen kullanıcı adını ve şifresini giriniz.");
                return;
            }

            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "UPDATE Kullanici SET KullaniciAdi = @KullaniciAdi, Sifre = @Sifre WHERE KullaniciID = @KullaniciID";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@KullaniciID", kullaniciID);
                command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                command.Parameters.AddWithValue("@Sifre", sifre);

                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Kullanıcı başarıyla güncellendi.");
                        PopulateKullaniciList(); // Refresh the list after update
                        ClearInputFields();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı güncellenirken bir hata oluştu.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kullanıcı güncellenirken bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            if (lstKullanicilar.SelectedItem == null)
            {
                MessageBox.Show("Lütfen silinecek kullanıcıyı seçiniz.");
                return;
            }

            DataRowView selectedRow = lstKullanicilar.SelectedItem as DataRowView;
            int kullaniciID = Convert.ToInt32(selectedRow["KullaniciID"]);

            using (var connection = DatabaseHelper.GetConnection())
            {
                string query = "DELETE FROM Kullanici WHERE KullaniciID = @KullaniciID";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@KullaniciID", kullaniciID);

                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Kullanıcı başarıyla silindi.");
                        PopulateKullaniciList(); // Refresh the list after deletion
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı silinirken bir hata oluştu.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kullanıcı silinirken bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void lstKullanicilar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKullanicilar.SelectedItem != null)
            {
                DataRowView selectedRow = lstKullanicilar.SelectedItem as DataRowView;
                txtKullaniciAdi.Text = selectedRow["KullaniciAdi"].ToString();
                txtSifre.Text = selectedRow["Sifre"].ToString();
            }
        }

        private void ClearInputFields()
        {
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
        }
    }
}
