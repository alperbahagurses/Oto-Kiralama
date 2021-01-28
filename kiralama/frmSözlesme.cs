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
    public partial class frmSözlesme : Form
    {
        public frmSözlesme()
        {
            InitializeComponent();
        }
        RentaCar araba = new RentaCar();
        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmSözlesme_Load(object sender, EventArgs e)
        {
            Bos_Arabalar();
            Yenile();
        }
        private void Bos_Arabalar()
        {
            string sorgu2 = "select *from arabakayit where durum='BOŞ'";
            araba.Bos_Arabalar(comboArabalar, sorgu2);
        }
        private void Yenile()
        {
            string sorgu3 = "select *from sözlesme";
            System.Data.SqlClient.SqlDataAdapter adtr2 = new System.Data.SqlClient.SqlDataAdapter();
            dataGridView1.DataSource = araba.listele(adtr2, sorgu3);
        }

        private void TxtTc_TextChanged(object sender, EventArgs e)
        {
            if (txtTc.Text == "") foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            {

            }
            string sorgu2 = "select *from Müsteri where tc like'"+txtTc.Text+"'";
            araba.TC_Ara(txtTc,txtAdSoyad,txtTelefon,sorgu2);
        }

        private void ComboArabalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select *from arabakayit where plaka like'" +comboArabalar.SelectedItem+ "'";
            araba.ComboGetir(comboArabalar,txtMarka,txtModel,txtYil,txtRenk,sorgu2);
        }

        private void ComboKiralamaSekli_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select *from arabakayit where plaka like'" + comboArabalar.SelectedItem + "'";
            araba.Ücret_Hesapla(comboKiralamaSekli,txtKiraUcret,sorgu2);
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            TimeSpan gün = DateTime.Parse(dateTeslim.Text) - DateTime.Parse(dateCikis.Text);
            int gün2 = gün.Days;
            txtGün.Text = gün2.ToString();
            txtTutar.Text = (gün2 * int.Parse(txtKiraUcret.Text)).ToString();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();

        }
        private void Temizle()
        {
            dateCikis.Text = DateTime.Now.ToShortDateString();
            dateTeslim.Text = DateTime.Now.ToShortDateString();
            comboKiralamaSekli.Text = "";
            txtKiraUcret.Text = "";
            txtGün.Text = "";
            txtTutar.Text = "";
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "insert into sözlesme(tc,adsoyad,telefon,ehliyet_no,e_tarih,e_yeri,plaka,marka,model,yil,renk,kiralamasekli,kiraücreti,gün,tutar,c_tarih,d_tarih) values(@tc,@adsoyad,@telefon,@ehliyet_no,@e_tarih,@e_yeri,@plaka,@marka,@model,@yil,@renk,@kiralamasekli,@kiraücreti,@gün,@tutar,@c_tarih,@d_tarih)";
            SqlCommand komut2 = new SqlCommand(sorgu2);
            komut2.Parameters.AddWithValue("@tc", txtTc.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut2.Parameters.AddWithValue("@ehliyet_no", txtEhliyet.Text);
            komut2.Parameters.AddWithValue("@e_tarih", txtEhTarih.Text);
            komut2.Parameters.AddWithValue("@e_yeri", txtEhYer.Text);
            komut2.Parameters.AddWithValue("@plaka", comboArabalar.Text);
            komut2.Parameters.AddWithValue("@marka", txtMarka.Text);
            komut2.Parameters.AddWithValue("@model", txtModel.Text);
            komut2.Parameters.AddWithValue("@yil", txtYil.Text);
            komut2.Parameters.AddWithValue("@renk", txtRenk.Text);
            komut2.Parameters.AddWithValue("@kiralamasekli", comboKiralamaSekli.Text);
            komut2.Parameters.AddWithValue("@kiraücreti", int.Parse(txtKiraUcret.Text));
            komut2.Parameters.AddWithValue("@gün", int.Parse(txtGün.Text));
            komut2.Parameters.AddWithValue("@tutar", int.Parse(txtTutar.Text));
            komut2.Parameters.AddWithValue("@c_tarih", dateCikis.Text);
            komut2.Parameters.AddWithValue("@d_tarih", dateTeslim.Text);
            araba.ekle_sil_güncelle(komut2, sorgu2);
            string sorgu3 = "update arabakayit set durum='DOLU' where plaka='"+comboArabalar.Text+"' ";
            SqlCommand komut3 = new SqlCommand();
            araba.ekle_sil_güncelle(komut3,sorgu3);
            comboArabalar.Items.Clear();
            Bos_Arabalar();
            Yenile();
            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
            comboArabalar.Text = "";
            Temizle();
            MessageBox.Show("Sözleşme Oluşturuldu");
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "update sözlesme set tc=@tc,adsoyad=@adsoyad,telefon=@telefon,ehliyet_no=@ehliyet_no,e_tarih=@e_tarih,e_yeri=@e_yeri,plaka=@plaka,marka=@marka,model=@model,yil=@yil,renk=@renk,kiralamasekli=@kiralamasekli,kiraücreti=@kiraücreti,gün=@gün,tutar=@tutar,c_tarih=c_tarih,d_tarih=@d_tarih where plaka=@plaka";
            SqlCommand komut2 = new SqlCommand(sorgu2);
            komut2.Parameters.AddWithValue("@tc", txtTc.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut2.Parameters.AddWithValue("@ehliyet_no", txtEhliyet.Text);
            komut2.Parameters.AddWithValue("@e_tarih", txtEhTarih.Text);
            komut2.Parameters.AddWithValue("@e_yeri", txtEhYer.Text);
            komut2.Parameters.AddWithValue("@plaka", comboArabalar.Text);
            komut2.Parameters.AddWithValue("@marka", txtMarka.Text);
            komut2.Parameters.AddWithValue("@model", txtModel.Text);
            komut2.Parameters.AddWithValue("@yil", txtYil.Text);
            komut2.Parameters.AddWithValue("@renk", txtRenk.Text);
            komut2.Parameters.AddWithValue("@kiralamasekli", comboKiralamaSekli.Text);
            komut2.Parameters.AddWithValue("@kiraücreti", int.Parse(txtKiraUcret.Text));
            komut2.Parameters.AddWithValue("@gün", int.Parse(txtGün.Text));
            komut2.Parameters.AddWithValue("@tutar", int.Parse(txtTutar.Text));
            komut2.Parameters.AddWithValue("@c_tarih", dateCikis.Text);
            komut2.Parameters.AddWithValue("@d_tarih", dateTeslim.Text);
            araba.ekle_sil_güncelle(komut2, sorgu2);
            comboArabalar.Items.Clear();
            Bos_Arabalar();
            Yenile();
            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
            comboArabalar.Text = "";
            Temizle();
            MessageBox.Show("Sözleşme Güncellendi");
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txtTc.Text = satir.Cells[0].Value.ToString();
            txtAdSoyad.Text = satir.Cells[1].Value.ToString();
            txtTelefon.Text = satir.Cells[2].Value.ToString();
            txtEhliyet.Text = satir.Cells[3].Value.ToString();
            txtEhTarih.Text = satir.Cells[4].Value.ToString();
            txtEhYer.Text = satir.Cells[5].Value.ToString();
            comboArabalar.Text = satir.Cells[6].Value.ToString();
            txtMarka.Text = satir.Cells[7].Value.ToString();
            txtModel.Text = satir.Cells[8].Value.ToString();
            txtYil.Text = satir.Cells[9].Value.ToString();
            txtRenk.Text = satir.Cells[10].Value.ToString();
            comboKiralamaSekli.Text = satir.Cells[11].Value.ToString();
            txtKiraUcret.Text = satir.Cells[12].Value.ToString();
            txtGün.Text = satir.Cells[13].Value.ToString();
            txtTutar.Text = satir.Cells[14].Value.ToString();
            dateCikis.Text = satir.Cells[15].Value.ToString();
            dateTeslim.Text = satir.Cells[16].Value.ToString();

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            DateTime bugün = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime dönüs = DateTime.Parse(satir.Cells["d_tarih"].Value.ToString());
            int ücret=int.Parse(satir.Cells["kiraücreti"].Value.ToString());
            TimeSpan günfarki = bugün - dönüs;
            int _günfarki = günfarki.Days;
            int ücretfarki;
            ücretfarki = _günfarki * ücret;
            txtEkstra.Text = ücretfarki.ToString();



        }

        private void BtnTeslim_Click(object sender, EventArgs e)
        {
            if (txtEkstra.Text!="")
            {
                DataGridViewRow satir = dataGridView1.CurrentRow;
                DateTime bugün = DateTime.Parse(DateTime.Now.ToShortDateString());
                int ücret = int.Parse(satir.Cells["kiraücreti"].Value.ToString());
                int tutar = int.Parse(satir.Cells["tutar"].Value.ToString());
                DateTime cikis = DateTime.Parse(satir.Cells["c_tarih"].Value.ToString());
                TimeSpan gün = bugün - cikis;
                int _gün = gün.Days;
                int toplamtutar = _gün * ücret;
                string sorgu1 = "delete from sözlesme where plaka='"+satir.Cells["plaka"].Value.ToString()+"'";
                SqlCommand komut = new SqlCommand();
                araba.ekle_sil_güncelle(komut,sorgu1);
                string sorgu2 = "update arabakayit set durum='BOŞ' where plaka='"+satir.Cells["plaka"].Value.ToString()+"'";
                SqlCommand komut3 = new SqlCommand();
                araba.ekle_sil_güncelle(komut3, sorgu2);

                string sorgu3 = "insert into satis(tc,adsoyad,plaka,marka,model,yil,renk,gün,tutar,tarih1,tarih2,fiyat) values(@tc,@adsoyad,@plaka,@marka,@model,@yil,@renk,@gün,@tutar,@tarih1,@tarih2,@fiyat)";
                SqlCommand komut2 = new SqlCommand(sorgu2);
                komut2.Parameters.AddWithValue("@tc", satir.Cells["tc"].Value.ToString());
                komut2.Parameters.AddWithValue("@adsoyad", satir.Cells["adsoyad"].Value.ToString());
                komut2.Parameters.AddWithValue("@plaka", satir.Cells["plaka"].Value.ToString());
                komut2.Parameters.AddWithValue("@marka", satir.Cells["marka"].Value.ToString());
                komut2.Parameters.AddWithValue("@model", satir.Cells["model"].Value.ToString());
                komut2.Parameters.AddWithValue("@yil", satir.Cells["yil"].Value.ToString());
                komut2.Parameters.AddWithValue("@renk", satir.Cells["renk"].Value.ToString());
                komut2.Parameters.AddWithValue("@gün", _gün);
                komut2.Parameters.AddWithValue("@tutar", toplamtutar);
                komut2.Parameters.AddWithValue("@tarih1", satir.Cells["c_tarih"].Value.ToString());
                komut2.Parameters.AddWithValue("@tarih2", DateTime.Now.ToShortDateString());
                komut2.Parameters.AddWithValue("@fiyat", ücret);
                araba.ekle_sil_güncelle(komut2, sorgu3);
                MessageBox.Show("Araba Teslim Edildi");
                comboArabalar.Text = "";
                comboArabalar.Items.Clear();
                Bos_Arabalar();
                Yenile();
                foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
                foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
                comboArabalar.Text = "";
                Temizle();
                txtEkstra.Text = "";
            }
            else if (txtEkstra.Text == "")
            {
                MessageBox.Show("Lütfen Seçim Yapınız","Uyarı");
            }
        }
    }
}
