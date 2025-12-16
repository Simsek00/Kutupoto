namespace Kutupoto
{
    partial class Kiralama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelHeader = new Panel();
            labelHeader = new Label();
            btnCikis = new Button();
            grpOkuyucu = new GroupBox();
            dgOkuyucular = new DataGridView();
            panelOkuyucuDetay = new Panel();
            lblGecikmeBedeli = new Label();
            lblOkulNo = new Label();
            lblSinif = new Label();
            lblAdSoyad = new Label();
            labelTitleOkuyucu = new Label();
            grpKitap = new GroupBox();
            dgKitaplar = new DataGridView();
            panelKitapDetay = new Panel();
            lblYazarAdi = new Label();
            lblKitapAdi = new Label();
            lblKayitNo = new Label();
            labelTitleKitap = new Label();
            panelBottom = new Panel();
            btnDüsümYap = new Button();
            btnSureUzat = new Button();
            btnEmanetEt = new Button();
            panelHeader.SuspendLayout();
            grpOkuyucu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgOkuyucular).BeginInit();
            panelOkuyucuDetay.SuspendLayout();
            grpKitap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgKitaplar).BeginInit();
            panelKitapDetay.SuspendLayout();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(44, 62, 80);
            panelHeader.Controls.Add(labelHeader);
            panelHeader.Controls.Add(btnCikis);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(900, 50);
            panelHeader.TabIndex = 0;
            // 
            // labelHeader
            // 
            labelHeader.AutoSize = true;
            labelHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelHeader.ForeColor = Color.White;
            labelHeader.Location = new Point(20, 13);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(207, 25);
            labelHeader.TabIndex = 1;
            labelHeader.Text = "KİRALAMA İŞLEMLERİ";
            // 
            // btnCikis
            // 
            btnCikis.Dock = DockStyle.Right;
            btnCikis.FlatAppearance.BorderSize = 0;
            btnCikis.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 57, 43);
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCikis.ForeColor = Color.White;
            btnCikis.Location = new Point(850, 0);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(50, 50);
            btnCikis.TabIndex = 0;
            btnCikis.Text = "X";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // grpOkuyucu
            // 
            grpOkuyucu.Controls.Add(dgOkuyucular);
            grpOkuyucu.Controls.Add(panelOkuyucuDetay);
            grpOkuyucu.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            grpOkuyucu.ForeColor = Color.FromArgb(44, 62, 80);
            grpOkuyucu.Location = new Point(20, 60);
            grpOkuyucu.Name = "grpOkuyucu";
            grpOkuyucu.Size = new Size(860, 220);
            grpOkuyucu.TabIndex = 1;
            grpOkuyucu.TabStop = false;
            grpOkuyucu.Text = "1. Adım: Okuyucu Seçimi";
            // 
            // dgOkuyucular
            // 
            dgOkuyucular.AllowUserToAddRows = false;
            dgOkuyucular.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgOkuyucular.BackgroundColor = Color.White;
            dgOkuyucular.BorderStyle = BorderStyle.None;
            dgOkuyucular.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgOkuyucular.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgOkuyucular.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgOkuyucular.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgOkuyucular.DefaultCellStyle = dataGridViewCellStyle2;
            dgOkuyucular.Dock = DockStyle.Left;
            dgOkuyucular.EnableHeadersVisualStyles = false;
            dgOkuyucular.Location = new Point(3, 21);
            dgOkuyucular.MultiSelect = false;
            dgOkuyucular.Name = "dgOkuyucular";
            dgOkuyucular.ReadOnly = true;
            dgOkuyucular.RowHeadersVisible = false;
            dgOkuyucular.RowTemplate.Height = 30;
            dgOkuyucular.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgOkuyucular.Size = new Size(580, 196);
            dgOkuyucular.TabIndex = 0;
            dgOkuyucular.CellClick += dgOkuyucular_CellClick;
            // 
            // panelOkuyucuDetay
            // 
            panelOkuyucuDetay.BackColor = Color.FromArgb(236, 240, 241);
            panelOkuyucuDetay.Controls.Add(lblGecikmeBedeli);
            panelOkuyucuDetay.Controls.Add(lblOkulNo);
            panelOkuyucuDetay.Controls.Add(lblSinif);
            panelOkuyucuDetay.Controls.Add(lblAdSoyad);
            panelOkuyucuDetay.Controls.Add(labelTitleOkuyucu);
            panelOkuyucuDetay.Dock = DockStyle.Right;
            panelOkuyucuDetay.Location = new Point(599, 21);
            panelOkuyucuDetay.Name = "panelOkuyucuDetay";
            panelOkuyucuDetay.Size = new Size(258, 196);
            panelOkuyucuDetay.TabIndex = 1;
            // 
            // lblGecikmeBedeli
            // 
            lblGecikmeBedeli.BackColor = Color.Transparent;
            lblGecikmeBedeli.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblGecikmeBedeli.ForeColor = Color.FromArgb(192, 57, 43);
            lblGecikmeBedeli.Location = new Point(10, 150);
            lblGecikmeBedeli.Name = "lblGecikmeBedeli";
            lblGecikmeBedeli.Size = new Size(240, 25);
            lblGecikmeBedeli.TabIndex = 4;
            lblGecikmeBedeli.Text = "Durum: Temiz";
            lblGecikmeBedeli.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOkulNo
            // 
            lblOkulNo.Location = new Point(10, 110);
            lblOkulNo.Name = "lblOkulNo";
            lblOkulNo.Size = new Size(240, 20);
            lblOkulNo.TabIndex = 3;
            lblOkulNo.Text = "No: ---";
            lblOkulNo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSinif
            // 
            lblSinif.Location = new Point(10, 80);
            lblSinif.Name = "lblSinif";
            lblSinif.Size = new Size(240, 20);
            lblSinif.TabIndex = 2;
            lblSinif.Text = "Sınıf: ---";
            lblSinif.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdSoyad.Location = new Point(10, 45);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(240, 25);
            lblAdSoyad.TabIndex = 1;
            lblAdSoyad.Text = "---";
            lblAdSoyad.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTitleOkuyucu
            // 
            labelTitleOkuyucu.BackColor = Color.FromArgb(149, 165, 166);
            labelTitleOkuyucu.Dock = DockStyle.Top;
            labelTitleOkuyucu.ForeColor = Color.White;
            labelTitleOkuyucu.Location = new Point(0, 0);
            labelTitleOkuyucu.Name = "labelTitleOkuyucu";
            labelTitleOkuyucu.Size = new Size(258, 30);
            labelTitleOkuyucu.TabIndex = 0;
            labelTitleOkuyucu.Text = "Seçili Okuyucu Bilgisi";
            labelTitleOkuyucu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpKitap
            // 
            grpKitap.Controls.Add(dgKitaplar);
            grpKitap.Controls.Add(panelKitapDetay);
            grpKitap.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            grpKitap.ForeColor = Color.FromArgb(44, 62, 80);
            grpKitap.Location = new Point(20, 290);
            grpKitap.Name = "grpKitap";
            grpKitap.Size = new Size(860, 220);
            grpKitap.TabIndex = 2;
            grpKitap.TabStop = false;
            grpKitap.Text = "2. Adım: Kitap Seçimi";
            // 
            // dgKitaplar
            // 
            dgKitaplar.AllowUserToAddRows = false;
            dgKitaplar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgKitaplar.BackgroundColor = Color.White;
            dgKitaplar.BorderStyle = BorderStyle.None;
            dgKitaplar.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgKitaplar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgKitaplar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgKitaplar.ColumnHeadersHeight = 35;
            dgKitaplar.DefaultCellStyle = dataGridViewCellStyle2;
            dgKitaplar.Dock = DockStyle.Left;
            dgKitaplar.EnableHeadersVisualStyles = false;
            dgKitaplar.Location = new Point(3, 21);
            dgKitaplar.MultiSelect = false;
            dgKitaplar.Name = "dgKitaplar";
            dgKitaplar.ReadOnly = true;
            dgKitaplar.RowHeadersVisible = false;
            dgKitaplar.RowTemplate.Height = 30;
            dgKitaplar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgKitaplar.Size = new Size(580, 196);
            dgKitaplar.TabIndex = 0;
            dgKitaplar.CellClick += dgKitaplar_CellClick;
            // 
            // panelKitapDetay
            // 
            panelKitapDetay.BackColor = Color.FromArgb(236, 240, 241);
            panelKitapDetay.Controls.Add(lblYazarAdi);
            panelKitapDetay.Controls.Add(lblKitapAdi);
            panelKitapDetay.Controls.Add(lblKayitNo);
            panelKitapDetay.Controls.Add(labelTitleKitap);
            panelKitapDetay.Dock = DockStyle.Right;
            panelKitapDetay.Location = new Point(599, 21);
            panelKitapDetay.Name = "panelKitapDetay";
            panelKitapDetay.Size = new Size(258, 196);
            panelKitapDetay.TabIndex = 1;
            // 
            // lblYazarAdi
            // 
            lblYazarAdi.Location = new Point(10, 140);
            lblYazarAdi.Name = "lblYazarAdi";
            lblYazarAdi.Size = new Size(240, 20);
            lblYazarAdi.TabIndex = 3;
            lblYazarAdi.Text = "Yazar: ---";
            lblYazarAdi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblKitapAdi
            // 
            lblKitapAdi.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblKitapAdi.Location = new Point(10, 85);
            lblKitapAdi.Name = "lblKitapAdi";
            lblKitapAdi.Size = new Size(240, 45);
            lblKitapAdi.TabIndex = 2;
            lblKitapAdi.Text = "---";
            lblKitapAdi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblKayitNo
            // 
            lblKayitNo.Location = new Point(10, 50);
            lblKayitNo.Name = "lblKayitNo";
            lblKayitNo.Size = new Size(240, 20);
            lblKayitNo.TabIndex = 1;
            lblKayitNo.Text = "Kayıt No: ---";
            lblKayitNo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTitleKitap
            // 
            labelTitleKitap.BackColor = Color.FromArgb(149, 165, 166);
            labelTitleKitap.Dock = DockStyle.Top;
            labelTitleKitap.ForeColor = Color.White;
            labelTitleKitap.Location = new Point(0, 0);
            labelTitleKitap.Name = "labelTitleKitap";
            labelTitleKitap.Size = new Size(258, 30);
            labelTitleKitap.TabIndex = 0;
            labelTitleKitap.Text = "Seçili Kitap Bilgisi";
            labelTitleKitap.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.White;
            panelBottom.Controls.Add(btnDüsümYap);
            panelBottom.Controls.Add(btnSureUzat);
            panelBottom.Controls.Add(btnEmanetEt);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 530);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(900, 70);
            panelBottom.TabIndex = 3;
            // 
            // btnDüsümYap
            // 
            btnDüsümYap.BackColor = Color.FromArgb(192, 57, 43);
            btnDüsümYap.Cursor = Cursors.Hand;
            btnDüsümYap.FlatAppearance.BorderSize = 0;
            btnDüsümYap.FlatStyle = FlatStyle.Flat;
            btnDüsümYap.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnDüsümYap.ForeColor = Color.White;
            btnDüsümYap.Location = new Point(677, 10);
            btnDüsümYap.Name = "btnDüsümYap";
            btnDüsümYap.Size = new Size(200, 50);
            btnDüsümYap.TabIndex = 2;
            btnDüsümYap.Text = "\U0001f6d1  DÜŞÜM YAP (İADE)";
            btnDüsümYap.UseVisualStyleBackColor = false;
            btnDüsümYap.Click += btnDüsümYap_Click;
            // 
            // btnSureUzat
            // 
            btnSureUzat.BackColor = Color.FromArgb(230, 126, 34);
            btnSureUzat.Cursor = Cursors.Hand;
            btnSureUzat.FlatAppearance.BorderSize = 0;
            btnSureUzat.FlatStyle = FlatStyle.Flat;
            btnSureUzat.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnSureUzat.ForeColor = Color.White;
            btnSureUzat.Location = new Point(350, 10);
            btnSureUzat.Name = "btnSureUzat";
            btnSureUzat.Size = new Size(200, 50);
            btnSureUzat.TabIndex = 1;
            btnSureUzat.Text = "⏳  SÜRE UZAT";
            btnSureUzat.UseVisualStyleBackColor = false;
            btnSureUzat.Click += btnSureUzat_Click;
            // 
            // btnEmanetEt
            // 
            btnEmanetEt.BackColor = Color.FromArgb(39, 174, 96);
            btnEmanetEt.Cursor = Cursors.Hand;
            btnEmanetEt.FlatAppearance.BorderSize = 0;
            btnEmanetEt.FlatStyle = FlatStyle.Flat;
            btnEmanetEt.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmanetEt.ForeColor = Color.White;
            btnEmanetEt.Location = new Point(23, 10);
            btnEmanetEt.Name = "btnEmanetEt";
            btnEmanetEt.Size = new Size(200, 50);
            btnEmanetEt.TabIndex = 0;
            btnEmanetEt.Text = "✅  EMANET ET";
            btnEmanetEt.UseVisualStyleBackColor = false;
            btnEmanetEt.Click += btnEmanetEt_Click;
            // 
            // Kiralama
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(900, 600);
            Controls.Add(panelBottom);
            Controls.Add(grpKitap);
            Controls.Add(grpOkuyucu);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Kiralama";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kiralama";
            Load += Kiralama_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            grpOkuyucu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgOkuyucular).EndInit();
            panelOkuyucuDetay.ResumeLayout(false);
            grpKitap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgKitaplar).EndInit();
            panelKitapDetay.ResumeLayout(false);
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.GroupBox grpOkuyucu;
        private System.Windows.Forms.DataGridView dgOkuyucular;
        private System.Windows.Forms.Panel panelOkuyucuDetay;
        private System.Windows.Forms.Label labelTitleOkuyucu;
        private System.Windows.Forms.Label lblOkulNo;
        private System.Windows.Forms.Label lblSinif;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblGecikmeBedeli;
        private System.Windows.Forms.GroupBox grpKitap;
        private System.Windows.Forms.DataGridView dgKitaplar;
        private System.Windows.Forms.Panel panelKitapDetay;
        private System.Windows.Forms.Label labelTitleKitap;
        private System.Windows.Forms.Label lblYazarAdi;
        private System.Windows.Forms.Label lblKitapAdi;
        private System.Windows.Forms.Label lblKayitNo;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnEmanetEt;
        private System.Windows.Forms.Button btnSureUzat;
        private System.Windows.Forms.Button btnDüsümYap;
    }
}