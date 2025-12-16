using Kutupoto.Model;
using Microsoft.SqlServer.Server;
using System.Data;
using System.Data.SqlClient;

namespace Kutupoto
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
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
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@KullaniciAdi", SqlDbType.VarChar) { Value = txtKullanici.Text });
            parameters.Add(new SqlParameter("@Sifre", SqlDbType.VarChar) { Value = txtSifre.Text });

            DataTable dt = IDataBase.DatatoDataTable(
                "select * from kullanicilar where KullaniciAdi = @KullaniciAdi and Sifre = @Sifre", parameters);
            if (dt.Rows.Count > 0)
            {

                AnaSayfa anaSayfa = new AnaSayfa();
                anaSayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanýcý Adý veya Þifre Hatalý Girilmiþtir.");
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}