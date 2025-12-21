using Kutupoto.Model;
using Microsoft.SqlServer.Server;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace Kutupoto
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        // Bu fonksiyon gelen þifreyi karmaþýk bir yapýya çevirir
        public static string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }

        private void lblBaslik_Click(object sender, EventArgs e)
        {

        }

        private void butKayit_Click(object sender, EventArgs e)
        {
            Kayit kayit = new Kayit();
            kayit.Show();
        }

        private void butGiris_Click(object sender, EventArgs e)
        {
            // Girilen þifreyi hashle
            string girilenGuvenliSifre = sha256_hash(txtSifre.Text);

            // Veritabanýnda bu hashli þifreyi ara
            // NOT: SQL sorgusunda Sifre=@Sifre kýsmýna dikkat
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@KullaniciAdi", SqlDbType.VarChar) { Value = txtKullanici.Text });
            parameters.Add(new SqlParameter("@Sifre", SqlDbType.VarChar) { Value = girilenGuvenliSifre });

            DataTable dt = IDataBase.DatatoDataTable("select * from kullanicilar where KullaniciAdi = @KullaniciAdi and Sifre = @Sifre", parameters);

            if (dt.Rows.Count > 0)
            {
                // Giriþ Baþarýlý
                AnaSayfa anaSayfa = new AnaSayfa();
                this.Hide();
                anaSayfa.ShowDialog();
                this.Show(); // Anasayfa kapanýnca tekrar giriþi göster
            }
            else
            {
                MessageBox.Show("Kullanýcý Adý veya Þifre Hatalý!");
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}