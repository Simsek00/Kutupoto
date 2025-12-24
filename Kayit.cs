using Kutupoto.Model;
using System.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutupoto
{
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }

        // Helper function to hash the password using SHA-256 algorithm
        public static string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                // Compute hash and convert byte array to hex string
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            // 1. Validate that no fields are left empty
            if (string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyad.Text) || string.IsNullOrEmpty(txtKullanici.Text) || string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string girilenSifre = txtSifre.Text;

            // Rule 1: Must be at least 6 characters long
            if (girilenSifre.Length < 6)
            {
                MessageBox.Show("Şifre en az 6 karakter uzunluğunda olmalıdır.", "Şifre Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Rule 2: Must contain at least one UPPERCASE letter
            if (!girilenSifre.Any(char.IsUpper))
            {
                MessageBox.Show("Şifre en az 1 büyük harf içermelidir.", "Şifre Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Rule 3: Must contain at least one lowercase letter
            if (!girilenSifre.Any(char.IsLower))
            {
                MessageBox.Show("Şifre en az 1 küçük harf içermelidir.", "Şifre Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Rule 4: Must NOT contain special characters (Only letters and digits allowed)
            if (!girilenSifre.All(char.IsLetterOrDigit))
            {
                MessageBox.Show("Şifre özel karakter (nokta, virgül, @, vb.) içeremez. Sadece harf ve rakam kullanınız.", "Şifre Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // 2. Hash the password for security
            string guvenliSifre = sha256_hash(girilenSifre);

            // 3. Save to database
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@adi", SqlDbType.VarChar) { Value = txtAd.Text });
                parameters.Add(new SqlParameter("@soyadi", SqlDbType.VarChar) { Value = txtSoyad.Text });
                parameters.Add(new SqlParameter("@KullaniciAdi", SqlDbType.VarChar) { Value = txtKullanici.Text });  
                parameters.Add(new SqlParameter("@Sifre", SqlDbType.VarChar) { Value = guvenliSifre });

                // Execute the insert query
                IDataBase.executeNonQuery("insert into kullanicilar (adi, soyadi, KullaniciAdi, Sifre) values (@adi, @soyadi, @KullaniciAdi, @Sifre)", parameters);

                MessageBox.Show("Başarıyla Kayıt Oldunuz. Giriş ekranına yönlendiriliyorsunuz.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Close the registration form after successful registration
                this.Close(); 
            }
            catch (Exception ex)
            {
                // Handle database errors
                MessageBox.Show("Kayıt sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}