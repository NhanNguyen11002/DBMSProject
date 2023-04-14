using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLRauMaVer1.Connection
{   //Nhân-----------------------------------------------------------
    class LoginDB
    {
        DBConnection db;
        public LoginDB()
        {
            db = new DBConnection();
        }
        public DataRow getAccount(string username, string password)
        {
            //Lấy empid, shopid
            string sql = "select * from Employee where username = '"+username+"'and password='"+password+"'";
            DataTable dt = db.ExecutionQuery(sql);
            DataRow dr = dt.Rows[0];
            return dr;
        }
        public int checkAccount(string username, string password)
        {
            string sql = "select count(*) as count from Employee where username = '" + username + "'and password='" + password + "'";
            DataTable dt = db.ExecutionQuery(sql);
            DataRow dr = dt.Rows[0];
            int count = Int32.Parse(dr["count"].ToString());
            return count;
        }
        public int checkRole(int emp_id )
        {
            string sql = "select * from Employee where emp_id = '" + emp_id + "'";
            DataTable dt = db.ExecutionQuery(sql);
            DataRow dr = dt.Rows[0];
            return Int32.Parse(dr["emp_role"].ToString());
        }
        public void changePassword(string username, string newpassword)
        {
            string sql = "update employee set password = "+newpassword+" where username ='"+username+"'";
            db.ExecuteNonQuery(sql);
        }
        public bool checkPassword(string username, string oldpassword)
        {
            string sql = "select username, password from employee where username = '"+username+"'";
            DataTable dt = db.ExecutionQuery(sql);
            DataRow dr = dt.Rows[0];
            if (dr["password"].ToString() == oldpassword)
                return true;
            else
                return false;
        }
    }
}
