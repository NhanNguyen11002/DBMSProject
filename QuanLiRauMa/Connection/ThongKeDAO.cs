using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLRauMaVer1.Connection
{
    class ThongKeDAO
    {
        DBConnection db;
        public ThongKeDAO()
        {
            db = new DBConnection();
        }

        public DataTable ShowShop()
        {
            string strSQL = "Select * from SHOP";
            DataTable dt = db.ExecutionQuery(strSQL);
            return dt;
        }

        //public DataTable VD1()
        //{
        //    try
        //    {
        //        string query = "SELECT * FROM over_1_month_work";
        //        SqlDataAdapter apt = new SqlDataAdapter(query, sqlCnt);
        //        DataTable dataTable = new DataTable();
        //        apt.Fill(dataTable);
        //        return dataTable;
        //    }
        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    return null;
        //}

        public DataTable Shop_MBDN_Cost(string shop_id)
        {
            SqlConnection conn = db.Con;
            try
            {
                string query = "Shop_MBDN";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@shop_id", shop_id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public DataTable UnpaidPayment(string shop_id)
        {
            SqlConnection conn = db.Con;
            try
            {
                string query = "Unpaid_Payment";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@shop_id", shop_id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public DataTable ValidVoucher()
        {
            SqlConnection conn = db.Con;
            try
            {
                string query = "Select * from Valid_Voucher()";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public DataTable LuongShopMonth(string shop_id)
        {
            SqlConnection conn = db.Con;
            try
            {
                string query = "Select * from Func_LuongShop_Month('"+shop_id+"')";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public DataTable DoanhThu(string shop_id)
        {
            SqlConnection conn = db.Con;
            try
            {
                string query = "Doanh_Thu_Month";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@shop_id", shop_id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public DataTable LoiNhuan(string shop_id)
        {
            SqlConnection conn = db.Con;
            try
            {
                string query = "Select * from INCOME_Month('" + shop_id + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public DataTable empOverOneMonth()
        {
            SqlConnection sqlCnt = db.Con;
            try
            {
                string query = "SELECT * FROM Over1MonthWork";
                SqlDataAdapter apt = new SqlDataAdapter(query, sqlCnt);
                DataTable dataTable = new DataTable();
                apt.Fill(dataTable);
                return dataTable;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public DataTable show3MonthNearestFee()
        {
            SqlConnection sqlCnt = db.Con;
            try
            {
                string query = "SELECT * FROM Fee";
                SqlDataAdapter apt = new SqlDataAdapter(query, sqlCnt);
                DataTable data = new DataTable();
                apt.Fill(data);
                return data;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public DataTable showHcmShop()
        {
            SqlConnection sqlCnt = db.Con;
            try
            {
                string query = "SELECT * FROM HCMShop";
                SqlDataAdapter apt = new SqlDataAdapter(query, sqlCnt);
                DataTable data = new DataTable();
                apt.Fill(data);
                return data;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public DataTable Top5BestProduct(string shop_id)
        {
            SqlConnection conn = db.Con;
            try
            {
                string query = "Select * from Top5BestProduct('" + shop_id + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public DataTable SoldProductToday(string shop_id)
        {
            SqlConnection conn = db.Con;
            try
            {
                string query = "Select * from SoldProductToday('" + shop_id + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
    }
}
