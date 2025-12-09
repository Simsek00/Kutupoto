using Kutupoto.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutupoto
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
            dataGridViewLoad();

        }

        void dataGridViewLoad()
        {
            dgEmanetler.DataSource = IDataBase.DatatoDataTable("select kayitNo as[Kayıt No], kitapAdi as [Kitap Adı], yazarAdi as[Yazar Adı], sayfaSayisi as [ Sayfa Sayısı], tur as [Tür], yayinevi as [Yayınevi], basimYili as [Basım Yılı], dolapNo as [Dolap No], rafNo as [Raf No] from kitaplar where aktif = 1 and durum = 0");
            dgMevcutKitaplar.DataSource = IDataBase.DatatoDataTable("select kayitNo as[Kayıt No], kitapAdi as [Kitap Adı], yazarAdi as[Yazar Adı], sayfaSayisi as [ Sayfa Sayısı], tur as [Tür], yayinevi as [Yayınevi], basimYili as [Basım Yılı], dolapNo as [Dolap No], rafNo as [Raf No] from kitaplar where aktif = 1 and durum = 1");
            dgOkuyucular.DataSource = IDataBase.DatatoDataTable("select adi as [Adı], soyadi as [Soyadı], cinsiyeti as [Cinsiyeti], sinifi as [Sınıfı], okulNo as [Okul No], cepTel as [Telefon No], adres as [Adres] from okuyucular where aktif = 1");
        }
        private void btKitap_Click(object sender, EventArgs e)
        {
            KitapEkle kitapEkle = new KitapEkle();
            kitapEkle.Show();
        }

        private void btOkuyucu_Click(object sender, EventArgs e)
        {
            OkuyucuEkle okuyucuEkle = new OkuyucuEkle();
            okuyucuEkle.Show();
        }

        private void btKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btCikis_Click(object sender, EventArgs e)
        {

        }

        private void btKiralama_Click(object sender, EventArgs e)
        {
            Kiralama kiralama = new Kiralama();
            kiralama.Show();
        }

        private void AnaSayfa_Activated(object sender, EventArgs e)
        {
            dataGridViewLoad();
        }
    }
}
