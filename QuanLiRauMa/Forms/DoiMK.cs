using QLRauMaVer1.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLRauMaVer1.Forms
{
    public partial class DoiMK : Form
    {
        private int emp_id;
        public DoiMK(int emp_id)
        {
            InitializeComponent();
            this.emp_id = emp_id;
        }
        private void clear()
        {
            usernameTextbox.Clear();
            oldpassTextbox.Clear();
            typeTextbox.Clear();
            retypeTextbox.Clear();
        }
        private void doimkBtn_Click(object sender, EventArgs e)
        {
            LoginDB login = new LoginDB();
            string username = usernameTextbox.Text;
            string oldpass = oldpassTextbox.Text;
            string newpass = typeTextbox.Text;
            string newpass2 = retypeTextbox.Text;
            if (username == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (oldpass == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu cũ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (newpass == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (newpass2 == "")
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu mới!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!login.checkPassword(username,oldpass))
            {
                MessageBox.Show("Nhập sai mật khẩu cũ, vui lòng nhập lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                oldpassTextbox.Clear();
            }
            else if (newpass2 != newpass)
            {
                MessageBox.Show("Nhập lại mật khẩu mới không đúng, vui lòng nhập lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                retypeTextbox.Clear();
            }
            else
            {
                try
                {
                    DialogResult msg = MessageBox.Show("Bạn chắc chắn muốn đổi mật khẩu?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (msg == DialogResult.Yes)
                    {
                        login.changePassword(username, newpass);
                        clear();
                        MessageBox.Show("Đổi mật khẩu thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void homepageBtn_Click(object sender, EventArgs e)
        {
            NhanVienHome home = new NhanVienHome(emp_id);
            this.Hide();
            home.Show();
        }
    }
}
