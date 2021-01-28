namespace kiralama
{
    partial class frmSözlesme
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSözlesme));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEhYer = new System.Windows.Forms.TextBox();
            this.txtEhTarih = new System.Windows.Forms.TextBox();
            this.txtEhliyet = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dateTeslim = new System.Windows.Forms.DateTimePicker();
            this.dateCikis = new System.Windows.Forms.DateTimePicker();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtGün = new System.Windows.Forms.TextBox();
            this.txtKiraUcret = new System.Windows.Forms.TextBox();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.comboKiralamaSekli = new System.Windows.Forms.ComboBox();
            this.comboArabalar = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTeslim = new System.Windows.Forms.Button();
            this.txtEkstra = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEhYer);
            this.groupBox1.Controls.Add(this.txtEhTarih);
            this.groupBox1.Controls.Add(this.txtEhliyet);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.txtTc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(43, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 280);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müsteri Bigileri ";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // txtEhYer
            // 
            this.txtEhYer.Location = new System.Drawing.Point(125, 216);
            this.txtEhYer.Name = "txtEhYer";
            this.txtEhYer.Size = new System.Drawing.Size(133, 22);
            this.txtEhYer.TabIndex = 11;
            // 
            // txtEhTarih
            // 
            this.txtEhTarih.Location = new System.Drawing.Point(125, 181);
            this.txtEhTarih.Name = "txtEhTarih";
            this.txtEhTarih.Size = new System.Drawing.Size(133, 22);
            this.txtEhTarih.TabIndex = 10;
            // 
            // txtEhliyet
            // 
            this.txtEhliyet.Location = new System.Drawing.Point(125, 146);
            this.txtEhliyet.Name = "txtEhliyet";
            this.txtEhliyet.Size = new System.Drawing.Size(133, 22);
            this.txtEhliyet.TabIndex = 9;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(125, 111);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(133, 22);
            this.txtTelefon.TabIndex = 8;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(125, 76);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(133, 22);
            this.txtAdSoyad.TabIndex = 7;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(125, 41);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(133, 22);
            this.txtTc.TabIndex = 6;
            this.txtTc.TextChanged += new System.EventHandler(this.TxtTc_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ehliyet Ver. Yer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ehliyet Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ehliyet No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTemizle);
            this.groupBox2.Controls.Add(this.btnHesapla);
            this.groupBox2.Controls.Add(this.btnGüncelle);
            this.groupBox2.Controls.Add(this.btnEkle);
            this.groupBox2.Controls.Add(this.dateTeslim);
            this.groupBox2.Controls.Add(this.dateCikis);
            this.groupBox2.Controls.Add(this.txtTutar);
            this.groupBox2.Controls.Add(this.txtGün);
            this.groupBox2.Controls.Add(this.txtKiraUcret);
            this.groupBox2.Controls.Add(this.txtRenk);
            this.groupBox2.Controls.Add(this.txtYil);
            this.groupBox2.Controls.Add(this.txtModel);
            this.groupBox2.Controls.Add(this.txtMarka);
            this.groupBox2.Controls.Add(this.comboKiralamaSekli);
            this.groupBox2.Controls.Add(this.comboArabalar);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(398, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(578, 271);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Araba Bilgileri";
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.White;
            this.btnTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemizle.ImageIndex = 3;
            this.btnTemizle.ImageList = this.ımageList1;
            this.btnTemizle.Location = new System.Drawing.Point(310, 222);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(96, 35);
            this.btnTemizle.TabIndex = 25;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.White;
            this.btnHesapla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHesapla.ImageIndex = 2;
            this.btnHesapla.ImageList = this.ımageList1;
            this.btnHesapla.Location = new System.Drawing.Point(458, 222);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(104, 35);
            this.btnHesapla.TabIndex = 24;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.BtnHesapla_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.White;
            this.btnGüncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGüncelle.ImageIndex = 1;
            this.btnGüncelle.ImageList = this.ımageList1;
            this.btnGüncelle.Location = new System.Drawing.Point(168, 220);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(99, 35);
            this.btnGüncelle.TabIndex = 23;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.White;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.ImageIndex = 0;
            this.btnEkle.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(42, 220);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(81, 35);
            this.btnEkle.TabIndex = 22;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // dateTeslim
            // 
            this.dateTeslim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTeslim.Location = new System.Drawing.Point(397, 194);
            this.dateTeslim.Name = "dateTeslim";
            this.dateTeslim.Size = new System.Drawing.Size(131, 22);
            this.dateTeslim.TabIndex = 21;
            // 
            // dateCikis
            // 
            this.dateCikis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCikis.Location = new System.Drawing.Point(397, 161);
            this.dateCikis.Name = "dateCikis";
            this.dateCikis.Size = new System.Drawing.Size(131, 22);
            this.dateCikis.TabIndex = 20;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(397, 128);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(131, 22);
            this.txtTutar.TabIndex = 19;
            // 
            // txtGün
            // 
            this.txtGün.Location = new System.Drawing.Point(397, 95);
            this.txtGün.Name = "txtGün";
            this.txtGün.Size = new System.Drawing.Size(131, 22);
            this.txtGün.TabIndex = 18;
            // 
            // txtKiraUcret
            // 
            this.txtKiraUcret.Location = new System.Drawing.Point(397, 62);
            this.txtKiraUcret.Name = "txtKiraUcret";
            this.txtKiraUcret.Size = new System.Drawing.Size(131, 22);
            this.txtKiraUcret.TabIndex = 17;
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(101, 164);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(146, 22);
            this.txtRenk.TabIndex = 16;
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(101, 132);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(146, 22);
            this.txtYil.TabIndex = 15;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(101, 100);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(146, 22);
            this.txtModel.TabIndex = 14;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(101, 68);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(146, 22);
            this.txtMarka.TabIndex = 13;
            // 
            // comboKiralamaSekli
            // 
            this.comboKiralamaSekli.FormattingEnabled = true;
            this.comboKiralamaSekli.Items.AddRange(new object[] {
            "Günlük",
            "Haftalık",
            "Aylık"});
            this.comboKiralamaSekli.Location = new System.Drawing.Point(397, 27);
            this.comboKiralamaSekli.Name = "comboKiralamaSekli";
            this.comboKiralamaSekli.Size = new System.Drawing.Size(131, 24);
            this.comboKiralamaSekli.TabIndex = 12;
            this.comboKiralamaSekli.SelectedIndexChanged += new System.EventHandler(this.ComboKiralamaSekli_SelectedIndexChanged);
            // 
            // comboArabalar
            // 
            this.comboArabalar.FormattingEnabled = true;
            this.comboArabalar.Location = new System.Drawing.Point(101, 34);
            this.comboArabalar.Name = "comboArabalar";
            this.comboArabalar.Size = new System.Drawing.Size(146, 24);
            this.comboArabalar.TabIndex = 11;
            this.comboArabalar.SelectedIndexChanged += new System.EventHandler(this.ComboArabalar_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(292, 200);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 17);
            this.label17.TabIndex = 10;
            this.label17.Text = "Teslim Tarihi";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(304, 166);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 17);
            this.label16.TabIndex = 9;
            this.label16.Text = "Çıkış Tarihi";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(339, 132);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 17);
            this.label15.TabIndex = 8;
            this.label15.Text = "Tutar";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(346, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 17);
            this.label14.TabIndex = 7;
            this.label14.Text = "Gün";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(307, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 17);
            this.label13.TabIndex = 6;
            this.label13.Text = "Kira Ücreti";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(284, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 17);
            this.label12.TabIndex = 5;
            this.label12.Text = "Kiralama Şekli";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Renk";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(57, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Yıl";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Model";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Marka";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Arabalar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 319);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(933, 286);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            // 
            // btnTeslim
            // 
            this.btnTeslim.BackColor = System.Drawing.Color.White;
            this.btnTeslim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeslim.ImageIndex = 4;
            this.btnTeslim.ImageList = this.ımageList1;
            this.btnTeslim.Location = new System.Drawing.Point(856, 611);
            this.btnTeslim.Name = "btnTeslim";
            this.btnTeslim.Size = new System.Drawing.Size(120, 35);
            this.btnTeslim.TabIndex = 23;
            this.btnTeslim.Text = "Araç Teslim";
            this.btnTeslim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTeslim.UseVisualStyleBackColor = false;
            this.btnTeslim.Click += new System.EventHandler(this.BtnTeslim_Click);
            // 
            // txtEkstra
            // 
            this.txtEkstra.Location = new System.Drawing.Point(685, 624);
            this.txtEkstra.Name = "txtEkstra";
            this.txtEkstra.Size = new System.Drawing.Size(133, 22);
            this.txtEkstra.TabIndex = 25;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(563, 627);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(102, 17);
            this.label18.TabIndex = 24;
            this.label18.Text = "Ekstra Ücretler";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "add-button.png");
            this.ımageList1.Images.SetKeyName(1, "uptade.png");
            this.ımageList1.Images.SetKeyName(2, "hesapla1.png");
            this.ımageList1.Images.SetKeyName(3, "temizle.png");
            this.ımageList1.Images.SetKeyName(4, "car_2-add-512.png");
            // 
            // frmSözlesme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(999, 660);
            this.Controls.Add(this.txtEkstra);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnTeslim);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSözlesme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sözlesme";
            this.Load += new System.EventHandler(this.FrmSözlesme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtEhYer;
        private System.Windows.Forms.TextBox txtEhTarih;
        private System.Windows.Forms.TextBox txtEhliyet;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DateTimePicker dateTeslim;
        private System.Windows.Forms.DateTimePicker dateCikis;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtGün;
        private System.Windows.Forms.TextBox txtKiraUcret;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.ComboBox comboKiralamaSekli;
        private System.Windows.Forms.ComboBox comboArabalar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTeslim;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.TextBox txtEkstra;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ImageList ımageList1;
    }
}