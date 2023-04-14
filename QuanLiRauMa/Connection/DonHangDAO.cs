using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLRauMaVer1.Connection
{
    class DonHangDAO
    {
        DBConnection db;
        public DonHangDAO()
        {
            db = new DBConnection();
        }
        //Nhân---------------------------------------
        public bool ThemDonHang(string phone, string createday, string shopid)
        {
            try
            {
                string query = "add_new_order_list";
                SqlConnection con = db.Con;
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@c_phone_number", SqlDbType.Char).Value = phone;
                cmd.Parameters.AddWithValue("@create_day", SqlDbType.Date).Value = createday;
                cmd.Parameters.AddWithValue("@shop_id", SqlDbType.NChar).Value = shopid;
                int change = cmd.ExecuteNonQuery();
                con.Close();
                if (change != 0)
                {
                    return true;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
       }
        public bool XoaDonHang(int order_id)
        {
            SqlConnection con = db.Con;
            string query = "delete_order_trans";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@order_id", order_id);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                con.Close();
            }
            return false;
        }
        public DataTable SelectAllDonHang()
        {
            string sql = "select order_list.order_id, c_phone_number, create_day, shop_id, payment_method, voucher_id, " +
                "payment_amount, payment_status from order_list inner join payment on order_list.order_id = payment.order_id order by order_id desc";
            DataTable rs = db.ExecutionQuery(sql);
            return rs;
        }
        public DataTable SelectAllDonHangByShopId(string shopid)
        {
            SqlConnection con = db.Con;
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.show_order_in_shop(@shop_id)", con);
            cmd.Parameters.AddWithValue("@shop_id", shopid);
            SqlDataAdapter apt = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            apt.Fill(data);
            return data;
            //string sql = "select order_list.order_id, c_phone_number, create_day, shop_id, payment_method, voucher_id, " +
            //    "payment_amount, payment_status from order_list inner join payment on order_list.order_id = payment.order_id where shop_id ='"+shopid+ "' order by order_id desc";
            //DataTable rs = db.ExecutionQuery(sql);
            //return rs;
        }
    }
}
