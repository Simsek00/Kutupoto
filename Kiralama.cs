using Kutupoto.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kutupoto
{
    public partial class Kiralama : Form
    {
        public Kiralama()
        {
            InitializeComponent();
            okuyucularLoad();
            kitaplarLoad();
        }
        int okuyucuId = 0;
        int kitapId = 0;
        int cezaTL = 0;

        private void Kiralama_Load(object sender, EventArgs e)
        {
            okuyucularLoad();
            kitaplarLoad();
        }

        void getOkuyucuProfil()
        {
            lblAdSoyad.Text = "";
            lblSinif.Text = "";
            lblOkulNo.Text = "";
            lblGecikmeBedeli.Text = "";

            foreach (DataRow row in IDataBase.DatatoDataTable("select * from okuyucular where aktif = 1 and id = @id", new SqlParameter("@id", SqlDbType.Int) { Value = okuyucuId }).Rows)
            {
                lblAdSoyad.Text = row["adi"].ToString() + " " + row["soyadi"].ToString();
                lblSinif.Text = row["sinifi"].ToString();
                lblOkulNo.Text = row["okulNo"].ToString();
                lblGecikmeBedeli.Text = "YOK";
                cezaTL = getGecikmeBedeli();
                if (cezaTL > 0)
                {
                    lblGecikmeBedeli.Text = "Gecikme Bedeli " + string.Format("{0:C}", cezaTL);
                    lblGecikmeBedeli.BackColor = Color.Red;
                }
                else
                {
                    lblGecikmeBedeli.Text = "Uygun";
                    lblGecikmeBedeli.BackColor = Color.Transparent;
                }

                // --- DEĞİŞEN KISIM BURASI ---
                kitapId = getEmanetKitapId(); // Artık yeni metodu kullanıyoruz
                                              // ----------------------------

                getKitapProfil();
            }
        }

        void getKitapProfil()
        {
            lblKayitNo.Text = "";
            lblKitapAdi.Text = "";
            lblYazarAdi.Text = "";

            foreach (DataRow row in IDataBase.DatatoDataTable("select * from kitaplar where aktif = 1 and id = @id", new SqlParameter("@id", SqlDbType.Int) { Value = kitapId }).Rows)
            {
                lblKayitNo.Text = row["kayitNo"].ToString();
                lblKitapAdi.Text = row["kitapAdi"].ToString();
                lblYazarAdi.Text = row["yazarAdi"].ToString();
            }
        }

        void okuyucularLoad()
        {
            dgOkuyucular.DataSource = IDataBase.DatatoDataTable("select * from okuyucular where aktif = 1");

        }

        void kitaplarLoad()
        {

            dgKitaplar.DataSource = IDataBase.DatatoDataTable("select * from kitaplar where aktif = 1 and durum = 1");
        }
        void emanetEt()
        {
            if (kitapId == 0 || okuyucuId == 0)
            {
                MessageBox.Show("Kitap veya okuyucu seçmediniz!");
                return;
            }

            if (getEmanetId() > 0)
            {
                MessageBox.Show("Seçili okuyucunun emaneti var!");
                return;
            }


            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@kitapId", SqlDbType.Int) { Value = kitapId });
            parameters.Add(new SqlParameter("@okuyucuId", SqlDbType.Int) { Value = okuyucuId });
            parameters.Add(new SqlParameter("@emanetVerilisTarihi", SqlDbType.Date) { Value = DateTime.Now });
            parameters.Add(new SqlParameter("@emanetGeriAlmaTarihi", SqlDbType.Date) { Value = DateTime.Now.AddDays(30) });

            IDataBase.executeNonQuery(
                "update kitaplar set durum = 0 where id = @kitapId " +
                "insert into emanetler (kitapId, okuyucuId, emanetVerilisTarihi, emanetGeriAlmaTarihi) values (@kitapId, @okuyucuId, @emanetVerilisTarihi, @emanetGeriAlmaTarihi)", parameters);

            kitaplarLoad();
        }

        void sureUzat()
        {
            if (kitapId == 0 || okuyucuId == 0)
            {
                MessageBox.Show("Kitap veya okuyucu seçmediniz!");
                return;
            }

            int currentEmanetId = getEmanetId(); // Artık doğru ID (Primary Key) geliyor.

            if (currentEmanetId == 0)
            {
                MessageBox.Show("HATA: Aktif bir emanet kaydı bulunamadı!");
                return;
            }

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@emanetId", SqlDbType.Int) { Value = currentEmanetId });

            // SQL Tarafında DATEADD ile mevcut tarihin üzerine 30 gün ekliyoruz.
            // WHERE id = @emanetId diyerek doğru satırı güncelliyoruz.
            string sorgu = "UPDATE emanetler SET emanetGeriAlmaTarihi = DATEADD(day, 30, emanetGeriAlmaTarihi) WHERE id = @emanetId";

            IDataBase.executeNonQuery(sorgu, parameters);

            MessageBox.Show("Süre mevcut tarihin üzerine 30 gün daha eklendi.");

            getOkuyucuProfil();
            kitaplarLoad();
        }
        void dusumYap()
        {
            if (kitapId == 0 || okuyucuId == 0)
            {
                MessageBox.Show("Kitap veya okuyucu seçmediniz!");
                return;
            }

            if (getEmanetId() == 0)
            {
                MessageBox.Show("Seçili okuyucunun emaneti yok!");
                return;
            }


            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@kitapId", SqlDbType.Int) { Value = kitapId });
            parameters.Add(new SqlParameter("@emanetIslemTarihi", SqlDbType.Date) { Value = DateTime.Now });

            IDataBase.executeNonQuery(
                "update kitaplar set durum = 1 where id = @kitapId " +
                "update emanetler set emanetIslemTarihi = @emanetIslemTarihi, durum = 1 where kitapId = @kitapId", parameters);

            getOkuyucuProfil();
            kitaplarLoad();
        }
        int getEmanetId()
        {
            // DİKKAT: Burayı row["kitapId"] yerine row["id"] yaptık.
            // Artık bu metod işlemin gerçek kimlik numarasını döndürüyor.
            foreach (DataRow row in IDataBase.DatatoDataTable("select * from emanetler where okuyucuId = @id and durum = 0 and aktif = 1", new SqlParameter("@id", SqlDbType.Int) { Value = okuyucuId }).Rows)
            {
                return Convert.ToInt32(row["id"]);
            }
            return 0;
        }
        int getEmanetKitapId()
        {
            // Bu metod sadece okuyucunun elindeki kitabın ID'sini bulmak için
            foreach (DataRow row in IDataBase.DatatoDataTable("select * from emanetler where okuyucuId = @id and durum = 0 and aktif = 1", new SqlParameter("@id", SqlDbType.Int) { Value = okuyucuId }).Rows)
            {
                return Convert.ToInt32(row["kitapId"]);
            }
            return 0;
        }
        int getGecikmeBedeli()
        {
            int cezaTL = 1;
            int gunFark = 0;
            foreach (DataRow row in IDataBase.DatatoDataTable("select * from emanetler where okuyucuId = @id and durum = 0 and aktif = 1", new SqlParameter("@id", SqlDbType.Int) { Value = okuyucuId }).Rows)
            {
                TimeSpan timeSpan = DateTime.Now - Convert.ToDateTime(row["emanetGeriAlmaTarihi"]);
                gunFark = timeSpan.Days;
            }
            if (gunFark > 0)
            {
                return (gunFark * cezaTL);
            }
            return 0;
        }
        private void dgOkuyucular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                okuyucuId = Convert.ToInt32(dgOkuyucular.Rows[e.RowIndex].Cells["id"].Value);
                getOkuyucuProfil();
            }

        }

        private void dgKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (okuyucuId == 0)
                {
                    MessageBox.Show("Okuyucu seçiniz!");
                    return;
                }

                if (getEmanetId() > 0)
                {
                    MessageBox.Show("Okuyucunun emaneti var!");
                    return;
                }
                kitapId = Convert.ToInt32(dgKitaplar.Rows[e.RowIndex].Cells["id"].Value);
                getKitapProfil();
            }
        }

        private void btnEmanetEt_Click(object sender, EventArgs e)
        {
            emanetEt();
        }

        private void btnSureUzat_Click(object sender, EventArgs e)
        {
            if (cezaTL > 0)
            {
                DialogResult dialogResult = MessageBox.Show(
                    "Okuyucunun " + string.Format("{0:C}", cezaTL) + " gecikme bedeli teslim alındı mı?", "Gecikme Bedeli", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    sureUzat();
                }
            }
            else
            {
                sureUzat();
            }
        }

        private void btnDüsümYap_Click(object sender, EventArgs e)
        {

            if (cezaTL > 0)
            {
                DialogResult dialogResult = MessageBox.Show(
                    "Okuyucunun " + string.Format("{0:C}", cezaTL) + " gecikme bedeli teslim alındı mı?", "Gecikme Bedeli", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    dusumYap();
                }
            }
            else
            {
                dusumYap();
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

