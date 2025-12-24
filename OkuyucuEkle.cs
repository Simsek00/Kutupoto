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
            // Load the list of readers when the form opens
            okuyucularLoad();
        }

        // Variable to track if we are editing an existing user (ID > 0) or creating a new one (ID = 0)
        int okuyucuId = 0;

        // Function to INSERT a new reader into the database
        void okuyucuEkle()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@adi", SqlDbType.VarChar) { Value = txtAd.Text });
            parameters.Add(new SqlParameter("@soyadi", SqlDbType.VarChar) { Value = txtSoyad.Text });

            // Determine gender based on radio button selection
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

            // Add other parameters
            parameters.Add(new SqlParameter("@sinifi", SqlDbType.VarChar) { Value = txtSinif.Text });
            parameters.Add(new SqlParameter("@OkulNo", SqlDbType.VarChar) { Value = txtOkulNo.Text });
            parameters.Add(new SqlParameter("@cepTel", SqlDbType.VarChar) { Value = maskedCepTel.Text });
            parameters.Add(new SqlParameter("@adres", SqlDbType.VarChar) { Value = txtAdres.Text });

            // Execute INSERT query and retrieve the newly created ID using @@IDENTITY
            object value = IDataBase.executeScalar("insert into okuyucular (adi, soyadi, cinsiyeti, sinifi, okulNo, cepTel, adres) values (@adi, @soyadi, @cinsiyeti, @sinifi, @okulNo, @cepTel, @adres) select @@IDENTITY", parameters);
            
            // Update the local ID variable with the new ID from database
            okuyucuId = Convert.ToInt32(value);
            
            // Refresh the grid to show the new user
            okuyucularLoad();

            MessageBox.Show("Okuyucu ekleme işlemi başarılı"); // "Reader added successfully"
        }

        // Function to UPDATE an existing reader in the database
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
            
            // The ID parameter is crucial for the WHERE clause in the UPDATE statement
            parameters.Add(new SqlParameter("@id", SqlDbType.Int) { Value = okuyucuId });

            // Execute UPDATE query
            IDataBase.executeNonQuery("update okuyucular set adi = @adi, soyadi = @soyadi, cinsiyeti = @cinsiyeti, sinifi = @sinifi, okulNo = @okulNo, cepTel = @cepTel, adres = @adres where id = @id", parameters);

            // Refresh the grid
            okuyucularLoad();
            MessageBox.Show("Okuyucu güncelleme işlemi başarılı"); // "Reader updated successfully"
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        // Function to fetch data and bind it to the DataGridView
        void okuyucularLoad()
        {
            // Only select active users (Logical Delete concept: where aktif = 1)
            dg.DataSource = IDataBase.DatatoDataTable("select * from okuyucular where aktif = 1");
            
            // Hide the ID column from the user interface
            dg.Columns["id"].Visible = false;
        }

        // Function to "Soft Delete" a reader
        void okuyucuSil()
        {
            // Instead of DELETE FROM, we update the status to 0 (Passive/Deleted)
            IDataBase.executeNonQuery("update okuyucular set aktif = 0 where id = @id", new SqlParameter("@id", SqlDbType.Int) { Value = okuyucuId });
            
            temizle();     
            okuyucularLoad(); 
        }

        // Event Handler for the Save/Update Button
        private void button1_Click(object sender, EventArgs e)
        {
            // Validation: Ensure mandatory fields are filled
            if (string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyad.Text) || maskedCepTel.MaskFull == false)
            {
                MessageBox.Show("Adı, Soyadı ve Cep Telefonu alanları boş geçilemez!");
                return;
            }

            // Logic to decide between Update or Insert
            if (okuyucuId > 0)
            {
                // If an ID exists, it's an existing record -> Update
                okuyucuGuncelle();
            }
            else
            {
                // If ID is 0, it's a new record -> Insert
                okuyucuEkle();
            }
        }

        // Event Handler for clicking a row in the DataGridView
        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is on a valid row (not the header)
            if (e.RowIndex > -1)
            {
                // Get the ID of the selected reader from the hidden column
                okuyucuId = Convert.ToInt32(dg.Rows[e.RowIndex].Cells["id"].Value);

                // Reset radio buttons temporarily
                radiobtnErkek.Checked = false;
                radioBtnKadin.Checked = true; // Default fallback

                // Query the database to get full details of the selected reader
                foreach (DataRow row in IDataBase.DatatoDataTable("select * from okuyucular where aktif = 1 and id = @id", new SqlParameter("@id", SqlDbType.Int) { Value = okuyucuId }).Rows)
                {
                    txtAd.Text = row["adi"].ToString();
                    txtSoyad.Text = row["soyadi"].ToString();
                    
                    // Set gender radio button
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

        // Function to clear all input fields on the form
        void temizle()
        {
            okuyucuId = 0; // Reset ID to indicate "New Record" mode

            // Reset gender selection
            radiobtnErkek.Checked = false;
            radioBtnKadin.Checked = false;

            // Iterate through all controls inside the 'grpBilgiler' container
            foreach (var item in grpBilgiler.Controls)
            {
                
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }

                // Clear MaskedTextBoxes (Phone numbers etc.)
                if (item is MaskedTextBox)
                {
                    ((MaskedTextBox)item).Text = "";
                }
            }
        }

        // Event Handler for Delete Button
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

        // Event Handler for Clear/Reset Button
        private void btTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}