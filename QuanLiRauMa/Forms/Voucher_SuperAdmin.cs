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
    public partial class Voucher_SuperAdmin : Form
    {
        public Voucher_SuperAdmin()
        {
            InitializeComponent();
        }
        public void loadData()
        {
            VoucherDao db = new VoucherDao();
            DataTable dt = db.SelectAllVoucher();
            dtgVoucher.DataSource = dt;
        }
        public void reset()
        {
            idTextbox.Clear();
            valueTextbox.Clear();
            descriptionTextbox.Clear();
            constraintTextbox.Clear();
            filterShopIDTextbox.Clear();
        }
        private void themBtn_Click(object sender, EventArgs e)
        {
            if ((idTextbox.Text == "") || (valueTextbox.Text == "") || (descriptionTextbox.Text == "") || (startDatepicker.Value == null) || (endDatepicker.Value == null) || (constraintTextbox.Text == ""))
            {
                MessageBox.Show("Thông tin không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DialogResult msg = MessageBox.Show("Bạn chắc chắn muốn thêm voucher này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (msg == DialogResult.Yes)
                    {
                        string id = idTextbox.Text;
                        double value = Convert.ToDouble(valueTextbox.Text);
                        string description = descriptionTextbox.Text;
                        string startdate = startDatepicker.Value.ToString("yyyy-MM-dd");
                        string enddate = endDatepicker.Value.ToString("yyyy-MM-dd");
                        string constraint = constraintTextbox.Text;
                        VoucherDao vc = new VoucherDao();
                        vc.ThemVoucher(id, value, description, startdate, enddate, constraint);
                        loadData();
                        reset();
                        MessageBox.Show("Thêm voucher thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if ((idTextbox.Text == ""))
            {
                MessageBox.Show("Hãy nhập mã voucher cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DialogResult msg = MessageBox.Show("Bạn chắc chắn muốn xóa voucher này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (msg == DialogResult.Yes)
                    {
                        string id = idTextbox.Text;
                        double value = Convert.ToDouble(valueTextbox.Text);
                        string description = descriptionTextbox.Text;
                        string startdate = startDatepicker.Value.ToString("yyyy-MM-dd");
                        string enddate = endDatepicker.Value.ToString("yyyy-MM-dd");
                        string constraint = constraintTextbox.Text;
                        VoucherDao vc = new VoucherDao();
                        vc.XoaVoucher(id);
                        loadData();
                        reset();
                        MessageBox.Show("Xóa voucher thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if ((idTextbox.Text == "") || (valueTextbox.Text == "") || (descriptionTextbox.Text == "") || (startDatepicker.Value == null) || (endDatepicker.Value == null) || (constraintTextbox.Text == ""))
            {
                MessageBox.Show("Thông tin không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DialogResult msg = MessageBox.Show("Bạn chắc chắn muốn sửa voucher này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (msg == DialogResult.Yes)
                    {
                        string id = idTextbox.Text;
                        double value = Convert.ToDouble(valueTextbox.Text);
                        string description = descriptionTextbox.Text;
                        string startdate = startDatepicker.Value.ToString("yyyy-MM-dd");
                        string enddate = endDatepicker.Value.ToString("yyyy-MM-dd");
                        string constraint = constraintTextbox.Text;
                        VoucherDao vc = new VoucherDao();
                        vc.SuaVoucher(id, value, description, startdate, enddate, constraint);
                        loadData();
                        reset();
                        MessageBox.Show("Sửa voucher thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            VoucherDao db = new VoucherDao();
            string shopid = filterShopIDTextbox.Text;
            DataTable dt = db.LocVoucherTheoShop(shopid);
            dtgVoucher.DataSource = dt;
            reset();
        }

        private void dtgVoucher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgVoucher.CurrentRow.Index;
            idTextbox.Text = dtgVoucher.Rows[i].Cells[0].Value.ToString();
            valueTextbox.Text = dtgVoucher.Rows[i].Cells[1].Value.ToString();
            descriptionTextbox.Text = dtgVoucher.Rows[i].Cells[2].Value.ToString();
            DateTime startdate = DateTime.Parse(dtgVoucher.Rows[i].Cells[3].Value.ToString());
            startDatepicker.Value = startdate;
            DateTime enddate = DateTime.Parse(dtgVoucher.Rows[i].Cells[4].Value.ToString());
            endDatepicker.Value = enddate;
            constraintTextbox.Text = dtgVoucher.Rows[i].Cells[5].Value.ToString();
        }

        private void Voucher_SuperAdmin_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void homepageBtn_Click(object sender, EventArgs e)
        {
            Home_SuperAdmin home = new Home_SuperAdmin();
            this.Hide();
            home.Show();
        }

        private void capnhatBtn_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
