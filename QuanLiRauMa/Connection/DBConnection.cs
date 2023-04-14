using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLRauMaVer1.Forms;

namespace QLRauMaVer1.Connection
{
    class DBConnection
    {
        public SqlConnection Con;
        public DBConnection()
        {
            string strCon = "Data Source=" + ConnectDB.SV_NAME + "; Database=QuanLiRauMa; " + "user id=" + ConnectDB.USER + "; password=" + ConnectDB.PASS;
            Con = new SqlConnection(strCon);
        }
        public void ExecuteNonQuery(string sql)
        {
            SqlCommand sqlcmd = new SqlCommand(sql, Con);
            Con.Open();
            sqlcmd.ExecuteNonQuery();
            Con.Close();
        }
        public DataTable ExecutionQuery(string sql)
        {
            DataSet dt = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, Con);
            da.Fill(dt);
            return dt.Tables[0];
        }
    }
}
