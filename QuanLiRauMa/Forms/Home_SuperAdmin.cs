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
    public partial class Home_SuperAdmin : Form
    {
        public Home_SuperAdmin()
        {
            InitializeComponent();
        }

        private void donhangBtn_Click(object sender, EventArgs e)
        {
            DonHang_SuperAdmin donhang = new DonHang_SuperAdmin();
            this.Hide();
            donhang.Show();
        }

        private void khachhangBtn_Click(object sender, EventArgs e)
        {
            KhachHang_SuperAdmin khachhang = new KhachHang_SuperAdmin();
            this.Hide();
            khachhang.Show();
        }

        private void voucherBtn_Click(object sender, EventArgs e)
        {
            Voucher_SuperAdmin voucher = new Voucher_SuperAdmin();
            this.Hide();
            voucher.Show();
        }

        private void qlnvBtn_Click(object sender, EventArgs e)
        {
            QLNV_SuperAdmin qlnv = new QLNV_SuperAdmin();
            this.Hide();
            qlnv.Show();
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            Information_SuperAdmin information = new Information_SuperAdmin();
            this.Hide();
            information.Show();
        }

        private void analysisBtn_Click(object sender, EventArgs e)
        {
            ThongKeDuLieu thongkeform = new ThongKeDuLieu();
            this.Hide();
            thongkeform.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void sanphamBtn_Click(object sender, EventArgs e)
        {
            SanPham_SuperAdmin sp = new SanPham_SuperAdmin();
            this.Hide();
            sp.Show();
        }
    }
}
