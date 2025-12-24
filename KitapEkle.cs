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

namespace Kutupoto
{
    public partial class KitapEkle : Form
    {
        public KitapEkle()
        {
            InitializeComponent();
        }

        static int kitapId = 0;

        private void KitapEkle_Load(object sender, EventArgs e)
        {
            // 1. GÖRÜNÜM AYARLARI (Tablo Taşıma Sorunu Çözümü)
            panelHeader.Dock = DockStyle.Top;
            panelLeft.Dock = DockStyle.Left;
            dg.Dock = DockStyle.Fill;

            // Sütunları ekrana sığdır (Taşmayı engeller)
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 2. KUTU KİLİTLEME
            txtKayitNo.ReadOnly = true;
            txtKayitNo.BackColor = Color.WhiteSmoke;
            txtKayitNo.ForeColor = Color.Red;
            txtKayitNo.Font = new Font(txtKayitNo.Font, FontStyle.Bold);

            kitaplarLoad();
            temizle();
        }

        void kitaplarLoad()
        {
            dg.DataSource = IDataBase.DatatoDataTable("select * from kitaplar where aktif = 1 ORDER BY kayitNo ASC");
            if (dg.Columns.Contains("id"))
                dg.Columns["id"].Visible = false;
        }

        // SADECE HESAPLAMA YAPAR
        int SiradakiNoGetir()
        {
            string sorgu = "SELECT ISNULL(MAX(kayitNo), 0) FROM kitaplar";
            DataTable dt = IDataBase.DatatoDataTable(sorgu);

            if (dt.Rows.Count > 0)
            {
                int enBuyukNo = Convert.ToInt32(dt.Rows[0][0]);
                return enBuyukNo + 1;
            }
            return 1;
        }

        void temizle()
        {
            kitapId = 0;

            foreach (var item in grpKitapBilgi.Controls)
            {
                if (item is TextBox) ((TextBox)item).Text = "";
                if (item is ComboBox) ((ComboBox)item).Text = "";
            }

            // Sıradaki numarayı hesapla ve KUTUYA YAZ
            txtKayitNo.Text = SiradakiNoGetir().ToString();
            txtKitapAdi.Focus();
        }

        void kitapEkle()
        {
            // Kutudaki numarayı al
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@kayitNo", SqlDbType.Int) { Value = txtKayitNo.Text });
            parameters.Add(new SqlParameter("@kitapAdi", SqlDbType.VarChar) { Value = txtKitapAdi.Text });
            parameters.Add(new SqlParameter("@yazarAdi", SqlDbType.VarChar) { Value = txtYazar.Text });
            parameters.Add(new SqlParameter("@sayfaSayisi", SqlDbType.VarChar) { Value = txtSayfa.Text });
            parameters.Add(new SqlParameter("@tur", SqlDbType.VarChar) { Value = txtTur.Text });
            parameters.Add(new SqlParameter("@yayinevi", SqlDbType.VarChar) { Value = txtYayinevi.Text });
            parameters.Add(new SqlParameter("@basimYili", SqlDbType.VarChar) { Value = txtBasimYili.Text });
            parameters.Add(new SqlParameter("@dolapNo", SqlDbType.VarChar) { Value = txtDolapNo.Text });
            parameters.Add(new SqlParameter("@rafNo", SqlDbType.VarChar) { Value = txtRafNo.Text });

            IDataBase.executeNonQuery("insert into kitaplar (kayitNo, kitapAdi, yazarAdi, sayfaSayisi, tur, yayinevi, basimYili, dolapNo, rafNo) values (@kayitNo, @kitapAdi, @yazarAdi, @sayfaSayisi, @tur, @yayinevi, @basimYili, @dolapNo, @rafNo)", parameters);

            MessageBox.Show("Kitap " + txtKayitNo.Text + " numarasıyla eklendi.");

            kitaplarLoad();
            temizle();
        }

