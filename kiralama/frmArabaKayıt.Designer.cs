namespace kiralama
{
    partial class frmArabaKayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArabaKayıt));
            this.Plakatxt = new System.Windows.Forms.TextBox();
            this.Markacombo = new System.Windows.Forms.ComboBox();
            this.Modelcombo = new System.Windows.Forms.ComboBox();
            this.Yiltxt = new System.Windows.Forms.TextBox();
            this.Renktxt = new System.Windows.Forms.TextBox();
            this.Kmtxt = new System.Windows.Forms.TextBox();
            this.Yakitcombo = new System.Windows.Forms.ComboBox();
            this.Ucrettxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnResimEkle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnArabaIptal = new System.Windows.Forms.Button();
            this.btnArabaKaydet = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Plakatxt
            // 
            this.Plakatxt.Location = new System.Drawing.Point(171, 65);
            this.Plakatxt.Margin = new System.Windows.Forms.Padding(4);
            this.Plakatxt.Name = "Plakatxt";
            this.Plakatxt.Size = new System.Drawing.Size(160, 22);
            this.Plakatxt.TabIndex = 0;
            this.Plakatxt.TextChanged += new System.EventHandler(this.Plakatxt_TextChanged);
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
            this.Markacombo.Location = new System.Drawing.Point(171, 98);
            this.Markacombo.Margin = new System.Windows.Forms.Padding(4);
            this.Markacombo.Name = "Markacombo";
            this.Markacombo.Size = new System.Drawing.Size(160, 24);
            this.Markacombo.TabIndex = 1;
            this.Markacombo.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // Modelcombo
            // 
            this.Modelcombo.FormattingEnabled = true;
            this.Modelcombo.Location = new System.Drawing.Point(171, 133);
            this.Modelcombo.Margin = new System.Windows.Forms.Padding(4);
            this.Modelcombo.Name = "Modelcombo";
            this.Modelcombo.Size = new System.Drawing.Size(160, 24);
            this.Modelcombo.TabIndex = 2;
            this.Modelcombo.SelectedIndexChanged += new System.EventHandler(this.Modelcombo_SelectedIndexChanged);
            // 
            // Yiltxt
            // 
            this.Yiltxt.Location = new System.Drawing.Point(171, 167);
            this.Yiltxt.Margin = new System.Windows.Forms.Padding(4);
            this.Yiltxt.Name = "Yiltxt";
            this.Yiltxt.Size = new System.Drawing.Size(160, 22);
            this.Yiltxt.TabIndex = 3;
            this.Yiltxt.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // Renktxt
            // 
            this.Renktxt.Location = new System.Drawing.Point(171, 201);
            this.Renktxt.Margin = new System.Windows.Forms.Padding(4);
            this.Renktxt.Name = "Renktxt";
            this.Renktxt.Size = new System.Drawing.Size(160, 22);
            this.Renktxt.TabIndex = 4;
            this.Renktxt.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // Kmtxt
            // 
            this.Kmtxt.Location = new System.Drawing.Point(171, 234);
            this.Kmtxt.Margin = new System.Windows.Forms.Padding(4);
            this.Kmtxt.Name = "Kmtxt";
            this.Kmtxt.Size = new System.Drawing.Size(160, 22);
            this.Kmtxt.TabIndex = 5;
            this.Kmtxt.TextChanged += new System.EventHandler(this.Kmtxt_TextChanged);
            // 
            // Yakitcombo
            // 
            this.Yakitcombo.FormattingEnabled = true;
            this.Yakitcombo.Items.AddRange(new object[] {
            "Benzin",
            "Dizel",
            "Benzin/LPG"});
            this.Yakitcombo.Location = new System.Drawing.Point(171, 267);
            this.Yakitcombo.Margin = new System.Windows.Forms.Padding(4);
            this.Yakitcombo.Name = "Yakitcombo";
            this.Yakitcombo.Size = new System.Drawing.Size(160, 24);
            this.Yakitcombo.TabIndex = 6;
            this.Yakitcombo.SelectedIndexChanged += new System.EventHandler(this.Yakitcombo_SelectedIndexChanged);
            // 
            // Ucrettxt
            // 
            this.Ucrettxt.Location = new System.Drawing.Point(171, 302);
            this.Ucrettxt.Margin = new System.Windows.Forms.Padding(4);
            this.Ucrettxt.Name = "Ucrettxt";
            this.Ucrettxt.Size = new System.Drawing.Size(160, 22);
            this.Ucrettxt.TabIndex = 7;
            this.Ucrettxt.TextChanged += new System.EventHandler(this.Ucrettxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Plaka";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Marka";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Model";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Yıl";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 206);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Renk";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 239);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Km";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(121, 272);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Yakıt";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 305);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Günlük Ücret";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "car_2-add-512.png");
            this.ımageList1.Images.SetKeyName(1, "cikis.jpg");
            this.ımageList1.Images.SetKeyName(2, "add-button.png");
            // 
            // btnResimEkle
            // 
            this.btnResimEkle.BackColor = System.Drawing.Color.White;
            this.btnResimEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResimEkle.ImageIndex = 2;
            this.btnResimEkle.ImageList = this.ımageList1;
            this.btnResimEkle.Location = new System.Drawing.Point(423, 267);
            this.btnResimEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnResimEkle.Name = "btnResimEkle";
            this.btnResimEkle.Size = new System.Drawing.Size(123, 49);
            this.btnResimEkle.TabIndex = 19;
            this.btnResimEkle.Text = "Resim Ekle";
            this.btnResimEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResimEkle.UseVisualStyleBackColor = false;
            this.btnResimEkle.Click += new System.EventHandler(this.BtnResimEkle_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnArabaIptal
            // 
            this.btnArabaIptal.BackColor = System.Drawing.Color.White;
            this.btnArabaIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArabaIptal.ImageIndex = 1;
            this.btnArabaIptal.ImageList = this.ımageList1;
            this.btnArabaIptal.Location = new System.Drawing.Point(232, 361);
            this.btnArabaIptal.Margin = new System.Windows.Forms.Padding(4);
            this.btnArabaIptal.Name = "btnArabaIptal";
            this.btnArabaIptal.Size = new System.Drawing.Size(119, 39);
            this.btnArabaIptal.TabIndex = 18;
            this.btnArabaIptal.Text = "İptal";
            this.btnArabaIptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnArabaIptal.UseVisualStyleBackColor = false;
            this.btnArabaIptal.Click += new System.EventHandler(this.BtnArabaIptal_Click);
            // 
            // btnArabaKaydet
            // 
            this.btnArabaKaydet.BackColor = System.Drawing.Color.White;
            this.btnArabaKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArabaKaydet.ImageIndex = 0;
            this.btnArabaKaydet.ImageList = this.ımageList1;
            this.btnArabaKaydet.Location = new System.Drawing.Point(87, 361);
            this.btnArabaKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnArabaKaydet.Name = "btnArabaKaydet";
            this.btnArabaKaydet.Size = new System.Drawing.Size(119, 39);
            this.btnArabaKaydet.TabIndex = 17;
            this.btnArabaKaydet.Text = "Kaydet";
            this.btnArabaKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnArabaKaydet.UseVisualStyleBackColor = false;
            this.btnArabaKaydet.Click += new System.EventHandler(this.BtnArabaKaydet_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(381, 73);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // frmArabaKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(623, 482);
            this.Controls.Add(this.btnResimEkle);
            this.Controls.Add(this.btnArabaIptal);
            this.Controls.Add(this.btnArabaKaydet);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmArabaKayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araba Kayıt";
            this.Load += new System.EventHandler(this.FrmArabaKayıt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Plakatxt;
        private System.Windows.Forms.ComboBox Markacombo;
        private System.Windows.Forms.ComboBox Modelcombo;
        private System.Windows.Forms.TextBox Yiltxt;
        private System.Windows.Forms.TextBox Renktxt;
        private System.Windows.Forms.TextBox Kmtxt;
        private System.Windows.Forms.ComboBox Yakitcombo;
        private System.Windows.Forms.TextBox Ucrettxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnArabaKaydet;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnArabaIptal;
        private System.Windows.Forms.Button btnResimEkle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}