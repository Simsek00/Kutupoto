using Kutupoto.Model;
using System.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq; // Bu kütüphane harf kontrolleri için gerekli
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

        // Şifre Hashleme Fonksiyonu (Aynen korundu)
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
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string girilenSifre = txtSifre.Text;

            // --- YENİ EKLENEN ŞİFRE KONTROLLERİ ---

            // Kural 1: En az 6 karakter uzunluğunda olmalı
            if (girilenSifre.Length < 6)
            {
                MessageBox.Show("Şifre en az 6 karakter uzunluğunda olmalıdır.", "Şifre Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kural 2: En az 1 tane BÜYÜK harf içermeli
            if (!girilenSifre.Any(char.IsUpper))
            {
                MessageBox.Show("Şifre en az 1 büyük harf içermelidir.", "Şifre Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kural 3: En az 1 tane küçük harf içermeli
            if (!girilenSifre.Any(char.IsLower))
            {
                MessageBox.Show("Şifre en az 1 küçük harf içermelidir.", "Şifre Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kural 4: Özel karakter İÇERMEMELİ (Sadece harf ve rakam olabilir)
            // char.IsLetterOrDigit fonksiyonu sadece harf ve rakama izin verir.
            // Eğer şifrede harf veya rakam dışında bir şey varsa (All fonksiyonu false döner) hata veririz.
            if (!girilenSifre.All(char.IsLetterOrDigit))
            {
                MessageBox.Show("Şifre özel karakter (nokta, virgül, @, vb.) içeremez. Sadece harf ve rakam kullanınız.", "Şifre Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- KONTROLLER BİTTİ ---


            // 2. Şifreyi Hashle (Güvenli hale getir)
            string guvenliSifre = sha256_hash(girilenSifre);

            // 3. Veritabanına kaydet
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@adi", SqlDbType.VarChar) { Value = txtAd.Text });
                parameters.Add(new SqlParameter("@soyadi", SqlDbType.VarChar) { Value = txtSoyad.Text });
                parameters.Add(new SqlParameter("@KullaniciAdi", SqlDbType.VarChar) { Value = txtKullanici.Text });
                
                // Hashlenmiş şifre uzun olduğu için veritabanında Sifre kolonunu VARCHAR(64) veya üzeri yapman gerekir.
                parameters.Add(new SqlParameter("@Sifre", SqlDbType.VarChar) { Value = guvenliSifre });

                IDataBase.executeNonQuery("insert into kullanicilar (adi, soyadi, KullaniciAdi, Sifre) values (@adi, @soyadi, @KullaniciAdi, @Sifre)", parameters);

                MessageBox.Show("Başarıyla Kayıt Oldunuz. Giriş ekranına yönlendiriliyorsunuz.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Kayıttan sonra pencereyi kapat
            }
            catch (Exception ex)
            {
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