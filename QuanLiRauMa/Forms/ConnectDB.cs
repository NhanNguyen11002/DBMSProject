using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLRauMaVer1.Connection;

namespace QLRauMaVer1.Forms
{
    public partial class ConnectDB : Form
    {
        public static string USER;
        public static string PASS;
        public static string SV_NAME = "localhost";
        
        public ConnectDB()
        {
            InitializeComponent();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            USER = txt_username.Text;
            PASS = txt_pass.Text;
            SV_NAME = txt_cnt.Text;
            
            if (IsServerConnected())
            {
                this.Hide();
                Login form1 = new Login();
                form1.Closed += (s, args) => this.Close();
                form1.Show();
            }
            else
                MessageBox.Show("Kết nối thất bại kiểm tra lại thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ConnectDB_Load(object sender, EventArgs e)
        {
            txt_cnt.Text = SV_NAME;
        }
        private bool IsServerConnected()
        {
            DBConnection db = new DBConnection();
            try
            {
                db.Con.Open();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
            
        }

        private void chkbox_default_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbox_default.Checked == true)
                txt_cnt.ReadOnly = true;
            else
                txt_cnt.ReadOnly = false;
        }
    }
}
