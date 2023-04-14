using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLRauMaVer1.Connection
{
    class VoucherDao
    {
        DBConnection db;
        public VoucherDao()
        {
            db = new DBConnection();
        }
        public void ThemVoucher(string id, double discount, string mota, string startdate, string enddate, string constraint)
        {
            string sql = "add_new_voucher";
            SqlConnection con = db.Con;
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@voucher_id", SqlDbType.VarChar).Value = id;
            cmd.Parameters.AddWithValue("@discount", SqlDbType.Float).Value = discount;
            cmd.Parameters.AddWithValue("@mo_ta", SqlDbType.NVarChar).Value = mota;
            cmd.Parameters.AddWithValue("@start_day", SqlDbType.Date).Value = startdate;
            cmd.Parameters.AddWithValue("@end_day", SqlDbType.Date).Value = enddate;
            cmd.Parameters.AddWithValue("@voucher_constraint", SqlDbType.VarChar).Value = constraint;
            cmd.ExecuteNonQuery();
            con.Close();
            //string sql = "insert into Voucher values('" + id + "'," + discount + ",N'" + mota + "',CAST(N'" + startdate + "' AS Date),CAST(N'" + enddate + "' AS Date),'" + constraint + "')";
            //db.ExecuteNonQuery(sql);
        }
        public void SuaVoucher(string id, double discount, string mota, string startdate, string enddate, string constraint)
        {
            string sql = "edit_voucher";
            SqlConnection con = db.Con;
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@voucher_id", SqlDbType.VarChar).Value = id;
            cmd.Parameters.AddWithValue("@discount", SqlDbType.Float).Value = discount;
            cmd.Parameters.AddWithValue("@mo_ta", SqlDbType.NVarChar).Value = mota;
            cmd.Parameters.AddWithValue("@start_day", SqlDbType.Date).Value = startdate;
            cmd.Parameters.AddWithValue("@end_day", SqlDbType.Date).Value = enddate;
            cmd.Parameters.AddWithValue("@voucher_constraint", SqlDbType.VarChar).Value = constraint;
            cmd.ExecuteNonQuery();
            con.Close();
            //string sql = "update Voucher set voucher_id='" + id + "', discount= " + discount + ", mo_ta= N'" + mota + "', start_day = CAST(N'" + startdate + "' AS Date), end_day = CAST(N'" + enddate + "' AS Date), voucher_constraint = '" + constraint + "' where voucher_id='" + id + "'";
            //db.ExecuteNonQuery(sql);
        }
        public void XoaVoucher(string id)
        {
            string query = "delete_voucher";
            SqlConnection con = db.Con;
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@voucher_id", SqlDbType.VarChar).Value = id;
            cmd.ExecuteNonQuery();
            con.Close();
            //string sql = "delete from Voucher where voucher_id = '" + id + "'";
            //db.ExecuteNonQuery(sql);
        }
        public DataTable SelectAllVoucher()
        {
            string sql = "select * from Voucher";
            DataTable result = db.ExecutionQuery(sql);
            return result;
        }
        public DataTable LocVoucherTheoShop(string id)
        {
            string sql = "select distinct Voucher.voucher_id, discount, mo_ta, start_day, end_day, voucher_constraint from Voucher inner join Voucher_item " +
                "on Voucher.voucher_id = VOUCHER_ITEM.voucher_id inner join ORDER_LIST " +
                "on VOUCHER_ITEM.c_phone_number = ORDER_LIST.c_phone_number " +
                "where shop_id = '" + id + "'";
            DataTable result = db.ExecutionQuery(sql);
            return result;
        }

        public string getDiscount(string voucher_id)
        {
            string sql = "select discount from VOUCHER where voucher_id = '" + voucher_id +"'";
            DataTable dt = db.ExecutionQuery(sql);
            DataRow dr = dt.Rows[0];
            string discount = dr["discount"].ToString();
            return discount;
        }
    }
}
