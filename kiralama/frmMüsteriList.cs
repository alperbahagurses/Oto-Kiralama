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
    public partial class frmMüsteriList : Form
    {
        RentaCar arackiralama = new RentaCar();

        public frmMüsteriList()
        {
            InitializeComponent();
        }
        private void FrmMüsteriList_Load(object sender, EventArgs e)
        {
            YenileListele();
        }
        private void YenileListele()
        {
            string cümle = "select *from müsteri";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView2.DataSource = arackiralama.listele(adtr2,cümle);
            dataGridView2.Columns[0].HeaderText = "TC";
            dataGridView2.Columns[1].HeaderText = "AD SOYAD";
            dataGridView2.Columns[2].HeaderText = "TELEFON";
            dataGridView2.Columns[3].HeaderText = "ADRES";
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string cümle = "select *from müsteri where tc like '%"+textBox1.Text+"%'";
            SqlDataAdapter adtr2 = new SqlDataAdapter();          
            dataGridView2.DataSource = arackiralama.listele(adtr2, cümle);
        }

        private void BtnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView2.CurrentRow;
            txtTC.Text = satir.Cells[0].Value.ToString();
            txtAdSoyad.Text = satir.Cells[1].Value.ToString();
            txtTelefon.Text = satir.Cells[2].Value.ToString();
            txtAdres.Text = satir.Cells[3].Value.ToString();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            string cümle = "update müsteri set adsoyad=@adsoyad,telefon=@telefon,adres=@adres where tc=@tc";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@tc", txtTC.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut2.Parameters.AddWithValue("@adres", txtAdres.Text);
            arackiralama.ekle_sil_güncelle(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            YenileListele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView2.CurrentRow;
            string cümle="delete from müsteri where tc='"+satir.Cells["tc"].Value.ToString()+"'";
            SqlCommand komut2 = new SqlCommand();
            arackiralama.ekle_sil_güncelle(komut2, cümle);
            //foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            YenileListele();

        }
    }
    }
    
    

