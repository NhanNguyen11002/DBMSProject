using QLRauMaVer1.Connection;
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
    public partial class XemThongTin_NV : Form
    {
        private int emp_id;
        private DataRow dr;
        public XemThongTin_NV(int emp_id)
        {
            InitializeComponent();
            this.emp_id = emp_id;
            QLNVDao nhanvien = new QLNVDao();
            this.dr = nhanvien.Select1NhanVien(emp_id);
        }

        private void XemThongTin_NV_Load(object sender, EventArgs e)
        {
            manvTextbox.Text = emp_id.ToString();
            tennvTextbox.Text = dr["emp_name"].ToString() ;
            sdtTextbox.Text = dr["phone_number"].ToString();
            roleTextbox.Text = dr["emp_role_name"].ToString();
            shopTextbox.Text = dr["shop_id"].ToString();
            beginDatepicker.Value = DateTime.Parse(dr["begin_date"].ToString());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homepageBtn_Click(object sender, EventArgs e)
        {
            NhanVienHome home = new NhanVienHome(emp_id);
            this.Hide();
            home.Show();
        }
    }
}
