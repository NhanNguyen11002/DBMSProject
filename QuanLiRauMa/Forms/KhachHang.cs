﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLRauMaVer1.Connection;

namespace QLRauMaVer1.Forms
{
    public partial class KhachHang : Form
    {
        private string shopid;
        public KhachHang(string shopid)
        {
            InitializeComponent();
            this.shopid = shopid;
        }
        public void loadData()
        {
            KhachHangDAO db = new KhachHangDAO();
            DataTable dt = db.SelectAllKhachHang();
            dtgKhachHang.DataSource = dt;
        }
        public void reset()
        {
            cusPhoneTextbox.Clear();
            cusAddressTextbox.Clear();
            cusTypeTextBox.Clear();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void themBtn_Click(object sender, EventArgs e)
        {
            if ((cusTypeTextBox.Text == "") || (birthdayPicker.Value == null) || (cusAddressTextbox.Text == "") || (cusTypeTextBox.Text == ""))
            {
                MessageBox.Show("Thông tin không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DialogResult msg = MessageBox.Show("Bạn chắc chắn muốn thêm khách hàng này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (msg == DialogResult.Yes)
                    {
                        string phone = cusPhoneTextbox.Text;
                        string birthday = birthdayPicker.Value.ToString("yyyy-MM-dd");
                        string address = cusAddressTextbox.Text;
                        string type = cusTypeTextBox.Text;         
                        KhachHangDAO nv = new KhachHangDAO();
                        nv.ThemKhachHang(phone,birthday,address,type);
                        loadData();
                        reset();
                        MessageBox.Show("Thêm khách thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if ((cusTypeTextBox.Text == "") || (birthdayPicker.Value == null) || (cusAddressTextbox.Text == "") || (cusTypeTextBox.Text == ""))
            {
                MessageBox.Show("Thông tin không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DialogResult msg = MessageBox.Show("Bạn chắc chắn muốn xóa khách hàng này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (msg == DialogResult.Yes)
                    {
                        string phone = cusPhoneTextbox.Text;
                        string birthday = birthdayPicker.Value.ToString("yyyy-MM-dd");
                        string address = cusAddressTextbox.Text;
                        string type = cusTypeTextBox.Text;
                        KhachHangDAO nv = new KhachHangDAO();
                        nv.XoaKhachHang(phone);
                        loadData();
                        reset();
                        MessageBox.Show("Xóa khách thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if ((cusTypeTextBox.Text == "") || (birthdayPicker.Value == null) || (cusAddressTextbox.Text == "") || (cusTypeTextBox.Text == ""))
            {
                MessageBox.Show("Thông tin không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DialogResult msg = MessageBox.Show("Bạn chắc chắn muốn sửa khách hàng này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (msg == DialogResult.Yes)
                    {
                        string phone = cusPhoneTextbox.Text;
                        string birthday = birthdayPicker.Value.ToString("yyyy-MM-dd");
                        string address = cusAddressTextbox.Text;
                        string type = cusTypeTextBox.Text;
                        KhachHangDAO nv = new KhachHangDAO();
                        nv.SuaKhachHang(phone, birthday, address, type);
                        loadData();
                        reset();
                        MessageBox.Show("Sửa khách thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dtgKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgKhachHang.CurrentRow.Index;
            cusPhoneTextbox.Text = dtgKhachHang.Rows[i].Cells[0].Value.ToString();
            string phone = dtgKhachHang.Rows[i].Cells[0].Value.ToString();
            DateTime birthday = DateTime.Parse(dtgKhachHang.Rows[i].Cells[1].Value.ToString());
            birthdayPicker.Value = birthday;
            cusAddressTextbox.Text = dtgKhachHang.Rows[i].Cells[2].Value.ToString();
            cusTypeTextBox.Text = dtgKhachHang.Rows[i].Cells[3].Value.ToString();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void homepageBtn_Click(object sender, EventArgs e)
        {
            Home_ThuNgan home = new Home_ThuNgan(shopid);
            this.Hide();
            home.Show();
        }
    }
}
