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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kiralama));
            tableLayoutPanel1 = new TableLayoutPanel();
            lblAdSoyad = new Label();
            lblSinif = new Label();
            lblOkulNo = new Label();
            lblGecikmeBedeli = new Label();
            groupBox1 = new GroupBox();
            dgOkuyucular = new DataGridView();
            groupBox2 = new GroupBox();
            dgKitaplar = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblKayitNo = new Label();
            lblKitapAdi = new Label();
            lblYazarAdi = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnSureUzat = new Button();
            btnDüsümYap = new Button();
            btnEmanetEt = new Button();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgOkuyucular).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgKitaplar).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(lblAdSoyad, 0, 0);
            tableLayoutPanel1.Controls.Add(lblSinif, 0, 1);
            tableLayoutPanel1.Controls.Add(lblOkulNo, 0, 2);
            tableLayoutPanel1.Controls.Add(lblGecikmeBedeli, 0, 3);
            tableLayoutPanel1.Location = new Point(6, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(244, 157);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.Anchor = AnchorStyles.Left;
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Location = new Point(3, 12);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(57, 15);
            lblAdSoyad.TabIndex = 0;
            lblAdSoyad.Text = "Ad Soyad";
            // 
            // lblSinif
            // 
            lblSinif.Anchor = AnchorStyles.Left;
            lblSinif.AutoSize = true;
            lblSinif.Location = new Point(3, 51);
            lblSinif.Name = "lblSinif";
            lblSinif.Size = new Size(30, 15);
            lblSinif.TabIndex = 1;
            lblSinif.Text = "Sınıf";
            // 
            // lblOkulNo
            // 
            lblOkulNo.Anchor = AnchorStyles.Left;
            lblOkulNo.AutoSize = true;
            lblOkulNo.Location = new Point(3, 90);
            lblOkulNo.Name = "lblOkulNo";
            lblOkulNo.Size = new Size(51, 15);
            lblOkulNo.TabIndex = 2;
            lblOkulNo.Text = "Okul No";
            // 
            // lblGecikmeBedeli
            // 
            lblGecikmeBedeli.Anchor = AnchorStyles.Left;
            lblGecikmeBedeli.AutoSize = true;
            lblGecikmeBedeli.Location = new Point(3, 129);
            lblGecikmeBedeli.Name = "lblGecikmeBedeli";
            lblGecikmeBedeli.Size = new Size(88, 15);
            lblGecikmeBedeli.TabIndex = 3;
            lblGecikmeBedeli.Text = "Gecikme Bedeli";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgOkuyucular);
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(810, 211);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Okuyucu Seç";
            // 
            // dgOkuyucular
            // 
            dgOkuyucular.AllowUserToAddRows = false;
            dgOkuyucular.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgOkuyucular.Location = new Point(256, 22);
            dgOkuyucular.MultiSelect = false;
            dgOkuyucular.Name = "dgOkuyucular";
            dgOkuyucular.ReadOnly = true;
            dgOkuyucular.RowTemplate.Height = 25;
            dgOkuyucular.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgOkuyucular.Size = new Size(548, 183);
            dgOkuyucular.TabIndex = 1;
            dgOkuyucular.CellClick += dgOkuyucular_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgKitaplar);
            groupBox2.Controls.Add(tableLayoutPanel2);
            groupBox2.Location = new Point(12, 229);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(816, 226);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kitap Seç";
            // 
            // dgKitaplar
            // 
            dgKitaplar.AllowUserToAddRows = false;
            dgKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgKitaplar.Location = new Point(250, 22);
            dgKitaplar.MultiSelect = false;
            dgKitaplar.Name = "dgKitaplar";
            dgKitaplar.ReadOnly = true;
            dgKitaplar.RowTemplate.Height = 25;
            dgKitaplar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgKitaplar.Size = new Size(548, 189);
            dgKitaplar.TabIndex = 1;
            dgKitaplar.CellClick += dgKitaplar_CellClick;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Controls.Add(lblKayitNo, 1, 0);
            tableLayoutPanel2.Controls.Add(lblKitapAdi, 1, 1);
            tableLayoutPanel2.Controls.Add(lblYazarAdi, 1, 2);
            tableLayoutPanel2.Location = new Point(6, 22);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(238, 134);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 14);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Kayıt No";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 58);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Kitap Adı";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 103);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "Yazar Adı";
            // 
            // lblKayitNo
            // 
            lblKayitNo.Anchor = AnchorStyles.Left;
            lblKayitNo.AutoSize = true;
            lblKayitNo.Location = new Point(122, 14);
            lblKayitNo.Name = "lblKayitNo";
            lblKayitNo.Size = new Size(16, 15);
            lblKayitNo.TabIndex = 3;
            lblKayitNo.Text = "...";
            // 
            // lblKitapAdi
            // 
            lblKitapAdi.Anchor = AnchorStyles.Left;
            lblKitapAdi.AutoSize = true;
            lblKitapAdi.Location = new Point(122, 58);
            lblKitapAdi.Name = "lblKitapAdi";
            lblKitapAdi.Size = new Size(16, 15);
            lblKitapAdi.TabIndex = 4;
            lblKitapAdi.Text = "...";
            // 
            // lblYazarAdi
            // 
            lblYazarAdi.Anchor = AnchorStyles.Left;
            lblYazarAdi.AutoSize = true;
            lblYazarAdi.Location = new Point(122, 103);
            lblYazarAdi.Name = "lblYazarAdi";
            lblYazarAdi.Size = new Size(16, 15);
            lblYazarAdi.TabIndex = 5;
            lblYazarAdi.Text = "...";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(btnSureUzat, 1, 0);
            tableLayoutPanel3.Controls.Add(btnDüsümYap, 2, 0);
            tableLayoutPanel3.Controls.Add(btnEmanetEt, 0, 0);
            tableLayoutPanel3.Location = new Point(12, 461);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(244, 40);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // btnSureUzat
            // 
            btnSureUzat.Location = new Point(84, 3);
            btnSureUzat.Name = "btnSureUzat";
            btnSureUzat.Size = new Size(75, 34);
            btnSureUzat.TabIndex = 1;
            btnSureUzat.Text = "Süre Uzat";
            btnSureUzat.UseVisualStyleBackColor = true;
            btnSureUzat.Click += btnSureUzat_Click;
            // 
            // btnDüsümYap
            // 
            btnDüsümYap.Location = new Point(165, 3);
            btnDüsümYap.Name = "btnDüsümYap";
            btnDüsümYap.Size = new Size(76, 34);
            btnDüsümYap.TabIndex = 2;
            btnDüsümYap.Text = "Düşüm Yap";
            btnDüsümYap.UseVisualStyleBackColor = true;
            btnDüsümYap.Click += btnDüsümYap_Click;
            // 
            // btnEmanetEt
            // 
            btnEmanetEt.Location = new Point(3, 3);
            btnEmanetEt.Name = "btnEmanetEt";
            btnEmanetEt.Size = new Size(75, 34);
            btnEmanetEt.TabIndex = 0;
            btnEmanetEt.Text = "Emanet Et";
            btnEmanetEt.UseVisualStyleBackColor = true;
            btnEmanetEt.Click += btnEmanetEt_Click;
            // 
            // Kiralama
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(834, 506);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Kiralama";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kiralama İşlemleri";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgOkuyucular).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgKitaplar).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblAdSoyad;
        private Label lblSinif;
        private Label lblOkulNo;
        private Label lblGecikmeBedeli;
        private GroupBox groupBox1;
        private DataGridView dgOkuyucular;
        private GroupBox groupBox2;
        private DataGridView dgKitaplar;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblKayitNo;
        private Label lblKitapAdi;
        private Label lblYazarAdi;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnEmanetEt;
        private Button btnSureUzat;
        private Button btnDüsümYap;
    }
}