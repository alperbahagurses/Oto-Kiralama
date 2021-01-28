using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiralama
{
    public partial class frmArabaKayıt : Form
    {
        RentaCar arackiralama = new RentaCar();
        public frmArabaKayıt()
        {
            InitializeComponent();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnResimEkle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;

        }

        private void BtnArabaIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Modelcombo.Items.Clear();
                if (Markacombo.SelectedItem.ToString()=="BMW")
                {
                    Modelcombo.Items.Add("3.20D");
                    Modelcombo.Items.Add("5.20");
                }
                else if (Markacombo.SelectedIndex == 1)
                {
                    Modelcombo.Items.Add("Doblo");
                    Modelcombo.Items.Add("Fiorino");
                    Modelcombo.Items.Add("Linea");
                    Modelcombo.Items.Add("Egea");
                }
                else if (Markacombo.SelectedIndex == 2)
                {
                    Modelcombo.Items.Add("Focus");
                    Modelcombo.Items.Add("Fiesta");
                }
                else if (Markacombo.SelectedIndex == 3)
                {
                    Modelcombo.Items.Add("Civic");
                }
                else if (Markacombo.SelectedIndex == 4)
                {
                    Modelcombo.Items.Add("Accent Blue");
                    Modelcombo.Items.Add("i20");
                }
                else if (Markacombo.SelectedIndex == 5)
                {
                    Modelcombo.Items.Add("E250");
                }
                else if (Markacombo.SelectedIndex == 6)
                {
                    Modelcombo.Items.Add("208");
                    Modelcombo.Items.Add("301");
                }
                else if (Markacombo.SelectedIndex == 7)
                {
                    Modelcombo.Items.Add("Clio");
                    Modelcombo.Items.Add("Symbol");
                    Modelcombo.Items.Add("Megane");
                }
                else if (Markacombo.SelectedIndex == 8)
                {
                    Modelcombo.Items.Add("Corolla");
                }
                else if (Markacombo.SelectedIndex == 9)
                {
                    Modelcombo.Items.Add("Polo");
                    Modelcombo.Items.Add("Golf");
                    Modelcombo.Items.Add("Jetta");
                    Modelcombo.Items.Add("Passat");
                }
            }
            catch
            {

                ;
            }
            
        }

        private void BtnArabaKaydet_Click(object sender, EventArgs e)
        {
            string cümle = "insert into arabakayit(plaka,marka,model,yil,renk,km,yakit,ücret,resim,tarih,durum) values(@plaka,@marka,@model,@yil,@renk,@km,@yakit,@ücret,@resim,@tarih,@durum)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@plaka",Plakatxt.Text);
            komut2.Parameters.AddWithValue("@marka", Markacombo.Text);
            komut2.Parameters.AddWithValue("@model", Modelcombo.Text);
            komut2.Parameters.AddWithValue("@yil", Yiltxt.Text);
            komut2.Parameters.AddWithValue("@renk", Renktxt.Text);
            komut2.Parameters.AddWithValue("@km", Kmtxt.Text);
            komut2.Parameters.AddWithValue("@yakit", Yakitcombo.Text);
            komut2.Parameters.AddWithValue("@ücret", int.Parse(Ucrettxt.Text));
            komut2.Parameters.AddWithValue("@resim", pictureBox1.ImageLocation);
            komut2.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            komut2.Parameters.AddWithValue("@durum", "BOŞ");
            arackiralama.ekle_sil_güncelle(komut2,cümle);
            Modelcombo.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            pictureBox1.ImageLocation = "";
            MessageBox.Show("Araba Eklendi");

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Ucrettxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Yakitcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Kmtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Modelcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Plakatxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmArabaKayıt_Load(object sender, EventArgs e)
        {

        }
    }
}
