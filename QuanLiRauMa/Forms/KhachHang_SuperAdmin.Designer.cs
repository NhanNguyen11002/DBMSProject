
namespace QLRauMaVer1.Forms
{
    partial class KhachHang_SuperAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.birthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.cusTypeTextBox = new System.Windows.Forms.TextBox();
            this.cusAddressTextbox = new System.Windows.Forms.TextBox();
            this.cusPhoneTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.homepageBtn = new System.Windows.Forms.Button();
            this.filterBtn = new System.Windows.Forms.Button();
            this.filterShopIDTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgKhachHang = new System.Windows.Forms.DataGridView();
            this.customerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.themBtn = new System.Windows.Forms.Button();
            this.suaBtn = new System.Windows.Forms.Button();
            this.xoaBtn = new System.Windows.Forms.Button();
            this.capnhatBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // birthdayPicker
            // 
            this.birthdayPicker.Font = new System.Drawing.Font("VNF-Comic Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthdayPicker.Location = new System.Drawing.Point(738, 170);
            this.birthdayPicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.birthdayPicker.Name = "birthdayPicker";
            this.birthdayPicker.Size = new System.Drawing.Size(241, 38);
            this.birthdayPicker.TabIndex = 14;
            // 
            // cusTypeTextBox
            // 
            this.cusTypeTextBox.Font = new System.Drawing.Font("VNF-Comic Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusTypeTextBox.Location = new System.Drawing.Point(738, 340);
            this.cusTypeTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cusTypeTextBox.Name = "cusTypeTextBox";
            this.cusTypeTextBox.Size = new System.Drawing.Size(241, 37);
            this.cusTypeTextBox.TabIndex = 10;
            // 
            // cusAddressTextbox
            // 
            this.cusAddressTextbox.Font = new System.Drawing.Font("VNF-Comic Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusAddressTextbox.Location = new System.Drawing.Point(738, 255);
            this.cusAddressTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cusAddressTextbox.Name = "cusAddressTextbox";
            this.cusAddressTextbox.Size = new System.Drawing.Size(241, 37);
            this.cusAddressTextbox.TabIndex = 9;
            // 
            // cusPhoneTextbox
            // 
            this.cusPhoneTextbox.Font = new System.Drawing.Font("VNF-Comic Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusPhoneTextbox.Location = new System.Drawing.Point(738, 81);
            this.cusPhoneTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cusPhoneTextbox.Name = "cusPhoneTextbox";
            this.cusPhoneTextbox.Size = new System.Drawing.Size(241, 37);
            this.cusPhoneTextbox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("VNF-Comic Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(634, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Loại KH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("VNF-Comic Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(634, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("VNF-Comic Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(634, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sinh nhật";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("VNF-Comic Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(634, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "SĐT";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel1.Controls.Add(this.capnhatBtn);
            this.panel1.Controls.Add(this.homepageBtn);
            this.panel1.Controls.Add(this.filterBtn);
            this.panel1.Controls.Add(this.filterShopIDTextbox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.birthdayPicker);
            this.panel1.Controls.Add(this.cusTypeTextBox);
            this.panel1.Controls.Add(this.cusAddressTextbox);
            this.panel1.Controls.Add(this.cusPhoneTextbox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtgKhachHang);
            this.panel1.Controls.Add(this.themBtn);
            this.panel1.Controls.Add(this.suaBtn);
            this.panel1.Controls.Add(this.xoaBtn);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 691);
            this.panel1.TabIndex = 2;
            // 
            // homepageBtn
            // 
            this.homepageBtn.Font = new System.Drawing.Font("VNF-Comic Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homepageBtn.Location = new System.Drawing.Point(40, 15);
            this.homepageBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.homepageBtn.Name = "homepageBtn";
            this.homepageBtn.Size = new System.Drawing.Size(153, 40);
            this.homepageBtn.TabIndex = 18;
            this.homepageBtn.Text = "Trang chủ";
            this.homepageBtn.UseVisualStyleBackColor = true;
            this.homepageBtn.Click += new System.EventHandler(this.homepageBtn_Click);
            // 
            // filterBtn
            // 
            this.filterBtn.Font = new System.Drawing.Font("VNF-Comic Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterBtn.Location = new System.Drawing.Point(640, 542);
            this.filterBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(178, 79);
            this.filterBtn.TabIndex = 17;
            this.filterBtn.Text = "Lọc";
            this.filterBtn.UseVisualStyleBackColor = true;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // filterShopIDTextbox
            // 
            this.filterShopIDTextbox.Font = new System.Drawing.Font("VNF-Comic Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterShopIDTextbox.Location = new System.Drawing.Point(738, 454);
            this.filterShopIDTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filterShopIDTextbox.Name = "filterShopIDTextbox";
            this.filterShopIDTextbox.Size = new System.Drawing.Size(241, 37);
            this.filterShopIDTextbox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("VNF-Comic Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(634, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 31);
            this.label5.TabIndex = 15;
            this.label5.Text = "ShopID";
            // 
            // dtgKhachHang
            // 
            this.dtgKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerPhone,
            this.customerBirthday,
            this.customerAddress,
            this.customerType});
            this.dtgKhachHang.Location = new System.Drawing.Point(26, 81);
            this.dtgKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgKhachHang.Name = "dtgKhachHang";
            this.dtgKhachHang.RowHeadersWidth = 51;
            this.dtgKhachHang.RowTemplate.Height = 24;
            this.dtgKhachHang.Size = new System.Drawing.Size(586, 431);
            this.dtgKhachHang.TabIndex = 3;
            this.dtgKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgKhachHang_CellContentClick);
            // 
            // customerPhone
            // 
            this.customerPhone.DataPropertyName = "c_phone_number";
            this.customerPhone.HeaderText = "Số điện thoại";
            this.customerPhone.MinimumWidth = 6;
            this.customerPhone.Name = "customerPhone";
            this.customerPhone.ReadOnly = true;
            this.customerPhone.Width = 125;
            // 
            // customerBirthday
            // 
            this.customerBirthday.DataPropertyName = "birthday";
            this.customerBirthday.HeaderText = "Sinh nhật";
            this.customerBirthday.MinimumWidth = 6;
            this.customerBirthday.Name = "customerBirthday";
            this.customerBirthday.ReadOnly = true;
            this.customerBirthday.Width = 125;
            // 
            // customerAddress
            // 
            this.customerAddress.DataPropertyName = "c_address";
            this.customerAddress.HeaderText = "Địa chỉ";
            this.customerAddress.MinimumWidth = 6;
            this.customerAddress.Name = "customerAddress";
            this.customerAddress.ReadOnly = true;
            this.customerAddress.Width = 125;
            // 
            // customerType
            // 
            this.customerType.DataPropertyName = "type_cus";
            this.customerType.HeaderText = "Loại khách hàng";
            this.customerType.MinimumWidth = 6;
            this.customerType.Name = "customerType";
            this.customerType.ReadOnly = true;
            this.customerType.Width = 125;
            // 
            // themBtn
            // 
            this.themBtn.Font = new System.Drawing.Font("VNF-Comic Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themBtn.Location = new System.Drawing.Point(40, 542);
            this.themBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.themBtn.Name = "themBtn";
            this.themBtn.Size = new System.Drawing.Size(178, 79);
            this.themBtn.TabIndex = 2;
            this.themBtn.Text = "Thêm";
            this.themBtn.UseVisualStyleBackColor = true;
            this.themBtn.Click += new System.EventHandler(this.themBtn_Click);
            // 
            // suaBtn
            // 
            this.suaBtn.Font = new System.Drawing.Font("VNF-Comic Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suaBtn.Location = new System.Drawing.Point(434, 542);
            this.suaBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.suaBtn.Name = "suaBtn";
            this.suaBtn.Size = new System.Drawing.Size(178, 79);
            this.suaBtn.TabIndex = 1;
            this.suaBtn.Text = "Sửa";
            this.suaBtn.UseVisualStyleBackColor = true;
            this.suaBtn.Click += new System.EventHandler(this.suaBtn_Click);
            // 
            // xoaBtn
            // 
            this.xoaBtn.Font = new System.Drawing.Font("VNF-Comic Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoaBtn.Location = new System.Drawing.Point(240, 542);
            this.xoaBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xoaBtn.Name = "xoaBtn";
            this.xoaBtn.Size = new System.Drawing.Size(178, 79);
            this.xoaBtn.TabIndex = 0;
            this.xoaBtn.Text = "Xóa";
            this.xoaBtn.UseVisualStyleBackColor = true;
            this.xoaBtn.Click += new System.EventHandler(this.xoaBtn_Click);
            // 
            // capnhatBtn
            // 
            this.capnhatBtn.Font = new System.Drawing.Font("VNF-Comic Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capnhatBtn.Location = new System.Drawing.Point(816, 542);
            this.capnhatBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.capnhatBtn.Name = "capnhatBtn";
            this.capnhatBtn.Size = new System.Drawing.Size(178, 79);
            this.capnhatBtn.TabIndex = 19;
            this.capnhatBtn.Text = "Cập nhật";
            this.capnhatBtn.UseVisualStyleBackColor = true;
            this.capnhatBtn.Click += new System.EventHandler(this.capnhatBtn_Click);
            // 
            // KhachHang_SuperAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 691);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "KhachHang_SuperAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KhachHang_SuperAdmin";
            this.Load += new System.EventHandler(this.KhachHang_SuperAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker birthdayPicker;
        private System.Windows.Forms.TextBox cusTypeTextBox;
        private System.Windows.Forms.TextBox cusAddressTextbox;
        private System.Windows.Forms.TextBox cusPhoneTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox filterShopIDTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerType;
        private System.Windows.Forms.Button themBtn;
        private System.Windows.Forms.Button suaBtn;
        private System.Windows.Forms.Button xoaBtn;
        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.Button homepageBtn;
        private System.Windows.Forms.Button capnhatBtn;
    }
}