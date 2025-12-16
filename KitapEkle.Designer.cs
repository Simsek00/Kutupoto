namespace Kutupoto
{
    partial class KitapEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapEkle));
            panelHeader = new Panel();
            labelTitle = new Label();
            btnCikis = new Button();
            panelLeft = new Panel();
            grpKitapBilgi = new GroupBox();
            label1 = new Label();
            txtKayitNo = new TextBox();
            label2 = new Label();
            txtKitapAdi = new TextBox();
            label3 = new Label();
            txtYazar = new TextBox();
            label4 = new Label();
            txtSayfa = new TextBox();
            label5 = new Label();
            txtTur = new TextBox();
            label6 = new Label();
            txtYayinevi = new TextBox();
            label7 = new Label();
            txtBasimYili = new TextBox();
            label8 = new Label();
            txtDolapNo = new TextBox();
            label9 = new Label();
            txtRafNo = new TextBox();
            panelButtons = new Panel();
            btnKaydet = new Button();
            btnSil = new Button();
            btnTemizle = new Button();
            dg = new DataGridView();
            panelHeader.SuspendLayout();
            panelLeft.SuspendLayout();
            grpKitapBilgi.SuspendLayout();
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
            panelHeader.Size = new Size(1000, 50);
            panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(20, 13);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(163, 25);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "KİTAP İŞLEMLERİ";
            // 
            // btnCikis
            // 
            btnCikis.Dock = DockStyle.Right;
            btnCikis.FlatAppearance.BorderSize = 0;
            btnCikis.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 57, 43);
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCikis.ForeColor = Color.White;
            btnCikis.Location = new Point(950, 0);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(50, 50);
            btnCikis.TabIndex = 0;
            btnCikis.Text = "X";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click_1;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(236, 240, 241);
            panelLeft.Controls.Add(grpKitapBilgi);
            panelLeft.Controls.Add(panelButtons);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 50);
            panelLeft.Name = "panelLeft";
            panelLeft.Padding = new Padding(10);
            panelLeft.Size = new Size(340, 600);
            panelLeft.TabIndex = 1;
            // 
            // grpKitapBilgi
            // 
            grpKitapBilgi.Controls.Add(label1);
            grpKitapBilgi.Controls.Add(txtKayitNo);
            grpKitapBilgi.Controls.Add(label2);
            grpKitapBilgi.Controls.Add(txtKitapAdi);
            grpKitapBilgi.Controls.Add(label3);
            grpKitapBilgi.Controls.Add(txtYazar);
            grpKitapBilgi.Controls.Add(label4);
            grpKitapBilgi.Controls.Add(txtSayfa);
            grpKitapBilgi.Controls.Add(label5);
            grpKitapBilgi.Controls.Add(txtTur);
            grpKitapBilgi.Controls.Add(label6);
            grpKitapBilgi.Controls.Add(txtYayinevi);
            grpKitapBilgi.Controls.Add(label7);
            grpKitapBilgi.Controls.Add(txtBasimYili);
            grpKitapBilgi.Controls.Add(label8);
            grpKitapBilgi.Controls.Add(txtDolapNo);
            grpKitapBilgi.Controls.Add(label9);
            grpKitapBilgi.Controls.Add(txtRafNo);
            grpKitapBilgi.Dock = DockStyle.Top;
            grpKitapBilgi.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            grpKitapBilgi.ForeColor = Color.FromArgb(44, 62, 80);
            grpKitapBilgi.Location = new Point(10, 10);
            grpKitapBilgi.Name = "grpKitapBilgi";
            grpKitapBilgi.Size = new Size(320, 454);
            grpKitapBilgi.TabIndex = 0;
            grpKitapBilgi.TabStop = false;
            grpKitapBilgi.Text = "Kitap Bilgileri";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 35);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Kayıt No";
            // 
            // txtKayitNo
            // 
            txtKayitNo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtKayitNo.Location = new Point(110, 30);
            txtKayitNo.Name = "txtKayitNo";
            txtKayitNo.Size = new Size(190, 25);
            txtKayitNo.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 75);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Kitap Adı";
            // 
            // txtKitapAdi
            // 
            txtKitapAdi.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtKitapAdi.Location = new Point(110, 70);
            txtKitapAdi.Name = "txtKitapAdi";
            txtKitapAdi.Size = new Size(190, 25);
            txtKitapAdi.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(15, 115);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 2;
            label3.Text = "Yazar";
            // 
            // txtYazar
            // 
            txtYazar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtYazar.Location = new Point(110, 110);
            txtYazar.Name = "txtYazar";
            txtYazar.Size = new Size(190, 25);
            txtYazar.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(15, 155);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 3;
            label4.Text = "Sayfa Sayısı";
            // 
            // txtSayfa
            // 
            txtSayfa.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSayfa.Location = new Point(110, 150);
            txtSayfa.Name = "txtSayfa";
            txtSayfa.Size = new Size(190, 25);
            txtSayfa.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(15, 195);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 4;
            label5.Text = "Türü";
            // 
            // txtTur
            // 
            txtTur.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTur.Location = new Point(110, 190);
            txtTur.Name = "txtTur";
            txtTur.Size = new Size(190, 25);
            txtTur.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(15, 235);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 5;
            label6.Text = "Yayınevi";
            // 
            // txtYayinevi
            // 
            txtYayinevi.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtYayinevi.Location = new Point(110, 230);
            txtYayinevi.Name = "txtYayinevi";
            txtYayinevi.Size = new Size(190, 25);
            txtYayinevi.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(15, 275);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 6;
            label7.Text = "Basım Yılı";
            // 
            // txtBasimYili
            // 
            txtBasimYili.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtBasimYili.Location = new Point(110, 270);
            txtBasimYili.Name = "txtBasimYili";
            txtBasimYili.Size = new Size(190, 25);
            txtBasimYili.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(15, 315);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 7;
            label8.Text = "Dolap No";
            // 
            // txtDolapNo
            // 
            txtDolapNo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDolapNo.Location = new Point(110, 310);
            txtDolapNo.Name = "txtDolapNo";
            txtDolapNo.Size = new Size(190, 25);
            txtDolapNo.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(15, 355);
            label9.Name = "label9";
            label9.Size = new Size(43, 15);
            label9.TabIndex = 8;
            label9.Text = "Raf No";
            // 
            // txtRafNo
            // 
            txtRafNo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtRafNo.Location = new Point(110, 350);
            txtRafNo.Name = "txtRafNo";
            txtRafNo.Size = new Size(190, 25);
            txtRafNo.TabIndex = 8;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(btnKaydet);
            panelButtons.Controls.Add(btnSil);
            panelButtons.Controls.Add(btnTemizle);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(10, 470);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(320, 120);
            panelButtons.TabIndex = 1;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.FromArgb(39, 174, 96);
            btnKaydet.Cursor = Cursors.Hand;
            btnKaydet.Dock = DockStyle.Top;
            btnKaydet.FlatAppearance.BorderSize = 0;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(0, 0);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(320, 45);
            btnKaydet.TabIndex = 0;
            btnKaydet.Text = "KAYDET / GÜNCELLE";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(192, 57, 43);
            btnSil.Cursor = Cursors.Hand;
            btnSil.FlatAppearance.BorderSize = 0;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(0, 55);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(155, 40);
            btnSil.TabIndex = 1;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.FromArgb(230, 126, 34);
            btnTemizle.Cursor = Cursors.Hand;
            btnTemizle.FlatAppearance.BorderSize = 0;
            btnTemizle.FlatStyle = FlatStyle.Flat;
            btnTemizle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnTemizle.ForeColor = Color.White;
            btnTemizle.Location = new Point(165, 55);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(155, 40);
            btnTemizle.TabIndex = 2;
            btnTemizle.Text = "TEMİZLE";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
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
            dg.Location = new Point(340, 50);
            dg.MultiSelect = false;
            dg.Name = "dg";
            dg.ReadOnly = true;
            dg.RowHeadersVisible = false;
            dg.RowTemplate.Height = 35;
            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg.Size = new Size(660, 600);
            dg.TabIndex = 2;
            dg.CellClick += dg_CellClick;
            // 
            // KitapEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 650);
            Controls.Add(dg);
            Controls.Add(panelLeft);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "KitapEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kitap Ekle";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelLeft.ResumeLayout(false);
            grpKitapBilgi.ResumeLayout(false);
            grpKitapBilgi.PerformLayout();
            panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dg).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.GroupBox grpKitapBilgi;
        private System.Windows.Forms.TextBox txtKayitNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSayfa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtYayinevi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBasimYili;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDolapNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRafNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.DataGridView dg;
    }
}