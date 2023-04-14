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
    class ThanhToanDAO
    {
        DBConnection db;
        public ThanhToanDAO()
        {
            db = new DBConnection();

        }
        public bool checkoutPayment(int orderID, string voucher_id, string payment, string payment_amount)
        {
            SqlConnection con = db.Con;
            try
            {
                string query = "checkout_order";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@order_id", orderID);
                cmd.Parameters.AddWithValue("@payment_amount", payment_amount);
                cmd.Parameters.AddWithValue("@payment_method", payment);
                if (voucher_id == null)
                    cmd.Parameters.AddWithValue("@voucher_id", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@voucher_id", voucher_id);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

    }
}
