using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLRauMaVer1.Forms
{
    public partial class Information : Form
    {
        private string shopid;
        public Information(string shopid)
        {
            InitializeComponent();
            this.shopid = shopid;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Home_ThuNgan home = new Home_ThuNgan(shopid);
            this.Hide();
            home.Show();
        }
    }
}
