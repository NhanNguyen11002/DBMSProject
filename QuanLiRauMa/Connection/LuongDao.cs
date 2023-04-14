using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLRauMaVer1.Connection
{
    class LuongDao
    {
        DBConnection db;
        public LuongDao()
        {
            db = new DBConnection();
        }
        public void ThemLuong(string empid, string salary, string shift, string month)
        {
            string sql = "insert into Salary values(" + empid + "," + salary + "," + shift + "," + month + ")";
            db.ExecuteNonQuery(sql);
        }
        public void XoaLuong(string salaryid)
        {
            string sql = "delete from Salary where salary_id =" + salaryid + "";
            db.ExecuteNonQuery(sql);
        }
        public void SuaLuong(string salaryid, string salary, string shift, string month)
        {
            string sql = "update salary set shift_count =" + shift + ",salary_month=" + month + ",salary_amount=" + salary + " where salary_id = " + salaryid + "";
            db.ExecuteNonQuery(sql);
        }
        public DataTable SelectAllPhieuLuong(string shopid)
        {
            string sql = "select salary_id, employee.emp_id, emp_name, emp_role_name, emp_role, salary_month,shift_count, salary_shift, salary_amount" +
                        " from salary inner join employee on salary.emp_id = employee.emp_id inner join emp_role on employee.emp_role = emp_role.emp_role_id" +
                        " where shop_id ='" + shopid + "'";
            DataTable dt = db.ExecutionQuery(sql);
            return dt;
        }
        public DataTable SelectTTNhanVien(string shopid)
        {
            string sql = "select emp_id, emp_name, emp_role, emp_role_name, salary_shift from employee inner join emp_role on employee.emp_role = emp_role.emp_role_id where shop_id='" + shopid + "'";
            DataTable dt = db.ExecutionQuery(sql);
            return dt;
        }
    }
}
