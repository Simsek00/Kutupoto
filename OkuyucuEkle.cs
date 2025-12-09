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
using TextBox = System.Windows.Forms.TextBox;

namespace Kutupoto
{
    public partial class OkuyucuEkle : Form
    {
        public OkuyucuEkle()
        {
            InitializeComponent();
            okuyucularLoad();
        }
        int okuyucuId = 0;
        void okuyucuEkle()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@adi", SqlDbType.VarChar) { Value = txtAd.Text });
            parameters.Add(new SqlParameter("@soyadi", SqlDbType.VarChar) { Value = txtSoyad.Text });
            string cinsiyet = "";
            if (radiobtnErkek.Checked)
            {
                cinsiyet = radiobtnErkek.Text;
            }
            else if (radioBtnKadin.Checked)
            {
                cinsiyet = radioBtnKadin.Text;
            }
            parameters.Add(new SqlParameter("@cinsiyeti", SqlDbType.VarChar) { Value = cinsiyet });
            parameters.Add(new SqlParameter("@sinifi", SqlDbType.VarChar) { Value = txtSinif.Text });
            parameters.Add(new SqlParameter("@OkulNo", SqlDbType.VarChar) { Value = txtOkulNo.Text });
            parameters.Add(new SqlParameter("@cepTel", SqlDbType.VarChar) { Value = maskedCepTel.Text });
            parameters.Add(new SqlParameter("@adres", SqlDbType.VarChar) { Value = txtAdres.Text });

            object value = IDataBase.executeScalar("insert into okuyucular (adi, soyadi, cinsiyeti, sinifi, okulNo, cepTel, adres) values (@adi, @soyadi, @cinsiyeti, @sinifi, @okulNo, @cepTel, @adres) select @@IDENTITY", parameters);
            okuyucuId = Convert.ToInt32(value);
            okuyucularLoad();

            MessageBox.Show("Okuyucu ekleme işlemi başarılı");
        }
        void okuyucuGuncelle()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@adi", SqlDbType.VarChar) { Value = txtAd.Text });
            parameters.Add(new SqlParameter("@soyadi", SqlDbType.VarChar) { Value = txtSoyad.Text });
            string cinsiyet = "";
            if (radiobtnErkek.Checked)
            {
                cinsiyet = radiobtnErkek.Text;
            }
            else if (radioBtnKadin.Checked)
            {
                cinsiyet = radioBtnKadin.Text;
            }
            parameters.Add(new SqlParameter("@cinsiyeti", SqlDbType.VarChar) { Value = cinsiyet });
            parameters.Add(new SqlParameter("@sinifi", SqlDbType.VarChar) { Value = txtSinif.Text });
            parameters.Add(new SqlParameter("@OkulNo", SqlDbType.VarChar) { Value = txtOkulNo.Text });
            parameters.Add(new SqlParameter("@cepTel", SqlDbType.VarChar) { Value = maskedCepTel.Text });
            parameters.Add(new SqlParameter("@adres", SqlDbType.VarChar) { Value = txtAdres.Text });
            parameters.Add(new SqlParameter("@id", SqlDbType.Int) { Value = okuyucuId });

            IDataBase.executeNonQuery("update okuyucular set adi = @adi, soyadi = @soyadi, cinsiyeti = @cinsiyeti, sinifi = @sinifi, okulNo = @okulNo, cepTel = @cepTel, adres = @adres where id = @id", parameters);


            okuyucularLoad();
            MessageBox.Show("Okuyucu güncelleme işlemi başarılı");
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        void okuyucularLoad()
        {
            dg.DataSource = IDataBase.DatatoDataTable("select * from okuyucular where aktif = 1");
            dg.Columns["id"].Visible = false;
        }
        void okuyucuSil()
        {
            IDataBase.executeNonQuery("update okuyucular set aktif = 0 where id = @id", new SqlParameter("@id", SqlDbType.Int) { Value = okuyucuId });
            temizle();
            okuyucularLoad();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyad.Text) || maskedCepTel.MaskFull == false)
            {
                MessageBox.Show("Adı, Soyadı ve Cep Telefonu alanları boş geçilemez!");
                return;
            }

            if (okuyucuId > 0)
            {
                okuyucuGuncelle();
            }
            else
            {
                okuyucuEkle();
            }
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                okuyucuId = Convert.ToInt32(dg.Rows[e.RowIndex].Cells["id"].Value);

                radiobtnErkek.Checked = false;
                radioBtnKadin.Checked = true;

                foreach (DataRow row in IDataBase.DatatoDataTable("select * from okuyucular where aktif = 1 and id = @id", new SqlParameter("@id", SqlDbType.Int) { Value = okuyucuId }).Rows)
                {
                    txtAd.Text = row["adi"].ToString();
                    txtSoyad.Text = row["soyadi"].ToString();
                    string cinsiyet = row["cinsiyeti"].ToString();
                    if (cinsiyet == radiobtnErkek.Text)
                    {
                        radiobtnErkek.Checked = true;
                    }
                    else if (cinsiyet == radioBtnKadin.Text)
                    {
                        radioBtnKadin.Checked = true;
                    }
                    txtSinif.Text = row["sinifi"].ToString();
                    txtOkulNo.Text = row["okulNo"].ToString();
                    maskedCepTel.Text = row["cepTel"].ToString();
                    txtAdres.Text = row["adres"].ToString();
                }

            }
        }
        void temizle()
        {
            okuyucuId = 0;


            radiobtnErkek.Checked = false;
            radioBtnKadin.Checked = false;

            foreach (var item in tableLayoutPanel1.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }

                if (item is MaskedTextBox)
                {
                    ((MaskedTextBox)item).Text = "";
                }
            }
        }
        private void btSil_Click(object sender, EventArgs e)
        {
            if (okuyucuId > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Seçili okuyucuyu silmek istediğinize emin misiniz?", "Okuyucu Sil", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    okuyucuSil();
                }
                else
                {
                    MessageBox.Show("İşlem iptal edildi");
                }
            }
            else
            {
                MessageBox.Show("Okuyucu Seçiniz");
            }
        }

        private void btTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
