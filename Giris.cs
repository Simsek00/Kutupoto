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

        // This function converts the incoming password into a secure SHA-256 hash string.
        public static string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                // Compute the hash and convert the byte array to a hexadecimal string
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
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
            // Hash the password entered by the user to match the database format
            string girilenGuvenliSifre = sha256_hash(txtSifre.Text);

            // Prepare SQL parameters to prevent SQL Injection
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@KullaniciAdi", SqlDbType.VarChar) { Value = txtKullanici.Text });
            parameters.Add(new SqlParameter("@Sifre", SqlDbType.VarChar) { Value = girilenGuvenliSifre });

            // Execute the query to check if a user exists with the matching username and hashed password
            DataTable dt = IDataBase.DatatoDataTable("select * from kullanicilar where KullaniciAdi = @KullaniciAdi and Sifre = @Sifre", parameters);

            // Check if any rows were returned (Login Successful)
            if (dt.Rows.Count > 0)
            {
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