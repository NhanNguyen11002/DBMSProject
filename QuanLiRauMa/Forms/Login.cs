using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLRauMaVer1.Connection;

namespace QLRauMaVer1.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTextbox.Text;
            string password = passwordTextbox.Text;
            LoginDB login = new LoginDB();
            if (usernameTextbox.Text == "" )
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (passwordTextbox.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (login.checkAccount(username, password) != 0 )
            {
                DataRow dr = login.getAccount(username, password);
                int emp_id = Int32.Parse(dr["emp_id"].ToString());
                string shop_id = dr["shop_id"].ToString();
                int role = login.checkRole(emp_id);
                if (role == 3 || role == 4)
                {
                    NhanVienHome home = new NhanVienHome(emp_id);
                    this.Hide();
                    home.Show();
                }
                else if (role == 2)
                {
                    Home_ThuNgan home = new Home_ThuNgan(shop_id);
                    this.Hide();
                    home.Show();
                }
                else if (role == 1)
                {
                    Home_SuperAdmin home = new Home_SuperAdmin();
                    this.Hide();
                    home.Show();
                }    
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra. Vui lòng kiểm tra lại tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clear();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void clear()
        {
            usernameTextbox.Clear();
            passwordTextbox.Clear();
        }
        private void clearBtn_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
