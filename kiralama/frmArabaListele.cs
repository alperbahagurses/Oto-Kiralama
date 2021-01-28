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
    public partial class frmArabaListele : Form
    {
        RentaCar arackiralama = new RentaCar();
        public frmArabaListele()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            Plakatxt.Text = satir.Cells["plaka"].Value.ToString();
            Markacombo.Text = satir.Cells["marka"].Value.ToString();
            Modelcombo.Text = satir.Cells["model"].Value.ToString();
            Yiltxt.Text = satir.Cells["yil"].Value.ToString();
            Renktxt.Text = satir.Cells["renk"].Value.ToString();
            Kmtxt.Text = satir.Cells["km"].Value.ToString();
            Yakitcombo.Text = satir.Cells["yakit"].Value.ToString();
            Ucrettxt.Text = satir.Cells["ücret"].Value.ToString();
            pictureBox1.ImageLocation = satir.Cells["resim"].Value.ToString();
        }

        private void FrmArabaListele_Load(object sender, EventArgs e)
        {
            YenileAraclarListesi();
            comboArabalar.SelectedIndex = 0;
            
        }
        private void YenileAraclarListesi()
        {
            string cümle = "select *from arabakayit";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource=arackiralama.listele(adtr2, cümle);
        }

        private void BtnResimEkle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            string cümle = "update arabakayit set marka=@marka,model=@model,yil=@yil,renk=@renk,km=@km,yakit=@yakit,ücret=@ücret,resim=@resim,tarih=@tarih where plaka=@plaka";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@plaka", Plakatxt.Text);
            komut2.Parameters.AddWithValue("@marka", Markacombo.Text);
            komut2.Parameters.AddWithValue("@model", Modelcombo.Text);
            komut2.Parameters.AddWithValue("@yil", Yiltxt.Text);
            komut2.Parameters.AddWithValue("@renk", Renktxt.Text);
            komut2.Parameters.AddWithValue("@km", Kmtxt.Text);
            komut2.Parameters.AddWithValue("@yakit", Yakitcombo.Text);
            komut2.Parameters.AddWithValue("@ücret", int.Parse(Ucrettxt.Text));
            komut2.Parameters.AddWithValue("@resim", pictureBox1.ImageLocation);
            komut2.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            arackiralama.ekle_sil_güncelle(komut2, cümle);
            Modelcombo.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            pictureBox1.ImageLocation = "";
            YenileAraclarListesi();
            MessageBox.Show("Araba Bilgileri Güncellendi");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            string cümle = "delete from arabakayit where plaka='"+satir.Cells["plaka"].Value.ToString()+"'";
            SqlCommand komut2 = new SqlCommand();
            arackiralama.ekle_sil_güncelle(komut2,cümle);
            YenileAraclarListesi();
            pictureBox1.ImageLocation = "";
            Modelcombo.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";

        }

        private void Markacombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Modelcombo.Items.Clear();
                if (Markacombo.SelectedItem.ToString() == "BMW")
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

        private void ComboArabalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboArabalar.SelectedIndex == 0)
                {
                    YenileAraclarListesi();
                }
                if (comboArabalar.SelectedIndex == 1)
                {
                    string cümle = "select *from arabakayit where durum='BOŞ'";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = arackiralama.listele(adtr2, cümle);
                }
                if (comboArabalar.SelectedIndex == 2)
                {
                    string cümle = "select *from arabakayit where durum='DOLU'";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = arackiralama.listele(adtr2, cümle);
                }
            }
            catch
            {
                ;
            }
        }
    }
  
}
    
