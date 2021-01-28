using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kiralama
{
    class RentaCar
    {
        //veritabanı bağlantısı
        SqlConnection baglanti = new SqlConnection("Data Source=..\\SQLEXPRESS;Initial Catalog=RentaCar;Integrated Security=True");
        DataTable tablo;
        public void ekle_sil_güncelle(SqlCommand komut, string sorgu)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public DataTable listele(SqlDataAdapter adtr, string sorgu)
        {
            tablo = new DataTable();
            adtr = new SqlDataAdapter(sorgu, baglanti);
            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;
        }
        public void Bos_Arabalar(System.Windows.Forms.ComboBox combo, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combo.Items.Add(read["plaka"].ToString());

            }
            baglanti.Close();
        }
        public void TC_Ara(System.Windows.Forms.TextBox tc, System.Windows.Forms.TextBox adsoyad, System.Windows.Forms.TextBox telefon, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                adsoyad.Text = read["adsoyad"].ToString();
                telefon.Text = read["telefon"].ToString();

            }
            baglanti.Close();
        }
        public void ComboGetir(System.Windows.Forms.ComboBox arabalar, System.Windows.Forms.TextBox marka, System.Windows.Forms.TextBox model, System.Windows.Forms.TextBox yil, System.Windows.Forms.TextBox renk, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                marka.Text = read["marka"].ToString();
                model.Text = read["model"].ToString();
                yil.Text = read["yil"].ToString();
                renk.Text = read["renk"].ToString();

            }
            baglanti.Close();
        }
        public void Ücret_Hesapla(System.Windows.Forms.ComboBox comboKiralamaSekli, System.Windows.Forms.TextBox ücret, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (comboKiralamaSekli.SelectedIndex == 0)
                {
                    ücret.Text = (int.Parse(read["ücret"].ToString()) * 1).ToString();
                }
                if (comboKiralamaSekli.SelectedIndex == 1)
                {
                    ücret.Text = (int.Parse(read["ücret"].ToString()) * 0.80).ToString();
                }
                if (comboKiralamaSekli.SelectedIndex == 2)
                {
                    ücret.Text = (int.Parse(read["ücret"].ToString()) * 0.70).ToString();
                }
            }
            baglanti.Close();
        }
        public void satishesapla(Label lbl)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(tutar) from satis",baglanti);
            lbl.Text = "Gelir : " + komut.ExecuteScalar() + " TL";
            baglanti.Close();
        }
    }
}
