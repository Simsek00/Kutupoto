namespace Kutupoto
{
    partial class Kayit
    {

        private System.ComponentModel.IContainer components = null;

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

        private void InitializeComponent()
        {
            lblAd = new Label();
            txtAd = new TextBox();
            txtKullanici = new TextBox();
            lblKullanici = new Label();
            txtSoyad = new TextBox();
            lblSoyad = new Label();
            txtSifre = new TextBox();
            lblSifre = new Label();
            btnKayit = new Button();
            label1 = new Label();
            panel1 = new Panel();
            btnCikis = new Button();
            lblKurallar = new Label(); 
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblAd.ForeColor = Color.Silver;
            lblAd.Location = new Point(50, 110);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(26, 19);
            lblAd.TabIndex = 0;
            lblAd.Text = "Ad";
            // 
            // txtAd
            // 
            txtAd.BackColor = Color.FromArgb(236, 240, 241);
            txtAd.BorderStyle = BorderStyle.FixedSingle;
            txtAd.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtAd.ForeColor = Color.FromArgb(44, 62, 80);
            txtAd.Location = new Point(50, 132);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(300, 27);
            txtAd.TabIndex = 1;
            // 
            // txtKullanici
            // 
            txtKullanici.BackColor = Color.FromArgb(236, 240, 241);
            txtKullanici.BorderStyle = BorderStyle.FixedSingle;
            txtKullanici.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtKullanici.ForeColor = Color.FromArgb(44, 62, 80);
            txtKullanici.Location = new Point(50, 262);
            txtKullanici.Name = "txtKullanici";
            txtKullanici.Size = new Size(300, 27);
            txtKullanici.TabIndex = 3;
            // 
            // lblKullanici
            // 
            lblKullanici.AutoSize = true;
            lblKullanici.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblKullanici.ForeColor = Color.Silver;
            lblKullanici.Location = new Point(50, 240);
            lblKullanici.Name = "lblKullanici";
            lblKullanici.Size = new Size(82, 19);
            lblKullanici.TabIndex = 2;
            lblKullanici.Text = "Kullanıcı Adı";
            // 
            // txtSoyad
            // 
            txtSoyad.BackColor = Color.FromArgb(236, 240, 241);
            txtSoyad.BorderStyle = BorderStyle.FixedSingle;
            txtSoyad.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoyad.ForeColor = Color.FromArgb(44, 62, 80);
            txtSoyad.Location = new Point(50, 197);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(300, 27);
            txtSoyad.TabIndex = 2;
            txtSoyad.TextChanged += textBox2_TextChanged;
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblSoyad.ForeColor = Color.Silver;
            lblSoyad.Location = new Point(50, 175);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(46, 19);
            lblSoyad.TabIndex = 4;
            lblSoyad.Text = "Soyad";
            // 
            // txtSifre
            // 
            txtSifre.BackColor = Color.FromArgb(236, 240, 241);
            txtSifre.BorderStyle = BorderStyle.FixedSingle;
            txtSifre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtSifre.ForeColor = Color.FromArgb(44, 62, 80);
            txtSifre.Location = new Point(50, 327);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '●';
            txtSifre.Size = new Size(300, 27);
            txtSifre.TabIndex = 4;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblSifre.ForeColor = Color.Silver;
            lblSifre.Location = new Point(50, 305);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(35, 19);
            lblSifre.TabIndex = 6;
            lblSifre.Text = "Şifre";
            // 
            // lblKurallar 
            // 
            lblKurallar.AutoSize = true;
            lblKurallar.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic, GraphicsUnit.Point);
            lblKurallar.ForeColor = Color.FromArgb(149, 165, 166); // Biraz daha soluk gri
            lblKurallar.Location = new Point(50, 358); // Şifre kutusunun hemen altı
            lblKurallar.Name = "lblKurallar";
            lblKurallar.Size = new Size(250, 30);
            lblKurallar.TabIndex = 7;
            lblKurallar.Text = "* En az 6 karakter (1 Büyük, 1 Küçük harf)\n* Özel karakter kullanmayınız";
            // 
            // btnKayit
            // 
            btnKayit.BackColor = Color.FromArgb(230, 126, 34);
            btnKayit.Cursor = Cursors.Hand;
            btnKayit.FlatAppearance.BorderSize = 0;
            btnKayit.FlatStyle = FlatStyle.Flat;
            btnKayit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKayit.ForeColor = Color.White;
            btnKayit.Location = new Point(50, 405); 
            btnKayit.Name = "btnKayit";
            btnKayit.Size = new Size(300, 45);
            btnKayit.TabIndex = 5;
            btnKayit.Text = "Kayıt Ol";
            btnKayit.UseVisualStyleBackColor = false;
            btnKayit.Click += btnKayit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(100, 50);
            label1.Name = "label1";
            label1.Size = new Size(160, 37);
            label1.TabIndex = 9;
            label1.Text = "YENİ KAYIT";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 73, 94);
            panel1.Controls.Add(btnCikis);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 35);
            panel1.TabIndex = 10;
            // 
            // btnCikis
            // 
            btnCikis.Cursor = Cursors.Hand;
            btnCikis.Dock = DockStyle.Right;
            btnCikis.FlatAppearance.BorderSize = 0;
            btnCikis.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 57, 43);
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCikis.ForeColor = Color.White;
            btnCikis.Location = new Point(360, 0);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(40, 35);
            btnCikis.TabIndex = 0;
            btnCikis.Text = "X";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // Kayit
            // 
            AcceptButton = btnKayit;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 62, 80);
            ClientSize = new Size(400, 500); 
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(btnKayit);
            Controls.Add(lblKurallar); 
            Controls.Add(txtSifre);
            Controls.Add(lblSifre);
            Controls.Add(txtSoyad);
            Controls.Add(lblSoyad);
            Controls.Add(txtKullanici);
            Controls.Add(lblKullanici);
            Controls.Add(txtAd);
            Controls.Add(lblAd);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Kayit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kayit";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label lblKurallar;
    }
}