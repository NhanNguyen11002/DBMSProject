using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLRauMaVer1.Connection;


namespace QLRauMaVer1.Forms
{
    public partial class ThongKeDuLieu : Form
    {
        private DBConnection db;
        ThongKeDAO tk;
        public ThongKeDuLieu()
        {
            InitializeComponent();
            db = new DBConnection();
        }

        

        private void homepageBtn_Click(object sender, EventArgs e)
        {
            Home_SuperAdmin homeform = new Home_SuperAdmin();
            this.Hide();
            homeform.Show();
        }

        private void ThongKeDuLieu_Load(object sender, EventArgs e)
        {
            try
            {
                tk = new ThongKeDAO();
                DataTable dt = tk.ShowShop();
                FillData(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillData(DataTable dt)
        {
            cb_shop.Items.Clear();
            cb_shop.DisplayMember = "shop_address";
            cb_shop.ValueMember = "shop_id";
            cb_shop.DataSource = dt;
        }

   
        private void btn_Xem_Click(object sender, EventArgs e)
        {
            tk = new ThongKeDAO();
            string choiceStr = cbx_func.Text;
            switch (choiceStr)
            {
                case "Xem chi phí điện, nước, mặt bằng của shop":
                    {
                        
                        dgv_result.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgv_result.DataSource = tk.Shop_MBDN_Cost(cb_shop.SelectedValue.ToString());
                    }
                    break;
                case "Danh sách đơn hàng chưa thanh toán":
                    {

                        dgv_result.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgv_result.DataSource = tk.UnpaidPayment(cb_shop.SelectedValue.ToString());
                    }
                    break;
                case "Voucher có thể sử dụng trong ngày":
                    {

                        dgv_result.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgv_result.DataSource = tk.ValidVoucher();
                    }
                    break;
                case "Lương mỗi tháng shop trả cho nhân viên":
                    {

                        dgv_result.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgv_result.DataSource = tk.LuongShopMonth(cb_shop.SelectedValue.ToString());
                    }
                    break;
                case "Doanh thu của shop theo tháng":
                    {

                        dgv_result.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgv_result.DataSource = tk.DoanhThu(cb_shop.SelectedValue.ToString());
                    }
                    break;
                case "Lợi nhuận của shop theo tháng":
                    {

                        dgv_result.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgv_result.DataSource = tk.LoiNhuan(cb_shop.SelectedValue.ToString());
                    }
                    break;
                case "NV có kinh nghiệm làm việc( từ 2 tháng đến 3 tháng)":
                    {
                        dgv_result.DataSource = tk.empOverOneMonth();
                    }
                    break;
                case "Tổng chi phí 3 tháng gần nhất":
                    {
                        dgv_result.DataSource = tk.show3MonthNearestFee();
                    }
                    break;
                case "Những chuỗi chi nhánh ở TP.HCM":
                    {
                        dgv_result.DataSource = tk.showHcmShop();
                    }
                    break;
                case "5 sản phẩm bán chạy nhất":
                    {
                        dgv_result.DataSource = tk.Top5BestProduct(cb_shop.SelectedValue.ToString());
                    }
                    break;
                case "Sản phẩm đã bán trong ngày":
                    {
                        dgv_result.DataSource = tk.SoldProductToday(cb_shop.SelectedValue.ToString());
                    }
                    break;
            }
        }
    }
}
