using QLRauMaVer1.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLRauMaVer1.Forms
{
    public partial class QLNV : Form
    {
        private string shopid;

        public QLNV(string shopid)
        {
            InitializeComponent();
            this.shopid = shopid;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void loadData()
        {
            QLNVDao db = new QLNVDao();
            DataTable dt = db.LocNhanVienTheoShop(shopid);
            dtgNhanVien.DataSource = dt;
        }
        public void reset()
        {
            empIdTextbox.Clear();
            empNameTextbox.Clear();
            empPhoneTextbox.Clear();
            
            shopIdTextbox.Clear();
            usernameTextbox.Clear();
        }

        private void themBtn_Click(object sender, EventArgs e)
        {
            if ((empNameTextbox.Text == "") || (empPhoneTextbox.Text == "") || (empRoleCbbox.SelectedItem == null) || (beginDatepicker.Value == null) || (shopIdTextbox.Text == "") || (usernameTextbox.Text == ""))
            {
                MessageBox.Show("Thông tin không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DialogResult msg = MessageBox.Show("Bạn chắc chắn muốn thêm nhân viên này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (msg == DialogResult.Yes)
                    {
                        //int id = Convert.ToInt32(empIdTextbox.Text);
                        string name = empNameTextbox.Text;
                        string phone = empPhoneTextbox.Text;
                        int role = empRoleCbbox.SelectedIndex+1;
                        string begindate = beginDatepicker.Value.ToString("yyyy-MM-dd");
                        string shopid = shopIdTextbox.Text;
                        string username = usernameTextbox.Text;
                        QLNVDao nv = new QLNVDao();
                        nv.ThemNhanVien(name,phone,role,begindate,shopid,username);
                        loadData();
                        reset();
                        MessageBox.Show("Thêm nhân viên thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void xoaBtn_Click(object sender, EventArgs e)
        {
            if ((empIdTextbox.Text == ""))
            {
                MessageBox.Show("Hãy nhập mã nhân viên cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DialogResult msg = MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (msg == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(empIdTextbox.Text);
                        string name = empNameTextbox.Text;
                        string phone = empPhoneTextbox.Text;
                        int role = empRoleCbbox.SelectedIndex;
                        string begindate = beginDatepicker.Value.ToString("yyyy-MM-dd");
                        string shopid = shopIdTextbox.Text;
                        string username = usernameTextbox.Text;
                        QLNVDao nv = new QLNVDao();
                        nv.XoaNhanVien(id);
                        loadData();
                        reset();
                        MessageBox.Show("Xóa nhân viên thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void suaBtn_Click(object sender, EventArgs e)
        {
            if ((empNameTextbox.Text == "") || (empPhoneTextbox.Text == "") || (empRoleCbbox.SelectedItem == null)  || (shopIdTextbox.Text == "") || (usernameTextbox.Text == ""))
            {
                MessageBox.Show("Thông tin không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DialogResult msg = MessageBox.Show("Bạn chắc chắn muốn sửa thông tin nhân viên này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (msg == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(empIdTextbox.Text);
                        string name = empNameTextbox.Text;
                        string phone = empPhoneTextbox.Text;
                        int role = empRoleCbbox.SelectedIndex +1;
                        string begindate = beginDatepicker.Value.ToString("yyyy-MM-dd");
                        string shopid = shopIdTextbox.Text;
                        string username = usernameTextbox.Text;
                        QLNVDao nv = new QLNVDao();
                        nv.SuaNhanVien(id, name, phone, role, begindate, shopid, username);
                        loadData();
                        reset();
                        MessageBox.Show("Sửa nhân viên thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dtgNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgNhanVien.CurrentRow.Index;
            empIdTextbox.Text = dtgNhanVien.Rows[i].Cells[0].Value.ToString();
            empNameTextbox.Text = dtgNhanVien.Rows[i].Cells[1].Value.ToString();
            empPhoneTextbox.Text = dtgNhanVien.Rows[i].Cells[2].Value.ToString();
            empRoleCbbox.Text = dtgNhanVien.Rows[i].Cells[3].Value.ToString();
            DateTime begindate = DateTime.Parse(dtgNhanVien.Rows[i].Cells[4].Value.ToString());
            beginDatepicker.Value = begindate;
            
            shopIdTextbox.Text = dtgNhanVien.Rows[i].Cells[5].Value.ToString();
            usernameTextbox.Text = dtgNhanVien.Rows[i].Cells[6].Value.ToString();

        }
        private void loadroleCbbox()
        {
            
        }
        private void QLNV_Load(object sender, EventArgs e)
        {
            loadData();
            //loadroleCbbox();
        }

        private void empRoleCbbox_DropDown(object sender, EventArgs e)
        {
            QLNVDao nv = new QLNVDao();
            empRoleCbbox.DataSource = nv.loadroleCbbox();
            empRoleCbbox.DisplayMember = "emp_role_name";
            empRoleCbbox.ValueMember = "emp_role_id";

        }

        private void homepageBtn_Click(object sender, EventArgs e)
        {
            Home_ThuNgan home = new Home_ThuNgan(shopid);
            this.Hide();
            home.Show();
        }
    }
}
