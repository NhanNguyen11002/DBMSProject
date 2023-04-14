using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLRauMaVer1.Connection
{
    class QLNVDao
    {
        DBConnection db;
        public QLNVDao()
        {
            db = new DBConnection();
        }
        public void ThemNhanVien(string name, string phone, int role, string begindate, string shopid, string username)
        {
            string sql = "add_new_employee";
            SqlConnection con = db.Con;
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@emp_name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.AddWithValue("@phone_number", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.AddWithValue("@emp_role", SqlDbType.Int).Value = role;
            cmd.Parameters.AddWithValue("@begin_date", SqlDbType.Date).Value = begindate;
            cmd.Parameters.AddWithValue("@shop_id", SqlDbType.VarChar).Value = shopid;
            cmd.Parameters.AddWithValue("@username", SqlDbType.VarChar).Value = username;
            cmd.ExecuteNonQuery();
            con.Close();
            //string sql = "insert into Employee values('" + id + "',N'" + name + "',N'" + phone + "'," + role + ",CAST(N'" + begindate + "' AS Date),N'" + shopid + "',N'" + username + "',N'1')";
            //db.ExecuteNonQuery(sql);
        }
        public void SuaNhanVien(int id, string name, string phone, int role, string begindate, string shopid, string username)
        {
            string sql = "edit_employee";
            SqlConnection con = db.Con;
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@emp_id", SqlDbType.Int).Value = id;
            cmd.Parameters.AddWithValue("@emp_name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.AddWithValue("@phone_number", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.AddWithValue("@emp_role", SqlDbType.Int).Value = role;
            cmd.Parameters.AddWithValue("@begin_date", SqlDbType.Date).Value = begindate;
            cmd.Parameters.AddWithValue("@shop_id", SqlDbType.VarChar).Value = shopid;
            cmd.Parameters.AddWithValue("@username", SqlDbType.VarChar).Value = username;
            cmd.ExecuteNonQuery();
            con.Close();
            //string sql = "update Employee set emp_name= N'" + name + "', phone_number= N'" + phone + "',emp_role= " + role + ", begin_date = CAST(N'" + begindate + "' AS Date),shop_id=N'" + shopid + "',username = N'" + username + "' where emp_id='" + id + "'";
            //db.ExecuteNonQuery(sql);
        }
        public void XoaNhanVien(int id)
        {
            string query = "delete_employee";
            SqlConnection con = db.Con;
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@emp_id", SqlDbType.Int).Value = id;
            cmd.ExecuteNonQuery();
            con.Close();
            //string sql = "delete from Employee where emp_id = '" + id + "'";
            //db.ExecuteNonQuery(sql);
        }
        public DataTable SelectAllNhanVien()
        {
            string sql = "select emp_id, emp_name, phone_number,emp_role_name, begin_date, shop_id, username from Employee inner join Emp_Role on Employee.emp_role = Emp_Role.emp_role_id ";
            DataTable result = db.ExecutionQuery(sql);
            return result;
        }
        public DataTable loadroleCbbox()
        {
            string sql = "select * from emp_role";
            DataTable result = db.ExecutionQuery(sql);
            return result;

        }
        public DataTable LocNhanVienTheoShop(string id)
        {
            SqlConnection con = db.Con;
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.show_employee_in_shop(@shop_id)", con);
            cmd.Parameters.AddWithValue("@shop_id", id);
            SqlDataAdapter apt = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            apt.Fill(data);
            return data;
            //string sql = "select emp_id, emp_name, phone_number,emp_role_name, begin_date, shop_id, username from Employee inner join Emp_Role on Employee.emp_role = Emp_Role.emp_role_id where shop_id = '" + id + "'";
            //DataTable result = db.ExecutionQuery(sql);
            //return result;
        }
        //Nhân ------------------------
        public DataRow Select1NhanVien(int emp_id)
        {
            string sql = "select * from employee inner join emp_role on employee.emp_role = emp_role.emp_role_id where emp_id = " + emp_id + "";
            DataTable dt = db.ExecutionQuery(sql);
            DataRow dr = dt.Rows[0];
            return dr;
        }
    }
}