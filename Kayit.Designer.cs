namespace Kutupoto
{
    partial class Kayit
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
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(51, 61);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(25, 15);
            lblAd.TabIndex = 0;
            lblAd.Text = "Ad:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(133, 58);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 1;
            // 
            // txtKullanici
            // 
            txtKullanici.Location = new Point(133, 119);
            txtKullanici.Name = "txtKullanici";
            txtKullanici.Size = new Size(100, 23);
            txtKullanici.TabIndex = 3;
            // 
            // lblKullanici
            // 
            lblKullanici.AutoSize = true;
            lblKullanici.Location = new Point(51, 122);
            lblKullanici.Name = "lblKullanici";
            lblKullanici.Size = new Size(76, 15);
            lblKullanici.TabIndex = 2;
            lblKullanici.Text = "Kullanıcı Adı:";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(133, 90);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(100, 23);
            txtSoyad.TabIndex = 5;
            txtSoyad.TextChanged += textBox2_TextChanged;
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(51, 93);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(42, 15);
            lblSoyad.TabIndex = 4;
            lblSoyad.Text = "Soyad:";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(133, 148);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(100, 23);
            txtSifre.TabIndex = 7;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(51, 151);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(33, 15);
            lblSifre.TabIndex = 6;
            lblSifre.Text = "Şifre:";
            // 
            // btnKayit
            // 
            btnKayit.Location = new Point(133, 192);
            btnKayit.Name = "btnKayit";
            btnKayit.Size = new Size(100, 40);
            btnKayit.TabIndex = 8;
            btnKayit.Text = "Kayıt Ol";
            btnKayit.UseVisualStyleBackColor = true;
            btnKayit.Click += btnKayit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(61, 9);
            label1.Name = "label1";
            label1.Size = new Size(159, 32);
            label1.TabIndex = 9;
            label1.Text = "KAYIT EKRANI";
            label1.Click += label1_Click;
            // 
            // Kayit
            // 
            AcceptButton = btnKayit;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 277);
            Controls.Add(label1);
            Controls.Add(btnKayit);
            Controls.Add(txtSifre);
            Controls.Add(lblSifre);
            Controls.Add(txtSoyad);
            Controls.Add(lblSoyad);
            Controls.Add(txtKullanici);
            Controls.Add(lblKullanici);
            Controls.Add(txtAd);
            Controls.Add(lblAd);
            Name = "Kayit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kayit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAd;
        private TextBox txtAd;
        private TextBox txtKullanici;
        private Label lblKullanici;
        private TextBox txtSoyad;
        private Label lblSoyad;
        private TextBox txtSifre;
        private Label lblSifre;
        private Button btnKayit;
        private Label label1;
    }
}