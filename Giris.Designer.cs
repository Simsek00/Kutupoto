namespace Kutupoto
{
    partial class Giris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
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
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblBaslik.Location = new Point(42, 9);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(264, 28);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "KÜTÜPHANE OTOMASYONU";
            lblBaslik.Click += lblBaslik_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 85);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Adı:";
            // 
            // txtKullanici
            // 
            txtKullanici.Location = new Point(150, 82);
            txtKullanici.Name = "txtKullanici";
            txtKullanici.Size = new Size(122, 23);
            txtKullanici.TabIndex = 2;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(150, 120);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(122, 23);
            txtSifre.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 123);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 3;
            label2.Text = "Şifre:";
            // 
            // butKayit
            // 
            butKayit.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            butKayit.Location = new Point(68, 189);
            butKayit.Name = "butKayit";
            butKayit.Size = new Size(89, 44);
            butKayit.TabIndex = 5;
            butKayit.Text = "Kayıt Ol";
            butKayit.UseVisualStyleBackColor = true;
            butKayit.Click += butKayit_Click;
            // 
            // butGiris
            // 
            butGiris.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            butGiris.Location = new Point(183, 189);
            butGiris.Name = "butGiris";
            butGiris.Size = new Size(89, 44);
            butGiris.TabIndex = 6;
            butGiris.Text = "Giriş Yap";
            butGiris.UseVisualStyleBackColor = true;
            butGiris.Click += butGiris_Click;
            // 
            // Giris
            // 
            AcceptButton = butGiris;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 301);
            Controls.Add(butGiris);
            Controls.Add(butKayit);
            Controls.Add(txtSifre);
            Controls.Add(label2);
            Controls.Add(txtKullanici);
            Controls.Add(label1);
            Controls.Add(lblBaslik);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Giris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş";
            Load += Giris_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBaslik;
        private Label label1;
        private TextBox txtKullanici;
        private TextBox txtSifre;
        private Label label2;
        private Button butKayit;
        private Button butGiris;
    }
}