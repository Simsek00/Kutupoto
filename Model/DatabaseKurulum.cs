using System;
using System.Collections.Generic;
using System.Data.SqlClient; 
using System.IO;               
using System.Linq;
using System.Text;
using System.Text.RegularExpressions; 
using System.Threading.Tasks;
using System.Windows.Forms;    

namespace Kutupoto.Model
{
    public class DatabaseKurulum
    {

        private string masterConnectionString = "Server=.\\SQLEXPRESS; Database=master; Integrated Security=True; TrustServerCertificate=True;";

        public void VeritabaniKontrolEtVeOlustur()
        {
            // 1. Veritabanı var mı kontrol et
            bool varMi = CheckDatabaseExists();

            // 2. Eğer yoksa oluşturma işlemine başla
            if (!varMi)
            {
                CreateDatabase();
            }
        }

        private bool CheckDatabaseExists()
        {
            string cmdText = "SELECT count(*) FROM master.dbo.sysdatabases WHERE name = 'KOSDb'";

            using (SqlConnection sqlConnection = new SqlConnection(masterConnectionString))
            {
                try
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCmd = new SqlCommand(cmdText, sqlConnection))
                    {
                        int sonuc = (int)sqlCmd.ExecuteScalar();
                        return sonuc > 0; 
                    }
                }
                catch (Exception)
                {

                    return false;
                }
            }
        }

        private void CreateDatabase()
        {

            string scriptPath = Path.Combine(Application.StartupPath, "KOSDB.sql");

          
            if (!File.Exists(scriptPath))
            {
                MessageBox.Show("Veritabanı oluşturma dosyası (KOSDB.sql) bulunamadı!\nLütfen dosyanın 'Copy to Output Directory' ayarını kontrol edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string script = File.ReadAllText(scriptPath);

            string[] commands = Regex.Split(script, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);

            using (SqlConnection conn = new SqlConnection(masterConnectionString))
            {
                try
                {
                    conn.Open();
                    foreach (string command in commands)
                    {
                        if (string.IsNullOrWhiteSpace(command)) continue;

                        using (SqlCommand cmd = new SqlCommand(command, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Veritabanı ve Tablolar Başarıyla Oluşturuldu!\nVarsayılan Kullanıcı: admin / 1234", "Kurulum Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı oluşturulurken hata oluştu!\nBilgisayarınızda SQL Server Express yüklü olduğundan emin olun.\n\nHata Detayı: " + ex.Message, "Kritik Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}