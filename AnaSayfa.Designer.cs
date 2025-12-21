namespace Kutupoto
{
    partial class AnaSayfa
    {
        private System.ComponentModel.IContainer components = null;

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
            System.Windows.Forms.DataGridViewCellStyle gridStyleHeader = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle gridStyleRow = new System.Windows.Forms.DataGridViewCellStyle();

            this.panelMenu = new System.Windows.Forms.Panel();
            this.btKapat = new System.Windows.Forms.Button();
            this.btKitap = new System.Windows.Forms.Button();
            this.btOkuyucu = new System.Windows.Forms.Button();
            this.btKiralama = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.tabKiralanmiş = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgEmanetler = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgMevcutKitaplar = new System.Windows.Forms.DataGridView();
            // FİLTRE PANELİ BAŞLANGIÇ
            this.panelFiltre = new System.Windows.Forms.Panel();
            this.labelAra = new System.Windows.Forms.Label();
            this.txtKitapAra = new System.Windows.Forms.TextBox();
            this.labelTur = new System.Windows.Forms.Label();
            this.cmbTurFiltre = new System.Windows.Forms.ComboBox();
            // FİLTRE PANELİ BİTİŞ
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgOkuyucular = new System.Windows.Forms.DataGridView();

            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.tabKiralanmiş.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmanetler)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panelFiltre.SuspendLayout(); // Panel Eklendi
            ((System.ComponentModel.ISupportInitialize)(this.dgMevcutKitaplar)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOkuyucular)).BeginInit();
            this.SuspendLayout();

            // GRID STYLES
            gridStyleHeader.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            gridStyleHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            gridStyleHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            gridStyleHeader.ForeColor = System.Drawing.Color.White;
            gridStyleHeader.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            gridStyleHeader.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            gridStyleHeader.WrapMode = System.Windows.Forms.DataGridViewTriState.True;

            gridStyleRow.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            gridStyleRow.BackColor = System.Drawing.Color.White;
            gridStyleRow.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            gridStyleRow.ForeColor = System.Drawing.Color.Black;
            gridStyleRow.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            gridStyleRow.SelectionForeColor = System.Drawing.Color.White;
            gridStyleRow.WrapMode = System.Windows.Forms.DataGridViewTriState.False;

            // panelMenu
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelMenu.Controls.Add(this.btKapat);
            this.panelMenu.Controls.Add(this.btKitap);
            this.panelMenu.Controls.Add(this.btOkuyucu);
            this.panelMenu.Controls.Add(this.btKiralama);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 600);
            this.panelMenu.TabIndex = 0;

            // panelLogo
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(46)))), ((int)(((byte)(60)))));
            this.panelLogo.Controls.Add(this.lblLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;

            // lblLogo
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(0, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(220, 80);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "KÜTÜPHANE\r\nPANELİ";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Butonlar
            this.btKiralama.Dock = System.Windows.Forms.DockStyle.Top;
            this.btKiralama.FlatAppearance.BorderSize = 0;
            this.btKiralama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btKiralama.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btKiralama.ForeColor = System.Drawing.Color.Gainsboro;
            this.btKiralama.Location = new System.Drawing.Point(0, 80);
            this.btKiralama.Name = "btKiralama";
            this.btKiralama.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btKiralama.Size = new System.Drawing.Size(220, 60);
            this.btKiralama.TabIndex = 1;
            this.btKiralama.Text = "🔄  Kiralama İşlemleri";
            this.btKiralama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btKiralama.UseVisualStyleBackColor = true;
            this.btKiralama.Click += new System.EventHandler(this.btKiralama_Click);

            this.btOkuyucu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btOkuyucu.FlatAppearance.BorderSize = 0;
            this.btOkuyucu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOkuyucu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btOkuyucu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btOkuyucu.Location = new System.Drawing.Point(0, 140);
            this.btOkuyucu.Name = "btOkuyucu";
            this.btOkuyucu.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btOkuyucu.Size = new System.Drawing.Size(220, 60);
            this.btOkuyucu.TabIndex = 2;
            this.btOkuyucu.Text = "👥  Okuyucu Ekle";
            this.btOkuyucu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btOkuyucu.UseVisualStyleBackColor = true;
            this.btOkuyucu.Click += new System.EventHandler(this.btOkuyucu_Click);

            this.btKitap.Dock = System.Windows.Forms.DockStyle.Top;
            this.btKitap.FlatAppearance.BorderSize = 0;
            this.btKitap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btKitap.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btKitap.ForeColor = System.Drawing.Color.Gainsboro;
            this.btKitap.Location = new System.Drawing.Point(0, 200);
            this.btKitap.Name = "btKitap";
            this.btKitap.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btKitap.Size = new System.Drawing.Size(220, 60);
            this.btKitap.TabIndex = 3;
            this.btKitap.Text = "📚  Kitap Ekle";
            this.btKitap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btKitap.UseVisualStyleBackColor = true;
            this.btKitap.Click += new System.EventHandler(this.btKitap_Click);

            this.btKapat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btKapat.FlatAppearance.BorderSize = 0;
            this.btKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btKapat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btKapat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btKapat.Location = new System.Drawing.Point(0, 540);
            this.btKapat.Name = "btKapat";
            this.btKapat.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btKapat.Size = new System.Drawing.Size(220, 60);
            this.btKapat.TabIndex = 4;
            this.btKapat.Text = "🚪  Çıkış Yap";
            this.btKapat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btKapat.UseVisualStyleBackColor = true;
            this.btKapat.Click += new System.EventHandler(this.btKapat_Click);

            // panelHeader
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.lblBaslik);
            this.panelHeader.Controls.Add(this.btnCikis);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(220, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(780, 60);
            this.panelHeader.TabIndex = 1;

            // lblBaslik
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBaslik.ForeColor = System.Drawing.Color.Black;
            this.lblBaslik.Location = new System.Drawing.Point(20, 18);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(221, 25);
            this.lblBaslik.TabIndex = 1;
            this.lblBaslik.Text = "Hızlı Bakış ve İstatistikler";

            // btnCikis
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCikis.Location = new System.Drawing.Point(720, 0);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(60, 60);
            this.btnCikis.TabIndex = 0;
            this.btnCikis.Text = "X";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);

            // tabKiralanmiş
            this.tabKiralanmiş.Controls.Add(this.tabPage1);
            this.tabKiralanmiş.Controls.Add(this.tabPage2);
            this.tabKiralanmiş.Controls.Add(this.tabPage3);
            this.tabKiralanmiş.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabKiralanmiş.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabKiralanmiş.ItemSize = new System.Drawing.Size(120, 30);
            this.tabKiralanmiş.Location = new System.Drawing.Point(220, 60);
            this.tabKiralanmiş.Name = "tabKiralanmiş";
            this.tabKiralanmiş.Padding = new System.Drawing.Point(20, 5);
            this.tabKiralanmiş.SelectedIndex = 0;
            this.tabKiralanmiş.Size = new System.Drawing.Size(780, 540);
            this.tabKiralanmiş.TabIndex = 2;

            // tabPage1
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.tabPage1.Controls.Add(this.dgEmanetler);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(20);
            this.tabPage1.Size = new System.Drawing.Size(772, 502);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kiralanan Kitaplar";

            // dgEmanetler
            this.dgEmanetler.AllowUserToAddRows = false;
            this.dgEmanetler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEmanetler.BackgroundColor = System.Drawing.Color.White;
            this.dgEmanetler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgEmanetler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgEmanetler.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgEmanetler.ColumnHeadersDefaultCellStyle = gridStyleHeader;
            this.dgEmanetler.ColumnHeadersHeight = 40;
            this.dgEmanetler.DefaultCellStyle = gridStyleRow;
            this.dgEmanetler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgEmanetler.EnableHeadersVisualStyles = false;
            this.dgEmanetler.Location = new System.Drawing.Point(20, 20);
            this.dgEmanetler.MultiSelect = false;
            this.dgEmanetler.Name = "dgEmanetler";
            this.dgEmanetler.ReadOnly = true;
            this.dgEmanetler.RowHeadersVisible = false;
            this.dgEmanetler.RowTemplate.Height = 35;
            this.dgEmanetler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEmanetler.Size = new System.Drawing.Size(732, 462);
            this.dgEmanetler.TabIndex = 0;

            // 
            // tabPage2 (MEVCUT KİTAPLAR + FİLTRE)
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.tabPage2.Controls.Add(this.dgMevcutKitaplar); // Önce Grid Eklenir (Fill)
            this.tabPage2.Controls.Add(this.panelFiltre);     // Sonra Panel Eklenir (Top)
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(20);
            this.tabPage2.Size = new System.Drawing.Size(772, 502);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mevcut Kitaplar";

            // 
            // panelFiltre (YENİ EKLENEN KISIM)
            // 
            this.panelFiltre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.panelFiltre.Controls.Add(this.cmbTurFiltre);
            this.panelFiltre.Controls.Add(this.labelTur);
            this.panelFiltre.Controls.Add(this.txtKitapAra);
            this.panelFiltre.Controls.Add(this.labelAra);
            this.panelFiltre.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltre.Location = new System.Drawing.Point(20, 20);
            this.panelFiltre.Name = "panelFiltre";
            this.panelFiltre.Size = new System.Drawing.Size(732, 60);
            this.panelFiltre.TabIndex = 1;

            // labelAra
            this.labelAra.AutoSize = true;
            this.labelAra.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.labelAra.Location = new System.Drawing.Point(15, 20);
            this.labelAra.Name = "labelAra";
            this.labelAra.Size = new System.Drawing.Size(89, 17);
            this.labelAra.TabIndex = 0;
            this.labelAra.Text = "🔍 Kitap Ara:";

            // txtKitapAra
            this.txtKitapAra.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKitapAra.Location = new System.Drawing.Point(110, 17);
            this.txtKitapAra.Name = "txtKitapAra";
            this.txtKitapAra.PlaceholderText = "Kitap Adı, Yazar veya Barkod...";
            this.txtKitapAra.Size = new System.Drawing.Size(250, 25);
            this.txtKitapAra.TabIndex = 1;
            this.txtKitapAra.TextChanged += new System.EventHandler(this.txtKitapAra_TextChanged);

            // labelTur
            this.labelTur.AutoSize = true;
            this.labelTur.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.labelTur.Location = new System.Drawing.Point(390, 20);
            this.labelTur.Name = "labelTur";
            this.labelTur.Size = new System.Drawing.Size(76, 17);
            this.labelTur.TabIndex = 2;
            this.labelTur.Text = "📂 Tür Seç:";

            // cmbTurFiltre
            this.cmbTurFiltre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurFiltre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbTurFiltre.FormattingEnabled = true;
            this.cmbTurFiltre.Location = new System.Drawing.Point(470, 17);
            this.cmbTurFiltre.Name = "cmbTurFiltre";
            this.cmbTurFiltre.Size = new System.Drawing.Size(180, 25);
            this.cmbTurFiltre.TabIndex = 3;
            this.cmbTurFiltre.SelectedIndexChanged += new System.EventHandler(this.cmbTurFiltre_SelectedIndexChanged);

            // dgMevcutKitaplar
            this.dgMevcutKitaplar.AllowUserToAddRows = false;
            this.dgMevcutKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMevcutKitaplar.BackgroundColor = System.Drawing.Color.White;
            this.dgMevcutKitaplar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgMevcutKitaplar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgMevcutKitaplar.ColumnHeadersDefaultCellStyle = gridStyleHeader;
            this.dgMevcutKitaplar.ColumnHeadersHeight = 40;
            this.dgMevcutKitaplar.DefaultCellStyle = gridStyleRow;
            this.dgMevcutKitaplar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMevcutKitaplar.EnableHeadersVisualStyles = false;
            this.dgMevcutKitaplar.Location = new System.Drawing.Point(20, 80); // Üstten 20+60 boşluk
            this.dgMevcutKitaplar.MultiSelect = false;
            this.dgMevcutKitaplar.Name = "dgMevcutKitaplar";
            this.dgMevcutKitaplar.ReadOnly = true;
            this.dgMevcutKitaplar.RowHeadersVisible = false;
            this.dgMevcutKitaplar.RowTemplate.Height = 35;
            this.dgMevcutKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMevcutKitaplar.Size = new System.Drawing.Size(732, 402);
            this.dgMevcutKitaplar.TabIndex = 0;

            // tabPage3
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.tabPage3.Controls.Add(this.dgOkuyucular);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(20);
            this.tabPage3.Size = new System.Drawing.Size(772, 502);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Okuyucular";

            // dgOkuyucular
            this.dgOkuyucular.AllowUserToAddRows = false;
            this.dgOkuyucular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgOkuyucular.BackgroundColor = System.Drawing.Color.White;
            this.dgOkuyucular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgOkuyucular.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgOkuyucular.ColumnHeadersDefaultCellStyle = gridStyleHeader;
            this.dgOkuyucular.ColumnHeadersHeight = 40;
            this.dgOkuyucular.DefaultCellStyle = gridStyleRow;
            this.dgOkuyucular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOkuyucular.EnableHeadersVisualStyles = false;
            this.dgOkuyucular.Location = new System.Drawing.Point(20, 20);
            this.dgOkuyucular.MultiSelect = false;
            this.dgOkuyucular.Name = "dgOkuyucular";
            this.dgOkuyucular.ReadOnly = true;
            this.dgOkuyucular.RowHeadersVisible = false;
            this.dgOkuyucular.RowTemplate.Height = 35;
            this.dgOkuyucular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOkuyucular.Size = new System.Drawing.Size(732, 462);
            this.dgOkuyucular.TabIndex = 0;

            // AnaSayfa
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.tabKiralanmiş);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaSayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.AnaSayfa_Activated);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tabKiralanmiş.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmanetler)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panelFiltre.ResumeLayout(false);
            this.panelFiltre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMevcutKitaplar)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOkuyucular)).EndInit();
            this.ResumeLayout(false);
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

        // FİLTRELEME İÇİN EKLENEN KISIMLAR
        private System.Windows.Forms.Panel panelFiltre;
        private System.Windows.Forms.Label labelAra;
        private System.Windows.Forms.TextBox txtKitapAra;
        private System.Windows.Forms.Label labelTur;
        private System.Windows.Forms.ComboBox cmbTurFiltre;
    }
}