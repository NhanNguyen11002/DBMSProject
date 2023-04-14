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
    public partial class Home_ThuNgan : Form
    {
        private string shopid;
        public Home_ThuNgan(string shopid)
        {
            InitializeComponent();
            this.shopid = shopid;
        }

        private void Home_ThuNgan_Load(object sender, EventArgs e)
        {

        }

        private void donhangBtn_Click(object sender, EventArgs e)
        {
            DonHang donhang = new DonHang(shopid);
            this.Hide();
            donhang.Show();
        }

        private void khachhangBtn_Click(object sender, EventArgs e)
        {
            KhachHang khachhang = new KhachHang(shopid);
            this.Hide();
            khachhang.Show();
        }

        private void voucherBtn_Click(object sender, EventArgs e)
        {
            Voucher voucher = new Voucher(shopid);
            this.Hide();
            voucher.Show();
        }

        private void qlnvBtn_Click(object sender, EventArgs e)
        {
            QLNV qlnv = new QLNV(shopid);
            this.Hide();
            qlnv.Show();
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            Information info = new Information(shopid);
            this.Hide();
            info.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnLuong_Click(object sender, EventArgs e)
        {
            Luong luong = new Luong(shopid);
            this.Hide();
            luong.Show();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham(shopid);
            this.Hide();
            sp.Show();
        }
    }
}
