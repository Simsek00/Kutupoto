namespace Kutupoto
{
    partial class OkuyucuEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OkuyucuEkle));
            panelHeader = new Panel();
            labelTitle = new Label();
            btnCikis = new Button();
            panelLeft = new Panel();
            grpBilgiler = new GroupBox();
            label1 = new Label();
            txtAd = new TextBox();
            label2 = new Label();
            txtSoyad = new TextBox();
            label3 = new Label();
            radiobtnErkek = new RadioButton();
            radioBtnKadin = new RadioButton();
            label4 = new Label();
            txtSinif = new TextBox();
            label5 = new Label();
            txtOkulNo = new TextBox();
            label6 = new Label();
            maskedCepTel = new MaskedTextBox();
            label7 = new Label();
            txtAdres = new TextBox();
            panelButtons = new Panel();
            button1 = new Button();
            btSil = new Button();
            btTemizle = new Button();
            dg = new DataGridView();
            panelHeader.SuspendLayout();
            panelLeft.SuspendLayout();
            grpBilgiler.SuspendLayout();
            panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(44, 62, 80);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Controls.Add(btnCikis);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(900, 50);
            panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(20, 12);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(202, 25);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "OKUYUCU İŞLEMLERİ";
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
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(236, 240, 241);
            panelLeft.Controls.Add(grpBilgiler);
            panelLeft.Controls.Add(panelButtons);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 50);
            panelLeft.Name = "panelLeft";
            panelLeft.Padding = new Padding(10);
            panelLeft.Size = new Size(320, 550);
            panelLeft.TabIndex = 1;
            // 
            // grpBilgiler
            // 
            grpBilgiler.Controls.Add(label1);
            grpBilgiler.Controls.Add(txtAd);
            grpBilgiler.Controls.Add(label2);
            grpBilgiler.Controls.Add(txtSoyad);
            grpBilgiler.Controls.Add(label3);
            grpBilgiler.Controls.Add(radiobtnErkek);
            grpBilgiler.Controls.Add(radioBtnKadin);
            grpBilgiler.Controls.Add(label4);
            grpBilgiler.Controls.Add(txtSinif);
            grpBilgiler.Controls.Add(label5);
            grpBilgiler.Controls.Add(txtOkulNo);
            grpBilgiler.Controls.Add(label6);
            grpBilgiler.Controls.Add(maskedCepTel);
            grpBilgiler.Controls.Add(label7);
            grpBilgiler.Controls.Add(txtAdres);
            grpBilgiler.Dock = DockStyle.Top;
            grpBilgiler.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            grpBilgiler.ForeColor = Color.FromArgb(44, 62, 80);
            grpBilgiler.Location = new Point(10, 10);
            grpBilgiler.Name = "grpBilgiler";
            grpBilgiler.Size = new Size(300, 380);
            grpBilgiler.TabIndex = 0;
            grpBilgiler.TabStop = false;
            grpBilgiler.Text = "Üye Bilgileri";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 30);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 0;
            label1.Text = "Adı";
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtAd.Location = new Point(15, 48);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(270, 25);
            txtAd.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 80);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Soyadı";
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoyad.Location = new Point(15, 98);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(270, 25);
            txtSoyad.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(15, 130);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 4;
            label3.Text = "Cinsiyet";
            // 
            // radiobtnErkek
            // 
            radiobtnErkek.AutoSize = true;
            radiobtnErkek.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radiobtnErkek.Location = new Point(80, 130);
            radiobtnErkek.Name = "radiobtnErkek";
            radiobtnErkek.Size = new Size(53, 19);
            radiobtnErkek.TabIndex = 5;
            radiobtnErkek.TabStop = true;
            radiobtnErkek.Text = "Erkek";
            radiobtnErkek.UseVisualStyleBackColor = true;
            radiobtnErkek.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioBtnKadin
            // 
            radioBtnKadin.AutoSize = true;
            radioBtnKadin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioBtnKadin.Location = new Point(150, 130);
            radioBtnKadin.Name = "radioBtnKadin";
            radioBtnKadin.Size = new Size(55, 19);
            radioBtnKadin.TabIndex = 6;
            radioBtnKadin.TabStop = true;
            radioBtnKadin.Text = "Kadın";
            radioBtnKadin.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(15, 160);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 7;
            label4.Text = "Sınıfı";
            // 
            // txtSinif
            // 
            txtSinif.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSinif.Location = new Point(15, 178);
            txtSinif.Name = "txtSinif";
            txtSinif.Size = new Size(120, 25);
            txtSinif.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(165, 160);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 9;
            label5.Text = "Okul No";
            // 
            // txtOkulNo
            // 
            txtOkulNo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtOkulNo.Location = new Point(165, 178);
            txtOkulNo.Name = "txtOkulNo";
            txtOkulNo.Size = new Size(120, 25);
            txtOkulNo.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(15, 210);
            label6.Name = "label6";
            label6.Size = new Size(100, 15);
            label6.TabIndex = 11;
            label6.Text = "Telefon Numarası";
            // 
            // maskedCepTel
            // 
            maskedCepTel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            maskedCepTel.Location = new Point(15, 228);
            maskedCepTel.Mask = "(999) 000-0000";
            maskedCepTel.Name = "maskedCepTel";
            maskedCepTel.Size = new Size(270, 25);
            maskedCepTel.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(15, 260);
            label7.Name = "label7";
            label7.Size = new Size(37, 15);
            label7.TabIndex = 13;
            label7.Text = "Adres";
            // 
            // txtAdres
            // 
            txtAdres.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtAdres.Location = new Point(15, 278);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(270, 80);
            txtAdres.TabIndex = 14;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(button1);
            panelButtons.Controls.Add(btSil);
            panelButtons.Controls.Add(btTemizle);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(10, 420);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(300, 120);
            panelButtons.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(39, 174, 96);
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(300, 45);
            button1.TabIndex = 0;
            button1.Text = "KAYDET / GÜNCELLE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btSil
            // 
            btSil.BackColor = Color.FromArgb(192, 57, 43);
            btSil.Cursor = Cursors.Hand;
            btSil.FlatAppearance.BorderSize = 0;
            btSil.FlatStyle = FlatStyle.Flat;
            btSil.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btSil.ForeColor = Color.White;
            btSil.Location = new Point(0, 55);
            btSil.Name = "btSil";
            btSil.Size = new Size(145, 40);
            btSil.TabIndex = 1;
            btSil.Text = "SİL";
            btSil.UseVisualStyleBackColor = false;
            btSil.Click += btSil_Click;
            // 
            // btTemizle
            // 
            btTemizle.BackColor = Color.FromArgb(230, 126, 34);
            btTemizle.Cursor = Cursors.Hand;
            btTemizle.FlatAppearance.BorderSize = 0;
            btTemizle.FlatStyle = FlatStyle.Flat;
            btTemizle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btTemizle.ForeColor = Color.White;
            btTemizle.Location = new Point(155, 55);
            btTemizle.Name = "btTemizle";
            btTemizle.Size = new Size(145, 40);
            btTemizle.TabIndex = 2;
            btTemizle.Text = "TEMİZLE";
            btTemizle.UseVisualStyleBackColor = false;
            btTemizle.Click += btTemizle_Click;
            // 
            // dg
            // 
            dg.AllowUserToAddRows = false;
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg.BackgroundColor = Color.White;
            dg.BorderStyle = BorderStyle.None;
            dg.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dg.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(39, 174, 96);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dg.DefaultCellStyle = dataGridViewCellStyle2;
            dg.Dock = DockStyle.Fill;
            dg.EnableHeadersVisualStyles = false;
            dg.GridColor = Color.FromArgb(236, 240, 241);
            dg.Location = new Point(320, 50);
            dg.MultiSelect = false;
            dg.Name = "dg";
            dg.ReadOnly = true;
            dg.RowHeadersVisible = false;
            dg.RowTemplate.Height = 35;
            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg.Size = new Size(580, 550);
            dg.TabIndex = 2;
            dg.CellClick += dg_CellClick;
            // 
            // OkuyucuEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 600);
            Controls.Add(dg);
            Controls.Add(panelLeft);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "OkuyucuEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OkuyucuEkle";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelLeft.ResumeLayout(false);
            grpBilgiler.ResumeLayout(false);
            grpBilgiler.PerformLayout();
            panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dg).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.GroupBox grpBilgiler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radiobtnErkek;
        private System.Windows.Forms.RadioButton radioBtnKadin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSinif;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOkulNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedCepTel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btSil;
        private System.Windows.Forms.Button btTemizle;
        private System.Windows.Forms.DataGridView dg;
    }
}