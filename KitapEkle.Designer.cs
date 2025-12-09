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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapEkle));
            tableLayoutPanel = new TableLayoutPanel();
            label9 = new Label();
            label1 = new Label();
            label8 = new Label();
            label2 = new Label();
            label7 = new Label();
            label3 = new Label();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtKayitNo = new TextBox();
            txtKitapAdi = new TextBox();
            txtYazar = new TextBox();
            txtSayfa = new TextBox();
            txtTur = new TextBox();
            txtYayinevi = new TextBox();
            txtBasimYili = new TextBox();
            txtDolapNo = new TextBox();
            txtRafNo = new TextBox();
            btnKaydet = new Button();
            btnTemizle = new Button();
            btnSil = new Button();
            dg = new DataGridView();
            label10 = new Label();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.Anchor = AnchorStyles.None;
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Controls.Add(label9, 0, 8);
            tableLayoutPanel.Controls.Add(label1, 0, 0);
            tableLayoutPanel.Controls.Add(label8, 0, 7);
            tableLayoutPanel.Controls.Add(label2, 0, 1);
            tableLayoutPanel.Controls.Add(label7, 0, 6);
            tableLayoutPanel.Controls.Add(label3, 0, 2);
            tableLayoutPanel.Controls.Add(label6, 0, 5);
            tableLayoutPanel.Controls.Add(label4, 0, 3);
            tableLayoutPanel.Controls.Add(label5, 0, 4);
            tableLayoutPanel.Controls.Add(txtKayitNo, 1, 0);
            tableLayoutPanel.Controls.Add(txtKitapAdi, 1, 1);
            tableLayoutPanel.Controls.Add(txtYazar, 1, 2);
            tableLayoutPanel.Controls.Add(txtSayfa, 1, 3);
            tableLayoutPanel.Controls.Add(txtTur, 1, 4);
            tableLayoutPanel.Controls.Add(txtYayinevi, 1, 5);
            tableLayoutPanel.Controls.Add(txtBasimYili, 1, 6);
            tableLayoutPanel.Controls.Add(txtDolapNo, 1, 7);
            tableLayoutPanel.Controls.Add(txtRafNo, 1, 8);
            tableLayoutPanel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel.Location = new Point(12, 52);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 9;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel.Size = new Size(271, 362);
            tableLayoutPanel.TabIndex = 0;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(3, 332);
            label9.Name = "label9";
            label9.Size = new Size(90, 17);
            label9.TabIndex = 9;
            label9.Text = "Raf Numarası:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(99, 17);
            label1.TabIndex = 1;
            label1.Text = "Kayıt Numarası:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(3, 291);
            label8.Name = "label8";
            label8.Size = new Size(106, 17);
            label8.TabIndex = 8;
            label8.Text = "Dolap Numarası:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 51);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 2;
            label2.Text = "Kitap Adı:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(3, 251);
            label7.Name = "label7";
            label7.Size = new Size(65, 17);
            label7.TabIndex = 7;
            label7.Text = "Basım Yılı:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 91);
            label3.Name = "label3";
            label3.Size = new Size(65, 17);
            label3.TabIndex = 3;
            label3.Text = "Yazar Adı:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(3, 211);
            label6.Name = "label6";
            label6.Size = new Size(56, 17);
            label6.TabIndex = 6;
            label6.Text = "Yayınevi:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 131);
            label4.Name = "label4";
            label4.Size = new Size(78, 17);
            label4.TabIndex = 4;
            label4.Text = "Sayfa Sayısı:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(3, 171);
            label5.Name = "label5";
            label5.Size = new Size(71, 17);
            label5.TabIndex = 5;
            label5.Text = "Kitap Türü:";
            // 
            // txtKayitNo
            // 
            txtKayitNo.Anchor = AnchorStyles.None;
            txtKayitNo.Location = new Point(140, 7);
            txtKayitNo.Name = "txtKayitNo";
            txtKayitNo.Size = new Size(126, 25);
            txtKayitNo.TabIndex = 10;
            // 
            // txtKitapAdi
            // 
            txtKitapAdi.Anchor = AnchorStyles.None;
            txtKitapAdi.Location = new Point(140, 47);
            txtKitapAdi.Name = "txtKitapAdi";
            txtKitapAdi.Size = new Size(126, 25);
            txtKitapAdi.TabIndex = 11;
            // 
            // txtYazar
            // 
            txtYazar.Anchor = AnchorStyles.None;
            txtYazar.Location = new Point(140, 87);
            txtYazar.Name = "txtYazar";
            txtYazar.Size = new Size(126, 25);
            txtYazar.TabIndex = 12;
            // 
            // txtSayfa
            // 
            txtSayfa.Anchor = AnchorStyles.None;
            txtSayfa.Location = new Point(140, 127);
            txtSayfa.Name = "txtSayfa";
            txtSayfa.Size = new Size(126, 25);
            txtSayfa.TabIndex = 13;
            // 
            // txtTur
            // 
            txtTur.Anchor = AnchorStyles.None;
            txtTur.Location = new Point(140, 167);
            txtTur.Name = "txtTur";
            txtTur.Size = new Size(126, 25);
            txtTur.TabIndex = 14;
            // 
            // txtYayinevi
            // 
            txtYayinevi.Anchor = AnchorStyles.None;
            txtYayinevi.Location = new Point(140, 207);
            txtYayinevi.Name = "txtYayinevi";
            txtYayinevi.Size = new Size(126, 25);
            txtYayinevi.TabIndex = 15;
            // 
            // txtBasimYili
            // 
            txtBasimYili.Anchor = AnchorStyles.None;
            txtBasimYili.Location = new Point(140, 247);
            txtBasimYili.Name = "txtBasimYili";
            txtBasimYili.Size = new Size(126, 25);
            txtBasimYili.TabIndex = 16;
            // 
            // txtDolapNo
            // 
            txtDolapNo.Anchor = AnchorStyles.None;
            txtDolapNo.Location = new Point(140, 287);
            txtDolapNo.Name = "txtDolapNo";
            txtDolapNo.Size = new Size(126, 25);
            txtDolapNo.TabIndex = 17;
            // 
            // txtRafNo
            // 
            txtRafNo.Anchor = AnchorStyles.None;
            txtRafNo.Location = new Point(140, 328);
            txtRafNo.Name = "txtRafNo";
            txtRafNo.Size = new Size(126, 25);
            txtRafNo.TabIndex = 18;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(15, 421);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(88, 42);
            btnKaydet.TabIndex = 1;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(198, 421);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(80, 42);
            btnTemizle.TabIndex = 2;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(109, 421);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(83, 42);
            btnSil.TabIndex = 3;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // dg
            // 
            dg.AllowUserToAddRows = false;
            dg.AllowUserToOrderColumns = true;
            dg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg.Location = new Point(289, 52);
            dg.MultiSelect = false;
            dg.Name = "dg";
            dg.ReadOnly = true;
            dg.RowHeadersVisible = false;
            dg.RowTemplate.Height = 25;
            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg.Size = new Size(490, 410);
            dg.TabIndex = 4;
            dg.CellClick += dg_CellClick;
            dg.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(12, 9);
            label10.Name = "label10";
            label10.Size = new Size(171, 40);
            label10.TabIndex = 5;
            label10.Text = "KİTAP KAYIT";
            label10.Click += label10_Click;
            // 
            // KitapEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(791, 475);
            Controls.Add(label10);
            Controls.Add(dg);
            Controls.Add(btnSil);
            Controls.Add(btnTemizle);
            Controls.Add(btnKaydet);
            Controls.Add(tableLayoutPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "KitapEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KitapEkle";
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private Label label9;
        private Label label1;
        private Label label8;
        private Label label2;
        private Label label7;
        private Label label3;
        private Label label6;
        private Label label4;
        private Label label5;
        private TextBox txtKayitNo;
        private TextBox txtKitapAdi;
        private TextBox txtYazar;
        private TextBox txtSayfa;
        private TextBox txtTur;
        private TextBox txtYayinevi;
        private TextBox txtBasimYili;
        private TextBox txtDolapNo;
        private TextBox txtRafNo;
        private Button btnKaydet;
        private Button btnTemizle;
        private Button btnSil;
        private DataGridView dg;
        private Label label10;
    }
}