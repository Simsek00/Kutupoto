using Kutupoto.Model;
using System.Data;
using Microsoft.Data.SqlClient;

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

        // Event handler for the Registration button
        private void butKayit_Click(object sender, EventArgs e)
        {
            // Create and show the Registration (Kayit) form
            Kayit kayit = new Kayit();
            kayit.Show();
        }

        // Event handler for the Login button
        private void butGiris_Click(object sender, EventArgs e)
        {
            // Prepare SQL parameters to prevent SQL Injection
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@KullaniciAdi", SqlDbType.NVarChar) { Value = txtKullanici.Text });

            // Fetch the user by username; the salted hash is verified in code
            DataTable dt = IDataBase.DatatoDataTable("select id, Sifre from kullanicilar where KullaniciAdi = @KullaniciAdi", parameters);

            string kayitliHash = dt.Rows.Count > 0 ? dt.Rows[0]["Sifre"].ToString() ?? "" : "";

            if (dt.Rows.Count > 0 && SifreHash.Dogrula(txtSifre.Text, kayitliHash))
            {
                int kullaniciId = Convert.ToInt32(dt.Rows[0]["id"]);
                UserInfo.userId = kullaniciId;

                // Upgrade legacy unsalted SHA-256 hashes to PBKDF2 after a successful login
                if (SifreHash.EskiFormatMi(kayitliHash))
                {
                    List<SqlParameter> guncelle = new List<SqlParameter>();
                    guncelle.Add(new SqlParameter("@Sifre", SqlDbType.NVarChar) { Value = SifreHash.Olustur(txtSifre.Text) });
                    guncelle.Add(new SqlParameter("@id", SqlDbType.Int) { Value = kullaniciId });
                    IDataBase.executeNonQuery("update kullanicilar set Sifre = @Sifre where id = @id", guncelle);
                }

                // Login Successful
                AnaSayfa anaSayfa = new AnaSayfa();
                
                // Hide the login form and open the Main Page as a dialog
                this.Hide();
                anaSayfa.ShowDialog();

                // Clear the input fields for security and usability
                txtKullanici.Text = "";  
                txtSifre.Text = "";     
                txtKullanici.Focus();    

                this.Show(); 
            }
            else
            {
                // Login Failed: Show error message
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!"); 
            }
        }

        // Event handler for the Exit button
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}