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
    public partial class Luong : Form
    {
        private string shopid;
        LuongDao luongDB = new LuongDao();
        public Luong(string shopid)
        {
            InitializeComponent();
            this.shopid = shopid;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void loadData()
        {
            dtgLuong.DataSource = luongDB.SelectAllPhieuLuong(shopid);
        }
        private void reset()
        {
            salaryidTextbox.Clear();
            empidTextbox.Clear();
            empnameTextbox.Clear();
            emproleTextbox.Clear();
            shiftTextbox.Clear();
            monthTextbox.Clear();
            salaryTextbox.Clear();
            salaryshiftTextbox.Clear();
        }

        private void themBtn_Click(object sender, EventArgs e)
        {
            if ((empidTextbox.Text == "") || (empnameTextbox.Text == null) || (emproleTextbox.Text == "") || (shiftTextbox.Text == "") || (monthTextbox.Text == "") || (salaryTextbox.Text == ""))
            {
                MessageBox.Show("Thông tin không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DialogResult msg = MessageBox.Show("Bạn chắc chắn muốn thêm phiếu lương này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (msg == DialogResult.Yes)
                    {
                        string empid = empidTextbox.Text;
                        string salary = salaryTextbox.Text;
                        string shift = shiftTextbox.Text;
                        string month = monthTextbox.Text;
                        LuongDao luong = new LuongDao();
                        luong.ThemLuong(empid, salary, shift, month);
                        loadData();
                        reset();
                        MessageBox.Show("Thêm phiêu lương thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void calculateBtn_Click_1(object sender, EventArgs e)
        {
            if ((shiftTextbox.Text == ""))
            {
                MessageBox.Show("Vui lòng nhập số ca!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int salary = Int32.Parse(salaryshiftTextbox.Text) * Int32.Parse(shiftTextbox.Text);
                salaryTextbox.Text = salary.ToString();
            }
        }

        private void dtgLuong_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgLuong.CurrentRow.Index;
            salaryidTextbox.Text = dtgLuong.Rows[i].Cells[0].Value.ToString();
            empidTextbox.Text = dtgLuong.Rows[i].Cells[1].Value.ToString();
            empnameTextbox.Text = dtgLuong.Rows[i].Cells[2].Value.ToString();
            emproleTextbox.Text = dtgLuong.Rows[i].Cells[3].Value.ToString();
            monthTextbox.Text = dtgLuong.Rows[i].Cells[5].Value.ToString();
            shiftTextbox.Text = dtgLuong.Rows[i].Cells[6].Value.ToString();
            salaryshiftTextbox.Text = dtgLuong.Rows[i].Cells[7].Value.ToString();
            salaryTextbox.Text = dtgLuong.Rows[i].Cells[8].Value.ToString();
        }

        private void Luong_Load_1(object sender, EventArgs e)
        {
            loadData();
            dtgNhanVien.DataSource = luongDB.SelectTTNhanVien(shopid);
        }

        private void dtgNhanVien_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgNhanVien.CurrentRow.Index;
            empidTextbox.Text = dtgNhanVien.Rows[i].Cells[0].Value.ToString();
            empnameTextbox.Text = dtgNhanVien.Rows[i].Cells[1].Value.ToString();
            emproleTextbox.Text = dtgNhanVien.Rows[i].Cells[3].Value.ToString();
            salaryshiftTextbox.Text = dtgNhanVien.Rows[i].Cells[4].Value.ToString();
            //
            salaryidTextbox.Clear();
            shiftTextbox.Clear();
            monthTextbox.Clear();
            salaryTextbox.Clear();
        }

        private void clearBtn_Click_1(object sender, EventArgs e)
        {
            reset();
        }

        private void xoaBtn_Click_1(object sender, EventArgs e)
        {
            if ((salaryidTextbox.Text == "") || (empidTextbox.Text == "") || (empnameTextbox.Text == null) || (emproleTextbox.Text == "") || (shiftTextbox.Text == "") || (monthTextbox.Text == "") || (salaryTextbox.Text == ""))
            {
                MessageBox.Show("Thông tin không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DialogResult msg = MessageBox.Show("Bạn chắc chắn muốn xóa phiếu lương này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (msg == DialogResult.Yes)
                    {
                        string salaryid = salaryidTextbox.Text;
                        LuongDao luong = new LuongDao();
                        luong.XoaLuong(salaryid);
                        loadData();
                        reset();
                        MessageBox.Show("Xóa phiếu lương thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void suaBtn_Click_1(object sender, EventArgs e)
        {
            if ((salaryidTextbox.Text == "") || (empidTextbox.Text == "") || (empnameTextbox.Text == null) || (emproleTextbox.Text == "") || (shiftTextbox.Text == "") || (monthTextbox.Text == "") || (salaryTextbox.Text == ""))
            {
                MessageBox.Show("Thông tin không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DialogResult msg = MessageBox.Show("Bạn chắc chắn muốn sửa phiếu lương này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (msg == DialogResult.Yes)
                    {
                        string salaryid = salaryidTextbox.Text;
                        string salary = salaryTextbox.Text;
                        string shift = shiftTextbox.Text;
                        string month = monthTextbox.Text;
                        LuongDao luong = new LuongDao();
                        luong.SuaLuong(salaryid, salary, shift, month);
                        loadData();
                        reset();
                        MessageBox.Show("Sửa phiếu lương thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void homepageBtn_Click(object sender, EventArgs e)
        {
            Home_ThuNgan home = new Home_ThuNgan(shopid);
            this.Hide();
            home.Show();
        }
    }
}
