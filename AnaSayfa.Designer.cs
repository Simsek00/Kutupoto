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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            btKiralama = new Button();
            btOkuyucu = new Button();
            btKitap = new Button();
            btKapat = new Button();
            tabKiralanmiş = new TabControl();
            tabPage1 = new TabPage();
            dgEmanetler = new DataGridView();
            tabPage2 = new TabPage();
            dgMevcutKitaplar = new DataGridView();
            tabPage3 = new TabPage();
            dgOkuyucular = new DataGridView();
            tabKiralanmiş.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgEmanetler).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgMevcutKitaplar).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgOkuyucular).BeginInit();
            SuspendLayout();
            // 
            // btKiralama
            // 
            btKiralama.BackColor = Color.LightYellow;
            btKiralama.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btKiralama.Image = (Image)resources.GetObject("btKiralama.Image");
            btKiralama.Location = new Point(12, 12);
            btKiralama.Name = "btKiralama";
            btKiralama.Size = new Size(140, 99);
            btKiralama.TabIndex = 0;
            btKiralama.Text = "Kiralama İşlemleri";
            btKiralama.TextAlign = ContentAlignment.BottomCenter;
            btKiralama.UseVisualStyleBackColor = false;
            btKiralama.Click += btKiralama_Click;
            // 
            // btOkuyucu
            // 
            btOkuyucu.BackColor = Color.LightYellow;
            btOkuyucu.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btOkuyucu.Image = (Image)resources.GetObject("btOkuyucu.Image");
            btOkuyucu.Location = new Point(169, 12);
            btOkuyucu.Name = "btOkuyucu";
            btOkuyucu.Size = new Size(140, 99);
            btOkuyucu.TabIndex = 1;
            btOkuyucu.Text = "Okuyucu Ekle";
            btOkuyucu.TextAlign = ContentAlignment.BottomCenter;
            btOkuyucu.UseVisualStyleBackColor = false;
            btOkuyucu.Click += btOkuyucu_Click;
            // 
            // btKitap
            // 
            btKitap.BackColor = Color.LightYellow;
            btKitap.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btKitap.Image = (Image)resources.GetObject("btKitap.Image");
            btKitap.Location = new Point(327, 12);
            btKitap.Name = "btKitap";
            btKitap.Size = new Size(140, 99);
            btKitap.TabIndex = 2;
            btKitap.Text = "Kitap Ekle";
            btKitap.TextAlign = ContentAlignment.BottomCenter;
            btKitap.UseVisualStyleBackColor = false;
            btKitap.Click += btKitap_Click;
            // 
            // btKapat
            // 
            btKapat.BackColor = Color.LightYellow;
            btKapat.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btKapat.Image = (Image)resources.GetObject("btKapat.Image");
            btKapat.Location = new Point(687, 366);
            btKapat.Name = "btKapat";
            btKapat.Size = new Size(140, 99);
            btKapat.TabIndex = 3;
            btKapat.Text = "Uygulamayı Kapat";
            btKapat.TextAlign = ContentAlignment.BottomCenter;
            btKapat.UseVisualStyleBackColor = false;
            btKapat.Click += btKapat_Click;
            // 
            // tabKiralanmiş
            // 
            tabKiralanmiş.Controls.Add(tabPage1);
            tabKiralanmiş.Controls.Add(tabPage2);
            tabKiralanmiş.Controls.Add(tabPage3);
            tabKiralanmiş.Location = new Point(12, 127);
            tabKiralanmiş.Name = "tabKiralanmiş";
            tabKiralanmiş.SelectedIndex = 0;
            tabKiralanmiş.Size = new Size(615, 345);
            tabKiralanmiş.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgEmanetler);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(607, 317);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Kiralanan Kitaplar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgEmanetler
            // 
            dgEmanetler.AllowUserToAddRows = false;
            dgEmanetler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgEmanetler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgEmanetler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEmanetler.Location = new Point(3, 3);
            dgEmanetler.MultiSelect = false;
            dgEmanetler.Name = "dgEmanetler";
            dgEmanetler.ReadOnly = true;
            dgEmanetler.RowHeadersVisible = false;
            dgEmanetler.RowTemplate.Height = 25;
            dgEmanetler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgEmanetler.Size = new Size(598, 311);
            dgEmanetler.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgMevcutKitaplar);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(607, 317);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mevcut Kitaplar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgMevcutKitaplar
            // 
            dgMevcutKitaplar.AllowUserToAddRows = false;
            dgMevcutKitaplar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgMevcutKitaplar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgMevcutKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMevcutKitaplar.Location = new Point(3, 3);
            dgMevcutKitaplar.MultiSelect = false;
            dgMevcutKitaplar.Name = "dgMevcutKitaplar";
            dgMevcutKitaplar.ReadOnly = true;
            dgMevcutKitaplar.RowHeadersVisible = false;
            dgMevcutKitaplar.RowTemplate.Height = 25;
            dgMevcutKitaplar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgMevcutKitaplar.Size = new Size(598, 311);
            dgMevcutKitaplar.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgOkuyucular);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(607, 317);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Okuyucular";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgOkuyucular
            // 
            dgOkuyucular.AllowUserToAddRows = false;
            dgOkuyucular.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgOkuyucular.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgOkuyucular.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgOkuyucular.Location = new Point(3, 3);
            dgOkuyucular.MultiSelect = false;
            dgOkuyucular.Name = "dgOkuyucular";
            dgOkuyucular.ReadOnly = true;
            dgOkuyucular.RowHeadersVisible = false;
            dgOkuyucular.RowTemplate.Height = 25;
            dgOkuyucular.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgOkuyucular.Size = new Size(598, 311);
            dgOkuyucular.TabIndex = 0;
            // 
            // AnaSayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(839, 484);
            Controls.Add(tabKiralanmiş);
            Controls.Add(btKapat);
            Controls.Add(btKitap);
            Controls.Add(btOkuyucu);
            Controls.Add(btKiralama);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AnaSayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnaSayfa";
            Activated += AnaSayfa_Activated;
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

        private Button btKiralama;
        private Button btOkuyucu;
        private Button btKitap;
        private Button btKapat;
        private TabControl tabKiralanmiş;
        private TabPage tabPage1;
        private DataGridView dgEmanetler;
        private TabPage tabPage2;
        private DataGridView dgMevcutKitaplar;
        private TabPage tabPage3;
        private DataGridView dgOkuyucular;
    }
}