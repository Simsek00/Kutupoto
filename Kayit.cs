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

        // Bu fonksiyon gelen şifreyi karmaşık bir yapıya çevirir
        public static string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            // 1. Boş alan kontrolü
            if (string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyad.Text) || string.IsNullOrEmpty(txtKullanici.Text) || string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Tüm alanları doldurunuz.");
                return;
            }

            // 2. Şifreyi Hashle (Güvenli hale getir)
            string guvenliSifre = sha256_hash(txtSifre.Text);

            // 3. Veritabanına kaydet
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@adi", SqlDbType.VarChar) { Value = txtAd.Text });
            parameters.Add(new SqlParameter("@soyadi", SqlDbType.VarChar) { Value = txtSoyad.Text });
            parameters.Add(new SqlParameter("@KullaniciAdi", SqlDbType.VarChar) { Value = txtKullanici.Text });

            // DİKKAT: Buraya txtSifre.Text değil, guvenliSifre değişkenini koyuyoruz
            parameters.Add(new SqlParameter("@Sifre", SqlDbType.VarChar) { Value = guvenliSifre });

            IDataBase.executeNonQuery("insert into kullanicilar (adi, soyadi, KullaniciAdi, Sifre) values (@adi, @soyadi, @KullaniciAdi, @Sifre)", parameters);

            MessageBox.Show("Başarıyla Kayıt Oldunuz.");
            this.Close(); // Kayıttan sonra pencereyi kapat
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
