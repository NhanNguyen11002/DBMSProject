using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLRauMaVer1.Connection
{
    class KhachHangDAO
    {
        DBConnection db;
        public KhachHangDAO()
        {
            db = new DBConnection();
        }
        //Nhân------------------------------
        public void ThemKhachHang(string phone, string birthday, string address, string type)
        {
            string query = "add_new_customer";
            SqlConnection con = db.Con;
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@c_phone_number", SqlDbType.Char).Value = phone;
            cmd.Parameters.AddWithValue("@birthday", SqlDbType.Date).Value = birthday;
            cmd.Parameters.AddWithValue("@c_address", SqlDbType.NChar).Value = address;
            cmd.Parameters.AddWithValue("@type_cus", SqlDbType.Char).Value = type;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void SuaKhachHang(string phone, string birthday, string address, string type)
        {
            string query = "edit_customer";
            SqlConnection con = db.Con;
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@c_phone_number", SqlDbType.Char).Value = phone;
            cmd.Parameters.AddWithValue("@birthday", SqlDbType.Date).Value = birthday;
            cmd.Parameters.AddWithValue("@c_address", SqlDbType.NChar).Value = address;
            cmd.Parameters.AddWithValue("@type_cus", SqlDbType.Char).Value = type;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void XoaKhachHang(string phone)
        {
            string query = "delete_customer";
            SqlConnection con = db.Con;
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@c_phone_number", SqlDbType.Char).Value = phone;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable LocKhachHangTheoShop(string id)
        {
            string sql = "select distinct Customer.c_phone_number, birthday, c_address, type_cus from CUSTOMER inner join ORDER_LIST on CUSTOMER.c_phone_number = ORDER_LIST.c_phone_number where shop_id = '" + id + "'";
            DataTable result = db.ExecutionQuery(sql);
            return result;
        }
        public DataTable SelectAllKhachHang()
        {
            string sql = "select * from Customer";
            DataTable result = db.ExecutionQuery(sql);
            return result;
        }
    }
    
}
