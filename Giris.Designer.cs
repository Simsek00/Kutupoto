namespace Kutupoto
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            lblBaslik = new Label();
            label1 = new Label();
            txtKullanici = new TextBox();
            txtSifre = new TextBox();
            label2 = new Label();
            butKayit = new Button();
            butGiris = new Button();
            panel1 = new Panel();
            btnCikis = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblBaslik.ForeColor = Color.White;
            lblBaslik.Location = new Point(35, 70);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(294, 37);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "KÜTÜPHANE SİSTEMİ";
            lblBaslik.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(50, 150);
            label1.Name = "label1";
            label1.Size = new Size(82, 19);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Adı";
            // 
            // txtKullanici
            // 
            txtKullanici.BackColor = Color.FromArgb(236, 240, 241);
            txtKullanici.BorderStyle = BorderStyle.FixedSingle;
            txtKullanici.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtKullanici.ForeColor = Color.FromArgb(44, 62, 80);
            txtKullanici.Location = new Point(50, 175);
            txtKullanici.Name = "txtKullanici";
            txtKullanici.Size = new Size(300, 29);
            txtKullanici.TabIndex = 2;
            // 
            // txtSifre
            // 
            txtSifre.BackColor = Color.FromArgb(236, 240, 241);
            txtSifre.BorderStyle = BorderStyle.FixedSingle;
            txtSifre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSifre.ForeColor = Color.FromArgb(44, 62, 80);
            txtSifre.Location = new Point(50, 250);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '●';
            txtSifre.Size = new Size(300, 29);
            txtSifre.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(50, 225);
            label2.Name = "label2";
            label2.Size = new Size(35, 19);
            label2.TabIndex = 3;
            label2.Text = "Şifre";
            // 
            // butKayit
            // 
            butKayit.BackColor = Color.FromArgb(230, 126, 34);
            butKayit.Cursor = Cursors.Hand;
            butKayit.FlatAppearance.BorderSize = 0;
            butKayit.FlatStyle = FlatStyle.Flat;
            butKayit.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            butKayit.ForeColor = Color.White;
            butKayit.Location = new Point(50, 320);
            butKayit.Name = "butKayit";
            butKayit.Size = new Size(140, 45);
            butKayit.TabIndex = 5;
            butKayit.Text = "Kayıt Ol";
            butKayit.UseVisualStyleBackColor = false;
            butKayit.Click += butKayit_Click;
            // 
            // butGiris
            // 
            butGiris.BackColor = Color.FromArgb(46, 204, 113);
            butGiris.Cursor = Cursors.Hand;
            butGiris.FlatAppearance.BorderSize = 0;
            butGiris.FlatStyle = FlatStyle.Flat;
            butGiris.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            butGiris.ForeColor = Color.White;
            butGiris.Location = new Point(210, 320);
            butGiris.Name = "butGiris";
            butGiris.Size = new Size(140, 45);
            butGiris.TabIndex = 6;
            butGiris.Text = "Giriş Yap";
            butGiris.UseVisualStyleBackColor = false;
            butGiris.Click += butGiris_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 73, 94);
            panel1.Controls.Add(btnCikis);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 35);
            panel1.TabIndex = 7;
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
            // Giris
            // 
            AcceptButton = butGiris;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 62, 80);
            ClientSize = new Size(400, 450);
            Controls.Add(panel1);
            Controls.Add(butGiris);
            Controls.Add(butKayit);
            Controls.Add(txtSifre);
            Controls.Add(label2);
            Controls.Add(txtKullanici);
            Controls.Add(label1);
            Controls.Add(lblBaslik);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Giris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş";
            Load += Giris_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butKayit;
        private System.Windows.Forms.Button butGiris;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCikis;
    }
}