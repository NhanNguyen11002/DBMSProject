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
    public partial class SanPham_SuperAdmin : Form
    {
        public SanPham_SuperAdmin()
        {
            InitializeComponent();
        }
        public void loadData()
        {
            SanPhamDao db = new SanPhamDao();
            DataTable dt = db.SelectAllSanPham();
            DataTable dt1 = db.SelectAllSanPhamTrongShop();
            dtgSanPham.DataSource = dt;
            dtgSanPham_CuaHang.DataSource = dt1;
        }
        public void reset()
        {
            productIdTextbox.Clear();
            productNameTextbox.Clear();
            priceTextbox.Clear();
            categoryTextbox.Clear();
            costTextbox.Clear();
            filterShopIDTextbox.Clear();

        }
        public void reset1()
        {
            txtmaCuaHang.Clear();
            txtmaSanPham.Clear();
            txtStatus.Clear();
        }

        private void themBtn_Click(object sender, EventArgs e)
        {
            if ((productNameTextbox.Text == "") || (priceTextbox.Text == "") || (categoryTextbox.Text == "") || (costTextbox.Text == ""))
            {
                MessageBox.Show("Thông tin không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DialogResult msg = MessageBox.Show("Bạn chắc chắn muốn thêm sản phẩm này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (msg == DialogResult.Yes)
                    {
                        //int id = Convert.ToInt32(productIdTextbox.Text);
                        string name = productNameTextbox.Text;
                        double price = Convert.ToDouble(priceTextbox.Text);
                        string type = categoryTextbox.Text;
                        double cost = Convert.ToDouble(costTextbox.Text);
                        SanPhamDao sp = new SanPhamDao();
                        sp.ThemSanPham(name, price, type, cost);
                        loadData();
                        reset();
                        MessageBox.Show("Thêm sản phẩm thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void xoaBtn_Click(object sender, EventArgs e)
        {
            if ((productIdTextbox.Text == ""))
            {
                MessageBox.Show("Thông tin không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DialogResult msg = MessageBox.Show("Bạn chắc chắn muốn xóa sản phẩm này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (msg == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(productIdTextbox.Text);
                        string name = productNameTextbox.Text;
                        double price = Convert.ToDouble(priceTextbox.Text);
                        string type = categoryTextbox.Text;
                        double cost = Convert.ToDouble(costTextbox.Text);
                        SanPhamDao sp = new SanPhamDao();
                        sp.XoaSanPham(id);
                        loadData();
                        reset();
                        MessageBox.Show("Xóa sản phẩm thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void suaBtn_Click(object sender, EventArgs e)
        {
            if ((productNameTextbox.Text == "") || (priceTextbox.Text == "") || (categoryTextbox.Text == "") || (costTextbox.Text == ""))
            {
                MessageBox.Show("Thông tin không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DialogResult msg = MessageBox.Show("Bạn chắc chắn muốn sửa sản phẩm này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (msg == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(productIdTextbox.Text);
                        string name = productNameTextbox.Text;
                        double price = Convert.ToDouble(priceTextbox.Text);
                        string type = categoryTextbox.Text;
                        double cost = Convert.ToDouble(costTextbox.Text);
                        SanPhamDao nv = new SanPhamDao();
                        nv.SuaSanPham(id, name, price, type, cost);
                        loadData();
                        reset();
                        MessageBox.Show("Sửa sản phẩm thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            SanPhamDao db = new SanPhamDao();
            string shopid = filterShopIDTextbox.Text;
            //DataTable dt = db.LocSanPhamTheoShop(shopid);
            DataTable dt1 = db.SelectAllSanPhamTrong1Shop(shopid);
            //dtgSanPham.DataSource = dt;
            dtgSanPham_CuaHang.DataSource = dt1;
            reset1();
        }

        private void dtgSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgSanPham.CurrentRow.Index;
            productIdTextbox.Text = dtgSanPham.Rows[i].Cells[0].Value.ToString();
            productNameTextbox.Text = dtgSanPham.Rows[i].Cells[3].Value.ToString();
            priceTextbox.Text = dtgSanPham.Rows[i].Cells[1].Value.ToString();
            categoryTextbox.Text = dtgSanPham.Rows[i].Cells[4].Value.ToString();
            costTextbox.Text = dtgSanPham.Rows[i].Cells[2].Value.ToString();
        }

        private void SanPham_SuperAdmin_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void homepageBtn_Click(object sender, EventArgs e)
        {
            Home_SuperAdmin home = new Home_SuperAdmin();
            this.Hide();
            home.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((txtmaSanPham.Text == "") || (txtmaCuaHang.Text == "") || (txtStatus.Text == ""))
            {
                MessageBox.Show("Thông tin không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DialogResult msg = MessageBox.Show("Bạn chắc chắn muốn thêm sản phẩm này vào cửa hàng?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (msg == DialogResult.Yes)
                    {
                        int productid = Convert.ToInt32(txtmaSanPham.Text);
                        string shopid = txtmaCuaHang.Text;
                        string status = txtStatus.Text;
                        SanPhamDao sp = new SanPhamDao();
                        sp.ThemSanPhamVaoShop(productid, shopid, status);
                        loadData();
                        reset1();
                        MessageBox.Show("Thêm sản phẩm vào cửa hàng thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if ((txtmaSanPham.Text == ""))
            {
                MessageBox.Show("Thông tin không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DialogResult msg = MessageBox.Show("Bạn chắc chắn muốn xóa sản phẩm này ra khỏi cửa hàng không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (msg == DialogResult.Yes)
                    {
                        int productid = Convert.ToInt32(txtmaSanPham.Text);
                        string shopid = txtmaCuaHang.Text;
                        string status = txtStatus.Text;
                        SanPhamDao sp = new SanPhamDao();
                        sp.XoaSanPhamVaoShop(productid);
                        loadData();
                        reset1();
                        MessageBox.Show("Xóa sản phẩm ra khỏi cửa hàng thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if ((txtmaSanPham.Text == "") || (txtmaCuaHang.Text == "") || (txtStatus.Text == ""))
            {
                MessageBox.Show("Thông tin không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DialogResult msg = MessageBox.Show("Bạn chắc chắn muốn sửa sản phẩm này từ cửa hàng?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (msg == DialogResult.Yes)
                    {
                        int productid = Convert.ToInt32(txtmaSanPham.Text);
                        string shopid = txtmaCuaHang.Text;
                        string status = txtStatus.Text;
                        SanPhamDao sp = new SanPhamDao();
                        sp.SuaSanPhamVaoShop(productid, shopid, status);
                        loadData();
                        reset1();
                        MessageBox.Show("Sửa sản phẩm từ cửa hàng thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dtgSanPham_CuaHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgSanPham_CuaHang.CurrentRow.Index;
            txtmaSanPham.Text = dtgSanPham_CuaHang.Rows[i].Cells[0].Value.ToString();
            txtmaCuaHang.Text = dtgSanPham_CuaHang.Rows[i].Cells[1].Value.ToString();
            txtStatus.Text = dtgSanPham_CuaHang.Rows[i].Cells[2].Value.ToString();
           
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
