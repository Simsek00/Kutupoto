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
        }

        // FİLTRELEME İÇİN VERİYİ BURADA TUTACAĞIZ
        DataTable dtKitaplar;

        // SAYFA YÜKLENDİĞİNDE VEYA AKTİF OLDUĞUNDA ÇALIŞIR
        private void AnaSayfa_Activated(object sender, EventArgs e)
        {
            emanetLoad();
            kitapLoad();
            okuyucuLoad();
        }

        // 1. KİRALANAN KİTAPLARI YÜKLE
        void emanetLoad()
        {
            string sorgu = @"
                select 
                    emanetler.id, 
                    kitaplar.kitapAdi as 'Kitap Adı', 
                    (okuyucular.adi + ' ' + okuyucular.soyadi) as 'Okuyucu', 
                    emanetVerilisTarihi as 'Veriliş Tarihi', 
                    emanetGeriAlmaTarihi as 'Geri Alınacak Tarih' 
                from emanetler 
                join kitaplar on emanetler.kitapId = kitaplar.id 
                join okuyucular on emanetler.okuyucuId = okuyucular.id 
                where emanetler.aktif = 1 and emanetler.durum = 0";

            dgEmanetler.DataSource = IDataBase.DatatoDataTable(sorgu);

            if (dgEmanetler.Columns.Contains("id"))
                dgEmanetler.Columns["id"].Visible = false;
        }

        // 2. MEVCUT KİTAPLARI YÜKLE (VE FİLTREYİ HAZIRLA)
        void kitapLoad()
        {
            // Veriyi çekip global değişkenimize (dtKitaplar) atıyoruz
            dtKitaplar = IDataBase.DatatoDataTable("select * from kitaplar where aktif = 1 and durum = 1");
            dgMevcutKitaplar.DataSource = dtKitaplar;

            if (dgMevcutKitaplar.Columns.Contains("id"))
                dgMevcutKitaplar.Columns["id"].Visible = false;

            // Tür Filtresini (ComboBox) Doldurma İşlemi
            // Eğer ComboBox boşsa doldur (Sürekli tekrar doldurmasın)
            if (cmbTurFiltre.Items.Count <= 1)
            {
                cmbTurFiltre.Items.Clear();
                cmbTurFiltre.Items.Add("Tümü");

                foreach (DataRow row in dtKitaplar.Rows)
                {
                    string tur = row["tur"].ToString();
                    // Boş değilse ve daha önce eklenmemişse ekle
                    if (!string.IsNullOrEmpty(tur) && !cmbTurFiltre.Items.Contains(tur))
                    {
                        cmbTurFiltre.Items.Add(tur);
                    }
                }
                cmbTurFiltre.SelectedIndex = 0; // Varsayılan "Tümü"
            }
        }

        // 3. OKUYUCULARI YÜKLE
        void okuyucuLoad()
        {
            dgOkuyucular.DataSource = IDataBase.DatatoDataTable("select * from okuyucular where aktif = 1");

            if (dgOkuyucular.Columns.Contains("id"))
                dgOkuyucular.Columns["id"].Visible = false;
        }

        // FİLTRELEME MANTIĞI
        void ListeyiFiltrele()
        {
            if (dtKitaplar == null) return;

            // Tek tırnak (') karakteri SQL sorgularını patlatır, onu temizliyoruz
            string aramaMetni = txtKitapAra.Text.Trim().Replace("'", "''");

            string secilenTur = "";
            if (cmbTurFiltre.SelectedItem != null)
                secilenTur = cmbTurFiltre.SelectedItem.ToString();

            string filtre = "";

            // ARAMA FİLTRESİ
            if (!string.IsNullOrEmpty(aramaMetni))
            {
                // DİKKAT: 'kayitNo' sayı olduğu için direkt LIKE kullanamayız.
                // Önce 'Convert' ile yazıya çevirip sonra arama yapıyoruz.
                // Eski hatalı kod: "kayitNo LIKE..." kısmını kaldırdık.
                filtre += string.Format("(kitapAdi LIKE '%{0}%' OR yazarAdi LIKE '%{0}%' OR Convert(kayitNo, 'System.String') LIKE '%{0}%')", aramaMetni);
            }

            // TÜR FİLTRESİ
            if (secilenTur != "Tümü" && !string.IsNullOrEmpty(secilenTur))
            {
                if (filtre.Length > 0) filtre += " AND ";
                filtre += string.Format("tur = '{0}'", secilenTur);
            }

            // FİLTREYİ UYGULA
            try
            {
                DataView dv = dtKitaplar.DefaultView;
                dv.RowFilter = filtre;
                dgMevcutKitaplar.DataSource = dv;
            }
            catch (Exception ex)
            {
                // Eğer çok hızlı yazarken geçici bir hata olursa program çökmesin
                System.Diagnostics.Debug.WriteLine("Filtre hatası: " + ex.Message);
            }
        }

        // TEXTBOX DEĞİŞİNCE
        private void txtKitapAra_TextChanged(object sender, EventArgs e)
        {
            ListeyiFiltrele();
        }

        // COMBOBOX DEĞİŞİNCE
        private void cmbTurFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListeyiFiltrele();
        }

        // BUTON YÖNLENDİRMELERİ
        private void btKiralama_Click(object sender, EventArgs e)
        {
            Kiralama form = new Kiralama();
            form.ShowDialog();
        }

        private void btOkuyucu_Click(object sender, EventArgs e)
        {
            OkuyucuEkle form = new OkuyucuEkle();
            form.ShowDialog();
        }

        private void btKitap_Click(object sender, EventArgs e)
        {
            KitapEkle form = new KitapEkle();
            form.ShowDialog();
        }

        private void btKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}