using Kutupoto.Model;
using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Kutupoto
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            // Formlardaki beklenmeyen hatalar (ör. SQL Server kapalı, alan sınırı aşıldı) uygulamayı kapatmak yerine mesajla gösterilir.
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += (sender, e) => HataGoster(e.Exception);
            AppDomain.CurrentDomain.UnhandledException += (sender, e) => HataGoster(e.ExceptionObject as Exception);

            ApplicationConfiguration.Initialize();


            DatabaseKurulum kurulum = new DatabaseKurulum();
            kurulum.VeritabaniKontrolEtVeOlustur();

            Application.Run(new Giris());
        }

        static void HataGoster(Exception? ex)
        {
            string mesaj = ex is SqlException
                ? "Veritabanı işlemi sırasında bir hata oluştu.\nSQL Server'ın çalıştığından ve bağlantı ayarlarının doğru olduğundan emin olun."
                : "Beklenmeyen bir hata oluştu.";

            MessageBox.Show(mesaj + "\n\nHata Detayı: " + ex?.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
