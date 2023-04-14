using QLRauMaVer1.Connection;
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

namespace QLRauMaVer1.Forms
{
    public partial class DonHang_SuperAdmin : Form
    {
        DonHangDAO donhang = new DonHangDAO();
        SanPhamDao sanpham = new SanPhamDao();
        ThanhToanDAO thanhtoan = new ThanhToanDAO();
        DBConnection db = new DBConnection();
        private int orderid;
        public DonHang_SuperAdmin()
        {
            InitializeComponent();
        }
        private void xoaBtn_Click(object sender, EventArgs e)
        {
            int order_id = Int32.Parse(orderidTextbox.Text);
            if (donhang.XoaDonHang(order_id))
            {
                MessageBox.Show("Xóa thành công");
                loadData();
            }
            else
                MessageBox.Show("Xóa thất bại");
        }

        private void themBtn_Click(object sender, EventArgs e)
        {

        }

        private void addOrderBtn_Click(object sender, EventArgs e)
        {
            string phone = phoneTextbox.Text;
            string createday = createdayDatepicker.Value.ToString("yyyy-MM-dd");
            string shopid = shopCbbox.Text;
            if (donhang.ThemDonHang(phone, createday, shopid))
            {
                productGrbox.Enabled = true;
                DataTable data = sanpham.ShowMenuInShop(shopid);
                dtgMenu.DataSource = data;
                SqlConnection con = db.Con;
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 order_id FROM ORDER_LIST ORDER BY order_id DESC ", con);
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    orderid = int.Parse(rd["order_id"].ToString());
                }
                con.Close();
            }
            else
                MessageBox.Show("Thất bại");
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            int rowSelect = dtgMenu.CurrentRow.Index;
            int product_id = Int32.Parse(dtgMenu.Rows[rowSelect].Cells[0].Value.ToString());
            int quantity = int.Parse(productAmountTextbox.Text);
            double cost = double.Parse(dtgMenu.Rows[rowSelect].Cells[2].Value.ToString());
            double price = quantity * cost;
            if (sanpham.InsertProductInOrder(orderid, product_id, quantity, price))
            {
                showInfoPayment();
                showVoucherItems(phoneTextbox.Text);
                showProductInOrder();
                paymentGrbox.Enabled = true;
            }
        }
        private void showInfoPayment()
        {
            SqlConnection con = db.Con;
            try
            {
                string query = "SELECT payment_amount FROM payment WHERE order_id=@order_id";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@order_id", orderid);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    totalpriceTextbox.Text = rd["payment_amount"].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void showVoucherItems(string c_phone)
        {
            SqlConnection con = db.Con;
            voucherCbbox.Items.Clear();
            try
            {
                string query = "view_voucher_of_cus";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@c_phone_number", c_phone);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    voucherCbbox.Items.Add(rd["voucher_id"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void showProductInOrder()
        {
            SqlConnection con = db.Con;
            try
            {
                string query = "SELECT * FROM show_product_in_order(@order_id)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@order_id", orderid);
                SqlDataAdapter apt = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                apt.Fill(data);
                dtgOrderproduct.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private void loadData()
        {
            dtgQLDH.DataSource = donhang.SelectAllDonHang();
        }
        private void DonHang_Load(object sender, EventArgs e)
        {
            SqlConnection con = db.Con;
            string query = "SELECT shop_id FROM shop";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                shopCbbox.Items.Add(rd["shop_id"]);
            }
            shopCbbox.SelectedIndex = 0;
            con.Close();
            loadData();
        }

        private void dtgQLDH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgQLDH.CurrentRow.Index;
            orderidTextbox.Text = dtgQLDH.Rows[i].Cells[0].Value.ToString();
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            string payment_method = payMethodCbbox.Text;
            string payment_amount = totalpriceTextbox.Text.ToString();
            string voucher_id = voucherCbbox.Text;
            if (voucher_id == "")
                voucher_id = null;
            if (thanhtoan.checkoutPayment(orderid, voucher_id, payment_method, payment_amount))
            {
                MessageBox.Show("Đặt hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
        }
        private void DonHang_SuperAdmin_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void homepageBtn_Click(object sender, EventArgs e)
        {
            Home_SuperAdmin home = new Home_SuperAdmin();
            this.Hide();
            home.Show();
        }

        private void addOrderBtn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