        void kitapGuncelle()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@kitapAdi", SqlDbType.VarChar) { Value = txtKitapAdi.Text });
            parameters.Add(new SqlParameter("@yazarAdi", SqlDbType.VarChar) { Value = txtYazar.Text });
            parameters.Add(new SqlParameter("@sayfaSayisi", SqlDbType.VarChar) { Value = txtSayfa.Text });
            parameters.Add(new SqlParameter("@tur", SqlDbType.VarChar) { Value = txtTur.Text });
            parameters.Add(new SqlParameter("@yayinevi", SqlDbType.VarChar) { Value = txtYayinevi.Text });
            parameters.Add(new SqlParameter("@basimyili", SqlDbType.VarChar) { Value = txtBasimYili.Text });
            parameters.Add(new SqlParameter("@dolapNo", SqlDbType.VarChar) { Value = txtDolapNo.Text });
            parameters.Add(new SqlParameter("@rafNo", SqlDbType.VarChar) { Value = txtRafNo.Text });
            parameters.Add(new SqlParameter("@id", SqlDbType.Int) { Value = kitapId });

            IDataBase.executeNonQuery("update kitaplar set kitapAdi = @kitapAdi, yazarAdi = @yazarAdi, sayfaSayisi = @sayfaSayisi, tur = @tur, yayinevi = @yayinevi, basimYili = @basimYili, dolapNo = @dolapNo, rafNo = @rafNo where id = @id", parameters);

            MessageBox.Show("Kitap güncelleme işlemi başarılı");

            kitaplarLoad();
            temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKitapAdi.Text) || string.IsNullOrEmpty(txtYazar.Text) || string.IsNullOrEmpty(txtTur.Text))
            {
                MessageBox.Show("Kitap Adı, Yazar Adı ve Kitap Türü alanları boş geçilemez");
                return;
            }

            if (kitapId > 0)
            {
                kitapGuncelle();
            }
            else
            {
                kitapEkle();
            }
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                kitapId = Convert.ToInt32(dg.Rows[e.RowIndex].Cells["id"].Value);

                txtKayitNo.Text = dg.Rows[e.RowIndex].Cells["kayitNo"].Value.ToString();
                txtKitapAdi.Text = dg.Rows[e.RowIndex].Cells["kitapAdi"].Value.ToString();
                txtYazar.Text = dg.Rows[e.RowIndex].Cells["yazarAdi"].Value.ToString();
                txtTur.Text = dg.Rows[e.RowIndex].Cells["tur"].Value.ToString();
                txtSayfa.Text = dg.Rows[e.RowIndex].Cells["sayfaSayisi"].Value.ToString();
                txtYayinevi.Text = dg.Rows[e.RowIndex].Cells["yayinevi"].Value.ToString();
                txtBasimYili.Text = dg.Rows[e.RowIndex].Cells["basimYili"].Value.ToString();
                txtDolapNo.Text = dg.Rows[e.RowIndex].Cells["dolapNo"].Value.ToString();
                txtRafNo.Text = dg.Rows[e.RowIndex].Cells["rafNo"].Value.ToString();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (kitapId == 0)
            {
                MessageBox.Show("Silinecek kitabı listeden seçiniz.");
                return;
            }

            DialogResult cevap = MessageBox.Show("Kitabı silmek istediğinize emin misiniz? (Numaralar yeniden sıralanacak)", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cevap == DialogResult.Yes)
            {
                int silinenKayitNo = Convert.ToInt32(txtKayitNo.Text);

                List<SqlParameter> paramSil = new List<SqlParameter>();
                paramSil.Add(new SqlParameter("@id", SqlDbType.Int) { Value = kitapId });
                IDataBase.executeNonQuery("delete from kitaplar where id = @id", paramSil);

                List<SqlParameter> paramUpdate = new List<SqlParameter>();
                paramUpdate.Add(new SqlParameter("@silinenNo", SqlDbType.Int) { Value = silinenKayitNo });
                IDataBase.executeNonQuery("UPDATE kitaplar SET kayitNo = kayitNo - 1 WHERE kayitNo > @silinenNo", paramUpdate);

                MessageBox.Show("Kitap silindi ve liste yeniden numaralandırıldı.");

                temizle();
                kitaplarLoad();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnCikis_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}