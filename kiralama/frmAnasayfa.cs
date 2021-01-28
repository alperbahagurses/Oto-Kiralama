using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiralama
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmMüsteriEkle ekle = new frmMüsteriEkle();
            ekle.ShowDialog();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            frmMüsteriList listele = new frmMüsteriList();
            listele.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            frmArabaKayıt kayıt = new frmArabaKayıt();
            kayıt.ShowDialog();       
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            frmArabaListele arabalistele = new frmArabaListele();
            arabalistele.ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            frmSözlesme sözlesme = new frmSözlesme();
            sözlesme.ShowDialog();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            frmSatis satis = new frmSatis();
            satis.ShowDialog();
        }
    }
}
