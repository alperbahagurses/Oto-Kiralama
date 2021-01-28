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
    public partial class frmMüsteriEkle : Form
    {
        RentaCar arac_kiralama = new RentaCar();
        public frmMüsteriEkle()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string cümle = "insert into müsteri(tc,adsoyad,telefon,adres) values(@tc,@adsoyad,@telefon,@adres) ";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@tc", txtTC.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut2.Parameters.AddWithValue("@adres", txtAdres.Text);
            arac_kiralama.ekle_sil_güncelle(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            MessageBox.Show("Müşteri Eklendi");
        }

        private void FrmMüsteriEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
