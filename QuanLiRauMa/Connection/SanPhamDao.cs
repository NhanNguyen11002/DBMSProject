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
    class SanPhamDao
    {
        DBConnection db;
        public SanPhamDao()
        {
            db = new DBConnection();
        }
        public void ThemSanPham(string name, double cost, string type, double productioncost)
        {
            string sql = "add_new_product";
            SqlConnection con = db.Con;
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@product_id", SqlDbType.Int).Value = id;
            cmd.Parameters.AddWithValue("@name_product", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.AddWithValue("@cost", SqlDbType.Float).Value = cost;
            cmd.Parameters.AddWithValue("@type", SqlDbType.NVarChar).Value = type;
            cmd.Parameters.AddWithValue("@production_cost", SqlDbType.Float).Value = productioncost;
            cmd.ExecuteNonQuery();
            con.Close();
            //string sql = "insert into Products values('" + id + "',N'" + name + "'," + cost + ",N'" + type + "'," + productioncost + ")";
            //db.ExecuteNonQuery(sql);
        }

        public void ThemSanPhamVaoShop(int productid, string shopid, string status)
        {
            string sql = "add_product_in_shop";
            SqlConnection con = db.Con;
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@product_id", SqlDbType.Int).Value = productid;
            cmd.Parameters.AddWithValue("@shop_id", SqlDbType.VarChar).Value = shopid;
            cmd.Parameters.AddWithValue("@status", SqlDbType.VarChar).Value = status;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void SuaSanPham(int id, string name, double cost, string type, double productioncost)
        {
            string sql = "edit_product";
            SqlConnection con = db.Con;
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@product_id", SqlDbType.Int).Value = id;
            cmd.Parameters.AddWithValue("@name_product", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.AddWithValue("@cost", SqlDbType.Float).Value = cost;
            cmd.Parameters.AddWithValue("@type", SqlDbType.NVarChar).Value = type;
            cmd.Parameters.AddWithValue("@production_cost", SqlDbType.Float).Value = productioncost;
            cmd.ExecuteNonQuery();
            con.Close();
            //string sql = "update Products set product_id='" + id + "', name_product= N'" + name + "', cost=" + cost + ", type=N'" + type + "', production_cost = " + productioncost + " where product_id=" + id + "";
            //db.ExecuteNonQuery(sql);
        }
        public void SuaSanPhamVaoShop(int productid, string shopid, string status)
        {
            string sql = "edit_product_in_shop";
            SqlConnection con = db.Con;
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@product_id", SqlDbType.Int).Value = productid;
            cmd.Parameters.AddWithValue("@shop_id", SqlDbType.VarChar).Value = shopid;
            cmd.Parameters.AddWithValue("@status", SqlDbType.VarChar).Value = status;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void XoaSanPham(int id)
        {
            string sql = "delete_product";
            SqlConnection con = db.Con;
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@product_id", SqlDbType.Int).Value = id;
            cmd.ExecuteNonQuery();
            con.Close();
            //string sql = "delete from Products where product_id = " + id + "";
            //db.ExecuteNonQuery(sql);
        }
        public void XoaSanPhamVaoShop(int productid)
        {
            string sql = "delete_product_in_shop";
            SqlConnection con = db.Con;
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@product_id", SqlDbType.Int).Value = productid;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable SelectAllSanPham()
        {
            string sql = "select * from Products";
            DataTable result = db.ExecutionQuery(sql);
            return result;
        }
        public DataTable SelectAllSanPhamTrongShop()
        {
            string sql = "select * from Product_In_Shop";
            DataTable result = db.ExecutionQuery(sql);
            return result;
        }
        public DataTable SelectAllSanPhamTrong1Shop(string id)
        {
            string sql = "select * from Product_In_Shop where shop_id ='" + id + "'";
            DataTable result = db.ExecutionQuery(sql);
            return result;
        }
        public DataTable LocSanPhamTheoShop(string id)
        {
            string sql = "select distinct Products.product_id, cost, production_cost, name_product, type " +
                "from PRODUCTS inner join PRODUCT_IN_SHOP on Products.product_id = Product_in_shop.product_id " +
                "where shop_id = '" + id + "'";
            DataTable result = db.ExecutionQuery(sql);
            return result;
        }
        //Nhân--------------------------------------------------
        public DataTable ShowMenuInShop (string shopid)
        {
            SqlConnection con = db.Con;
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.show_menu_in_shop(@shop_id)", con);
            cmd.Parameters.AddWithValue("@shop_id", shopid);
            SqlDataAdapter apt = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            apt.Fill(data);
            return data;
        }
        public bool InsertProductInOrder(int order_id, int product_id, int quantity, double price)
        {
            try
            {
                SqlConnection con = db.Con;
                string query = "INSERT INTO order_product VALUES" +
                    "(@order_id,@product_id,@quantity,@price)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@order_id", order_id);
                cmd.Parameters.AddWithValue("@product_id", product_id);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@price", DbType.Double).Value = price;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return false;
        }
    }
}
