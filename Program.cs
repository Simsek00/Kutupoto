using Kutupoto.Model; 
using System;
using System.Windows.Forms;

namespace Kutupoto
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();


            DatabaseKurulum kurulum = new DatabaseKurulum();
            kurulum.VeritabaniKontrolEtVeOlustur();

            Application.Run(new Giris());
        }
    }
}