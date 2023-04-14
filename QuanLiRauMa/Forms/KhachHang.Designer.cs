
namespace QLRauMaVer1.Forms
{
    partial class KhachHang
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
            this.dtgKhachHang = new System.Windows.Forms.DataGridView();
            this.customerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.themBtn = new System.Windows.Forms.Button();
            this.suaBtn = new System.Windows.Forms.Button();
            this.xoaBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.birthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.cusTypeTextBox = new System.Windows.Forms.TextBox();
            this.cusAddressTextbox = new System.Windows.Forms.TextBox();
            this.cusPhoneTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.homepageBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKhachHang)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgKhachHang
            // 
            this.dtgKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerPhone,
            this.customerBirthday,
            this.customerAddress,
            this.customerType});
            this.dtgKhachHang.Location = new System.Drawing.Point(23, 51);
            this.dtgKhachHang.Name = "dtgKhachHang";
            this.dtgKhachHang.RowHeadersWidth = 51;
            this.dtgKhachHang.RowTemplate.Height = 24;
            this.dtgKhachHang.Size = new System.Drawing.Size(521, 359);
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
            this.themBtn.Location = new System.Drawing.Point(36, 434);
            this.themBtn.Name = "themBtn";
            this.themBtn.Size = new System.Drawing.Size(158, 63);
            this.themBtn.TabIndex = 2;
            this.themBtn.Text = "Thêm";
            this.themBtn.UseVisualStyleBackColor = true;
            this.themBtn.Click += new System.EventHandler(this.themBtn_Click);
            // 
            // suaBtn
            // 
            this.suaBtn.Font = new System.Drawing.Font("VNF-Comic Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suaBtn.Location = new System.Drawing.Point(386, 434);
            this.suaBtn.Name = "suaBtn";
            this.suaBtn.Size = new System.Drawing.Size(158, 63);
            this.suaBtn.TabIndex = 1;
            this.suaBtn.Text = "Sửa";
            this.suaBtn.UseVisualStyleBackColor = true;
            this.suaBtn.Click += new System.EventHandler(this.suaBtn_Click);
            // 
            // xoaBtn
            // 
            this.xoaBtn.Font = new System.Drawing.Font("VNF-Comic Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoaBtn.Location = new System.Drawing.Point(213, 434);
            this.xoaBtn.Name = "xoaBtn";
            this.xoaBtn.Size = new System.Drawing.Size(158, 63);
            this.xoaBtn.TabIndex = 0;
            this.xoaBtn.Text = "Xóa";
            this.xoaBtn.UseVisualStyleBackColor = true;
            this.xoaBtn.Click += new System.EventHandler(this.xoaBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel1.Controls.Add(this.homepageBtn);
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
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 553);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // birthdayPicker
            // 
            this.birthdayPicker.Font = new System.Drawing.Font("VNF-Comic Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthdayPicker.Location = new System.Drawing.Point(656, 181);
            this.birthdayPicker.Name = "birthdayPicker";
            this.birthdayPicker.Size = new System.Drawing.Size(215, 33);
            this.birthdayPicker.TabIndex = 14;
            // 
            // cusTypeTextBox
            // 
            this.cusTypeTextBox.Font = new System.Drawing.Font("VNF-Comic Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusTypeTextBox.Location = new System.Drawing.Point(656, 317);
            this.cusTypeTextBox.Name = "cusTypeTextBox";
            this.cusTypeTextBox.Size = new System.Drawing.Size(215, 32);
            this.cusTypeTextBox.TabIndex = 10;
            // 
            // cusAddressTextbox
            // 
            this.cusAddressTextbox.Font = new System.Drawing.Font("VNF-Comic Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusAddressTextbox.Location = new System.Drawing.Point(656, 249);
            this.cusAddressTextbox.Name = "cusAddressTextbox";
            this.cusAddressTextbox.Size = new System.Drawing.Size(215, 32);
            this.cusAddressTextbox.TabIndex = 9;
            // 
            // cusPhoneTextbox
            // 
            this.cusPhoneTextbox.Font = new System.Drawing.Font("VNF-Comic Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusPhoneTextbox.Location = new System.Drawing.Point(656, 110);
            this.cusPhoneTextbox.Name = "cusPhoneTextbox";
            this.cusPhoneTextbox.Size = new System.Drawing.Size(215, 32);
            this.cusPhoneTextbox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("VNF-Comic Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(564, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Loại KH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("VNF-Comic Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(564, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("VNF-Comic Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(564, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sinh nhật";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("VNF-Comic Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(564, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "SĐT";
            // 
            // homepageBtn
            // 
            this.homepageBtn.Font = new System.Drawing.Font("VNF-Comic Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homepageBtn.Location = new System.Drawing.Point(23, 11);
            this.homepageBtn.Name = "homepageBtn";
            this.homepageBtn.Size = new System.Drawing.Size(158, 32);
            this.homepageBtn.TabIndex = 15;
            this.homepageBtn.Text = "Trang chủ";
            this.homepageBtn.UseVisualStyleBackColor = true;
            this.homepageBtn.Click += new System.EventHandler(this.homepageBtn_Click);
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "KhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KhachHang";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgKhachHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgKhachHang;
        private System.Windows.Forms.Button themBtn;
        private System.Windows.Forms.Button suaBtn;
        private System.Windows.Forms.Button xoaBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox cusTypeTextBox;
        private System.Windows.Forms.TextBox cusAddressTextbox;
        private System.Windows.Forms.TextBox cusPhoneTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker birthdayPicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerType;
        private System.Windows.Forms.Button homepageBtn;
    }
}