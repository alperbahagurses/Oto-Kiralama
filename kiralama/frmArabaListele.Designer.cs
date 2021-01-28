namespace kiralama
{
    partial class frmArabaListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArabaListele));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboArabalar = new System.Windows.Forms.ComboBox();
            this.btnResimEkle = new System.Windows.Forms.Button();
            this.btnArabaIptal = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Ucrettxt = new System.Windows.Forms.TextBox();
            this.Yakitcombo = new System.Windows.Forms.ComboBox();
            this.Kmtxt = new System.Windows.Forms.TextBox();
            this.Renktxt = new System.Windows.Forms.TextBox();
            this.Yiltxt = new System.Windows.Forms.TextBox();
            this.Modelcombo = new System.Windows.Forms.ComboBox();
            this.Markacombo = new System.Windows.Forms.ComboBox();
            this.Plakatxt = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(320, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(672, 468);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            // 
            // comboArabalar
            // 
            this.comboArabalar.FormattingEnabled = true;
            this.comboArabalar.Items.AddRange(new object[] {
            "Tüm Arabalar",
            "Boş Arabalar",
            "Dolu Arabalar"});
            this.comboArabalar.Location = new System.Drawing.Point(808, 35);
            this.comboArabalar.Name = "comboArabalar";
            this.comboArabalar.Size = new System.Drawing.Size(184, 24);
            this.comboArabalar.TabIndex = 1;
            this.comboArabalar.SelectedIndexChanged += new System.EventHandler(this.ComboArabalar_SelectedIndexChanged);
            // 
            // btnResimEkle
            // 
            this.btnResimEkle.BackColor = System.Drawing.Color.White;
            this.btnResimEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResimEkle.ImageIndex = 2;
            this.btnResimEkle.ImageList = this.ımageList1;
            this.btnResimEkle.Location = new System.Drawing.Point(15, 394);
            this.btnResimEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnResimEkle.Name = "btnResimEkle";
            this.btnResimEkle.Size = new System.Drawing.Size(88, 37);
            this.btnResimEkle.TabIndex = 39;
            this.btnResimEkle.Text = "Değiştir";
            this.btnResimEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResimEkle.UseVisualStyleBackColor = false;
            this.btnResimEkle.Click += new System.EventHandler(this.BtnResimEkle_Click);
            // 
            // btnArabaIptal
            // 
            this.btnArabaIptal.BackColor = System.Drawing.Color.White;
            this.btnArabaIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArabaIptal.ImageIndex = 1;
            this.btnArabaIptal.ImageList = this.ımageList1;
            this.btnArabaIptal.Location = new System.Drawing.Point(196, 494);
            this.btnArabaIptal.Margin = new System.Windows.Forms.Padding(4);
            this.btnArabaIptal.Name = "btnArabaIptal";
            this.btnArabaIptal.Size = new System.Drawing.Size(100, 39);
            this.btnArabaIptal.TabIndex = 38;
            this.btnArabaIptal.Text = "İptal";
            this.btnArabaIptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnArabaIptal.UseVisualStyleBackColor = false;
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.White;
            this.btnGüncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGüncelle.ImageIndex = 0;
            this.btnGüncelle.ImageList = this.ımageList1;
            this.btnGüncelle.Location = new System.Drawing.Point(51, 494);
            this.btnGüncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(96, 39);
            this.btnGüncelle.TabIndex = 37;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 305);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Günlük Ücret";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 272);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Yakıt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 239);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Km";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 206);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Renk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Yıl";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Marka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Plaka";
            // 
            // Ucrettxt
            // 
            this.Ucrettxt.Location = new System.Drawing.Point(136, 302);
            this.Ucrettxt.Margin = new System.Windows.Forms.Padding(4);
            this.Ucrettxt.Name = "Ucrettxt";
            this.Ucrettxt.Size = new System.Drawing.Size(160, 22);
            this.Ucrettxt.TabIndex = 27;
            // 
            // Yakitcombo
            // 
            this.Yakitcombo.FormattingEnabled = true;
            this.Yakitcombo.Items.AddRange(new object[] {
            "Benzin",
            "Dizel",
            "Benzin/LPG"});
            this.Yakitcombo.Location = new System.Drawing.Point(136, 267);
            this.Yakitcombo.Margin = new System.Windows.Forms.Padding(4);
            this.Yakitcombo.Name = "Yakitcombo";
            this.Yakitcombo.Size = new System.Drawing.Size(160, 24);
            this.Yakitcombo.TabIndex = 26;
            // 
            // Kmtxt
            // 
            this.Kmtxt.Location = new System.Drawing.Point(136, 234);
            this.Kmtxt.Margin = new System.Windows.Forms.Padding(4);
            this.Kmtxt.Name = "Kmtxt";
            this.Kmtxt.Size = new System.Drawing.Size(160, 22);
            this.Kmtxt.TabIndex = 25;
            // 
            // Renktxt
            // 
            this.Renktxt.Location = new System.Drawing.Point(136, 201);
            this.Renktxt.Margin = new System.Windows.Forms.Padding(4);
            this.Renktxt.Name = "Renktxt";
            this.Renktxt.Size = new System.Drawing.Size(160, 22);
            this.Renktxt.TabIndex = 24;
            // 
            // Yiltxt
            // 
            this.Yiltxt.Location = new System.Drawing.Point(136, 167);
            this.Yiltxt.Margin = new System.Windows.Forms.Padding(4);
            this.Yiltxt.Name = "Yiltxt";
            this.Yiltxt.Size = new System.Drawing.Size(160, 22);
            this.Yiltxt.TabIndex = 23;
            // 
            // Modelcombo
            // 
            this.Modelcombo.FormattingEnabled = true;
            this.Modelcombo.Location = new System.Drawing.Point(136, 133);
            this.Modelcombo.Margin = new System.Windows.Forms.Padding(4);
            this.Modelcombo.Name = "Modelcombo";
            this.Modelcombo.Size = new System.Drawing.Size(160, 24);
            this.Modelcombo.TabIndex = 22;
            // 
            // Markacombo
            // 
            this.Markacombo.FormattingEnabled = true;
            this.Markacombo.Items.AddRange(new object[] {
            "BMW",
            "Fiat",
            "Ford",
            "Honda",
            "Hyundai",
            "Mercedes - Benz",
            "Peugeot",
            "Renault ",
            "Toyota",
            "Volkswagen "});
            this.Markacombo.Location = new System.Drawing.Point(136, 98);
            this.Markacombo.Margin = new System.Windows.Forms.Padding(4);
            this.Markacombo.Name = "Markacombo";
            this.Markacombo.Size = new System.Drawing.Size(160, 24);
            this.Markacombo.TabIndex = 21;
            this.Markacombo.SelectedIndexChanged += new System.EventHandler(this.Markacombo_SelectedIndexChanged);
            // 
            // Plakatxt
            // 
            this.Plakatxt.Location = new System.Drawing.Point(136, 65);
            this.Plakatxt.Margin = new System.Windows.Forms.Padding(4);
            this.Plakatxt.Name = "Plakatxt";
            this.Plakatxt.Size = new System.Drawing.Size(160, 22);
            this.Plakatxt.TabIndex = 20;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.White;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.ImageIndex = 3;
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(999, 75);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(79, 39);
            this.btnSil.TabIndex = 40;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(119, 332);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "uptade.png");
            this.ımageList1.Images.SetKeyName(1, "delete-button.jpg");
            this.ımageList1.Images.SetKeyName(2, "degistir.png");
            this.ımageList1.Images.SetKeyName(3, "delete.jpg");
            // 
            // frmArabaListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1091, 565);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnResimEkle);
            this.Controls.Add(this.btnArabaIptal);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ucrettxt);
            this.Controls.Add(this.Yakitcombo);
            this.Controls.Add(this.Kmtxt);
            this.Controls.Add(this.Renktxt);
            this.Controls.Add(this.Yiltxt);
            this.Controls.Add(this.Modelcombo);
            this.Controls.Add(this.Markacombo);
            this.Controls.Add(this.Plakatxt);
            this.Controls.Add(this.comboArabalar);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmArabaListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araba Listesi";
            this.Load += new System.EventHandler(this.FrmArabaListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboArabalar;
        private System.Windows.Forms.Button btnResimEkle;
        private System.Windows.Forms.Button btnArabaIptal;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Ucrettxt;
        private System.Windows.Forms.ComboBox Yakitcombo;
        private System.Windows.Forms.TextBox Kmtxt;
        private System.Windows.Forms.TextBox Renktxt;
        private System.Windows.Forms.TextBox Yiltxt;
        private System.Windows.Forms.ComboBox Modelcombo;
        private System.Windows.Forms.ComboBox Markacombo;
        private System.Windows.Forms.TextBox Plakatxt;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}