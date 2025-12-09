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
            kitaplarLoad();
        }
        static int kitapId = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        void kitaplarLoad()
        {
            dg.DataSource = IDataBase.DatatoDataTable("select * from kitaplar where aktif = 1");
            dg.Columns["id"].Visible = false;
        }
        void temizle()
        {
            kitapId = 0;

            foreach (var item in tableLayoutPanel.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }

                if (item is ComboBox)
                {
                    ((ComboBox)item).Text = "";
                }
            }
        }
        void kitapEkle()
        {
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
            parameters.Add(new SqlParameter("@kitapId", SqlDbType.Int) { Value = kitapId });
            IDataBase.executeNonQuery("insert into kitaplar (kayitNo, kitapAdi, yazarAdi, sayfaSayisi, tur, yayinevi, basimYili, dolapNo, rafNo) values (@kayitNo, @kitapAdi, @yazarAdi, @sayfaSayisi, @tur, @yayinevi, @basimYili, @dolapNo, @rafNo)", parameters);
            kitaplarLoad();

            MessageBox.Show("Kitap ekleme işlemi başarılı.");
        }
        void kitapSil()
        {
            IDataBase.executeNonQuery("update kitaplar set aktif = 0 where id = @id", new SqlParameter("@id", SqlDbType.Int) { Value = kitapId });
            kitaplarLoad();

            MessageBox.Show("Kitap silme işlemi başarılı");
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

            IDataBase.executeNonQuery("update kitaplar set  kitapAdi = @kitapAdi, yazarAdi = @yazarAdi, sayfaSayisi = @sayfaSayisi, tur = @tur, yayinevi = @yayinevi, basimYili = @basimYili, dolapNo = @dolapNo, rafNo = @rafNo   where id = @id", parameters);

            kitaplarLoad();

            MessageBox.Show("Kitap güncelleme işlemi başarılı");

        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKitapAdi.Text) ||
               string.IsNullOrEmpty(txtYazar.Text) ||
               string.IsNullOrEmpty(txtTur.Text))
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

                foreach (DataRow row in IDataBase.DatatoDataTable("select * from kitaplar where aktif = 1 and id = @id", new SqlParameter("@id", SqlDbType.Int) { Value = kitapId }).Rows)
                {
                    txtKayitNo.Text = row["kayitNo"].ToString();
                    txtKitapAdi.Text = row["kitapAdi"].ToString();
                    txtYazar.Text = row["yazarAdi"].ToString();
                    txtTur.Text = row["tur"].ToString();
                    txtSayfa.Text = row["sayfaSayisi"].ToString();
                    txtYayinevi.Text = row["yayinevi"].ToString();
                    txtBasimYili.Text = row["basimYili"].ToString();
                    txtDolapNo.Text = row["dolapNo"].ToString();
                    txtRafNo.Text = row["rafNo"].ToString();

                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (kitapId > 0)
            {
                DialogResult dialogResult = MessageBox.Show(
                    "Seçili kitabı silmek istediğinize emin misiniz?", "Kitap Sil", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    kitapSil();
                    temizle();
                }
                else
                {
                    MessageBox.Show("İşlem İptal Edildi!");
                }
            }
            else
            {
                MessageBox.Show("Kitap Seçiniz.");
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
