namespace Kutupoto
{
    partial class AnaSayfa
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
            panelMenu = new Panel();
            btKapat = new Button();
            btKitap = new Button();
            btOkuyucu = new Button();
            btKiralama = new Button();
            panelLogo = new Panel();
            lblLogo = new Label();
            panelHeader = new Panel();
            lblBaslik = new Label();
            btnCikis = new Button();
            tabKiralanmiş = new TabControl();
            tabPage1 = new TabPage();
            dgEmanetler = new DataGridView();
            tabPage2 = new TabPage();
            dgMevcutKitaplar = new DataGridView();
            tabPage3 = new TabPage();
            dgOkuyucular = new DataGridView();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelHeader.SuspendLayout();
            tabKiralanmiş.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgEmanetler).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgMevcutKitaplar).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgOkuyucular).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(44, 62, 80);
            panelMenu.Controls.Add(btKapat);
            panelMenu.Controls.Add(btKitap);
            panelMenu.Controls.Add(btOkuyucu);
            panelMenu.Controls.Add(btKiralama);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 600);
            panelMenu.TabIndex = 0;
            // 
            // btKapat
            // 
            btKapat.Dock = DockStyle.Bottom;
            btKapat.FlatAppearance.BorderSize = 0;
            btKapat.FlatStyle = FlatStyle.Flat;
            btKapat.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btKapat.ForeColor = Color.FromArgb(231, 76, 60);
            btKapat.Location = new Point(0, 540);
            btKapat.Name = "btKapat";
            btKapat.Padding = new Padding(12, 0, 0, 0);
            btKapat.Size = new Size(220, 60);
            btKapat.TabIndex = 4;
            btKapat.Text = "🚪  Çıkış Yap";
            btKapat.TextAlign = ContentAlignment.MiddleLeft;
            btKapat.UseVisualStyleBackColor = true;
            btKapat.Click += btKapat_Click;
            // 
            // btKitap
            // 
            btKitap.Dock = DockStyle.Top;
            btKitap.FlatAppearance.BorderSize = 0;
            btKitap.FlatStyle = FlatStyle.Flat;
            btKitap.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btKitap.ForeColor = Color.Gainsboro;
            btKitap.Location = new Point(0, 200);
            btKitap.Name = "btKitap";
            btKitap.Padding = new Padding(12, 0, 0, 0);
            btKitap.Size = new Size(220, 60);
            btKitap.TabIndex = 3;
            btKitap.Text = "📚  Kitap Ekle";
            btKitap.TextAlign = ContentAlignment.MiddleLeft;
            btKitap.UseVisualStyleBackColor = true;
            btKitap.Click += btKitap_Click;
            // 
            // btOkuyucu
            // 
            btOkuyucu.Dock = DockStyle.Top;
            btOkuyucu.FlatAppearance.BorderSize = 0;
            btOkuyucu.FlatStyle = FlatStyle.Flat;
            btOkuyucu.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btOkuyucu.ForeColor = Color.Gainsboro;
            btOkuyucu.Location = new Point(0, 140);
            btOkuyucu.Name = "btOkuyucu";
            btOkuyucu.Padding = new Padding(12, 0, 0, 0);
            btOkuyucu.Size = new Size(220, 60);
            btOkuyucu.TabIndex = 2;
            btOkuyucu.Text = "👥  Okuyucu Ekle";
            btOkuyucu.TextAlign = ContentAlignment.MiddleLeft;
            btOkuyucu.UseVisualStyleBackColor = true;
            btOkuyucu.Click += btOkuyucu_Click;
            // 
            // btKiralama
            // 
            btKiralama.Dock = DockStyle.Top;
            btKiralama.FlatAppearance.BorderSize = 0;
            btKiralama.FlatStyle = FlatStyle.Flat;
            btKiralama.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btKiralama.ForeColor = Color.Gainsboro;
            btKiralama.Location = new Point(0, 80);
            btKiralama.Name = "btKiralama";
            btKiralama.Padding = new Padding(12, 0, 0, 0);
            btKiralama.Size = new Size(220, 60);
            btKiralama.TabIndex = 1;
            btKiralama.Text = "🔄  Kiralama İşlemleri";
            btKiralama.TextAlign = ContentAlignment.MiddleLeft;
            btKiralama.UseVisualStyleBackColor = true;
            btKiralama.Click += btKiralama_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(30, 46, 60);
            panelLogo.Controls.Add(lblLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 80);
            panelLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.Dock = DockStyle.Fill;
            lblLogo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(0, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(220, 80);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "KÜTÜPHANE\r\nPANELİ";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(lblBaslik);
            panelHeader.Controls.Add(btnCikis);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(220, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(780, 60);
            panelHeader.TabIndex = 1;
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblBaslik.ForeColor = Color.Black;
            lblBaslik.Location = new Point(20, 18);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(216, 25);
            lblBaslik.TabIndex = 1;
            lblBaslik.Text = "Hızlı Bakış ve İstatistikler";
            // 
            // btnCikis
            // 
            btnCikis.Cursor = Cursors.Hand;
            btnCikis.Dock = DockStyle.Right;
            btnCikis.FlatAppearance.BorderSize = 0;
            btnCikis.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 57, 43);
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCikis.Location = new Point(720, 0);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(60, 60);
            btnCikis.TabIndex = 0;
            btnCikis.Text = "X";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // tabKiralanmiş
            // 
            tabKiralanmiş.Controls.Add(tabPage1);
            tabKiralanmiş.Controls.Add(tabPage2);
            tabKiralanmiş.Controls.Add(tabPage3);
            tabKiralanmiş.Dock = DockStyle.Fill;
            tabKiralanmiş.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tabKiralanmiş.ItemSize = new Size(120, 30);
            tabKiralanmiş.Location = new Point(220, 60);
            tabKiralanmiş.Name = "tabKiralanmiş";
            tabKiralanmiş.Padding = new Point(20, 5);
            tabKiralanmiş.SelectedIndex = 0;
            tabKiralanmiş.Size = new Size(780, 540);
            tabKiralanmiş.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(236, 240, 241);
            tabPage1.Controls.Add(dgEmanetler);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(20);
            tabPage1.Size = new Size(772, 502);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Kiralanan Kitaplar";
            // 
            // dgEmanetler
            // 
            dgEmanetler.AllowUserToAddRows = false;
            dgEmanetler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgEmanetler.BackgroundColor = Color.White;
            dgEmanetler.BorderStyle = BorderStyle.None;
            dgEmanetler.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgEmanetler.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgEmanetler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgEmanetler.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(230, 126, 34);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgEmanetler.DefaultCellStyle = dataGridViewCellStyle2;
            dgEmanetler.Dock = DockStyle.Fill;
            dgEmanetler.EnableHeadersVisualStyles = false;
            dgEmanetler.GridColor = Color.FromArgb(236, 240, 241);
            dgEmanetler.Location = new Point(20, 20);
            dgEmanetler.MultiSelect = false;
            dgEmanetler.Name = "dgEmanetler";
            dgEmanetler.ReadOnly = true;
            dgEmanetler.RowHeadersVisible = false;
            dgEmanetler.RowTemplate.Height = 35;
            dgEmanetler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgEmanetler.Size = new Size(732, 462);
            dgEmanetler.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(236, 240, 241);
            tabPage2.Controls.Add(dgMevcutKitaplar);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(20);
            tabPage2.Size = new Size(772, 502);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mevcut Kitaplar";
            // 
            // dgMevcutKitaplar
            // 
            dgMevcutKitaplar.AllowUserToAddRows = false;
            dgMevcutKitaplar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgMevcutKitaplar.BackgroundColor = Color.White;
            dgMevcutKitaplar.BorderStyle = BorderStyle.None;
            dgMevcutKitaplar.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgMevcutKitaplar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgMevcutKitaplar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgMevcutKitaplar.ColumnHeadersHeight = 40;
            dgMevcutKitaplar.DefaultCellStyle = dataGridViewCellStyle2;
            dgMevcutKitaplar.Dock = DockStyle.Fill;
            dgMevcutKitaplar.EnableHeadersVisualStyles = false;
            dgMevcutKitaplar.GridColor = Color.FromArgb(236, 240, 241);
            dgMevcutKitaplar.Location = new Point(20, 20);
            dgMevcutKitaplar.MultiSelect = false;
            dgMevcutKitaplar.Name = "dgMevcutKitaplar";
            dgMevcutKitaplar.ReadOnly = true;
            dgMevcutKitaplar.RowHeadersVisible = false;
            dgMevcutKitaplar.RowTemplate.Height = 35;
            dgMevcutKitaplar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgMevcutKitaplar.Size = new Size(732, 462);
            dgMevcutKitaplar.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(236, 240, 241);
            tabPage3.Controls.Add(dgOkuyucular);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(20);
            tabPage3.Size = new Size(772, 502);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Okuyucular";
            // 
            // dgOkuyucular
            // 
            dgOkuyucular.AllowUserToAddRows = false;
            dgOkuyucular.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgOkuyucular.BackgroundColor = Color.White;
            dgOkuyucular.BorderStyle = BorderStyle.None;
            dgOkuyucular.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgOkuyucular.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgOkuyucular.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgOkuyucular.ColumnHeadersHeight = 40;
            dgOkuyucular.DefaultCellStyle = dataGridViewCellStyle2;
            dgOkuyucular.Dock = DockStyle.Fill;
            dgOkuyucular.EnableHeadersVisualStyles = false;
            dgOkuyucular.GridColor = Color.FromArgb(236, 240, 241);
            dgOkuyucular.Location = new Point(20, 20);
            dgOkuyucular.MultiSelect = false;
            dgOkuyucular.Name = "dgOkuyucular";
            dgOkuyucular.ReadOnly = true;
            dgOkuyucular.RowHeadersVisible = false;
            dgOkuyucular.RowTemplate.Height = 35;
            dgOkuyucular.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgOkuyucular.Size = new Size(732, 462);
            dgOkuyucular.TabIndex = 0;
            // 
            // AnaSayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 600);
            Controls.Add(tabKiralanmiş);
            Controls.Add(panelHeader);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AnaSayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnaSayfa";
            WindowState = FormWindowState.Maximized;
            Activated += AnaSayfa_Activated;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            tabKiralanmiş.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgEmanetler).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgMevcutKitaplar).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgOkuyucular).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btKiralama;
        private System.Windows.Forms.Button btOkuyucu;
        private System.Windows.Forms.Button btKitap;
        private System.Windows.Forms.Button btKapat;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.TabControl tabKiralanmiş;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgEmanetler;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgMevcutKitaplar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgOkuyucular;
    }
}