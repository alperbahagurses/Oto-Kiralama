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
    public partial class frmSatis : Form
    {
        public frmSatis()
        {
            InitializeComponent();
        }
        RentaCar araba = new RentaCar();
        private void FrmSatis_Load(object sender, EventArgs e)
        {
            string sorgu2 = "select * from satis";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = araba.listele(adtr2,sorgu2);
            araba.satishesapla(label1);
        }
    }
}
