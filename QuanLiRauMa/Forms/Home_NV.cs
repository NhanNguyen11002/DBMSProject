using QLRauMaVer1.Connection;
using QLRauMaVer1.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLRauMaVer1
{
    public partial class NhanVienHome : Form
    {
        private int emp_id;
        private string name;
        public NhanVienHome(int emp_id)
        {
            InitializeComponent();
            this.emp_id = emp_id;
            QLNVDao nhanvien = new QLNVDao();
            DataRow dr = nhanvien.Select1NhanVien(emp_id);
            name = dr["emp_name"].ToString();
        }
        
        private void NhanVienHome_Load(object sender, EventArgs e)
        {
            labelXinchao.Text = "Xin chào "+name;
        }

        private void xemThongTinBtn_Click(object sender, EventArgs e)
        {
            XemThongTin_NV thongtin = new XemThongTin_NV(emp_id);
            this.Hide();
            thongtin.Show();
        }

        private void doiMatKhauBtn_Click(object sender, EventArgs e)
        {
            DoiMK doimk = new DoiMK(emp_id);
            this.Hide();
            doimk.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
