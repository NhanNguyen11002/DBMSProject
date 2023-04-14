
namespace QLRauMaVer1.Forms
{
    partial class QLNV
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
            this.dtgNhanVien = new System.Windows.Forms.DataGridView();
            this.empId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beginDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.themBtn = new System.Windows.Forms.Button();
            this.suaBtn = new System.Windows.Forms.Button();
            this.xoaBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.homepageBtn = new System.Windows.Forms.Button();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.empRoleCbbox = new System.Windows.Forms.ComboBox();
            this.shopIdTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.empPhoneTextbox = new System.Windows.Forms.TextBox();
            this.empNameTextbox = new System.Windows.Forms.TextBox();
            this.beginDatepicker = new System.Windows.Forms.DateTimePicker();
            this.empIdTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhanVien)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgNhanVien
            // 
            this.dtgNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empId,
            this.empName,
            this.empPhone,
            this.empRole,
            this.beginDate,
            this.shopId,
            this.username});
            this.dtgNhanVien.Location = new System.Drawing.Point(60, 142);
            this.dtgNhanVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgNhanVien.Name = "dtgNhanVien";
            this.dtgNhanVien.RowHeadersWidth = 51;
            this.dtgNhanVien.RowTemplate.Height = 24;
            this.dtgNhanVien.Size = new System.Drawing.Size(778, 534);
            this.dtgNhanVien.TabIndex = 3;
            this.dtgNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgNhanVien_CellContentClick);
            // 
            // empId
            // 
            this.empId.DataPropertyName = "emp_id";
            this.empId.HeaderText = "Mã nhân viên";
            this.empId.MinimumWidth = 6;
            this.empId.Name = "empId";
            this.empId.ReadOnly = true;
            this.empId.Width = 125;
            // 
            // empName
            // 
            this.empName.DataPropertyName = "emp_name";
            this.empName.HeaderText = "Tên nhân viên";
            this.empName.MinimumWidth = 6;
            this.empName.Name = "empName";
            this.empName.ReadOnly = true;
            this.empName.Width = 135;
            // 
            // empPhone
            // 
            this.empPhone.DataPropertyName = "phone_number";
            this.empPhone.HeaderText = "Số điện thoại";
            this.empPhone.MinimumWidth = 6;
            this.empPhone.Name = "empPhone";
            this.empPhone.ReadOnly = true;
            this.empPhone.Width = 125;
            // 
            // empRole
            // 
            this.empRole.DataPropertyName = "emp_role_name";
            this.empRole.HeaderText = "Vị trí";
            this.empRole.MinimumWidth = 6;
            this.empRole.Name = "empRole";
            this.empRole.ReadOnly = true;
            this.empRole.Width = 125;
            // 
            // beginDate
            // 
            this.beginDate.DataPropertyName = "begin_date";
            this.beginDate.HeaderText = "Ngày bắt đầu";
            this.beginDate.MinimumWidth = 6;
            this.beginDate.Name = "beginDate";
            this.beginDate.ReadOnly = true;
            this.beginDate.Width = 125;
            // 
            // shopId
            // 
            this.shopId.DataPropertyName = "shop_id";
            this.shopId.HeaderText = "Mã shop";
            this.shopId.MinimumWidth = 6;
            this.shopId.Name = "shopId";
            this.shopId.ReadOnly = true;
            this.shopId.Width = 125;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "Tên tài khoản";
            this.username.MinimumWidth = 8;
            this.username.Name = "username";
            this.username.Width = 150;
            // 
            // themBtn
            // 
            this.themBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themBtn.Location = new System.Drawing.Point(98, 699);
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
            this.suaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suaBtn.Location = new System.Drawing.Point(601, 699);
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
            this.xoaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoaBtn.Location = new System.Drawing.Point(352, 699);
            this.xoaBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xoaBtn.Name = "xoaBtn";
            this.xoaBtn.Size = new System.Drawing.Size(178, 79);
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
            this.panel1.Controls.Add(this.usernameTextbox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.empRoleCbbox);
            this.panel1.Controls.Add(this.shopIdTextbox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.empPhoneTextbox);
            this.panel1.Controls.Add(this.empNameTextbox);
            this.panel1.Controls.Add(this.beginDatepicker);
            this.panel1.Controls.Add(this.empIdTextbox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtgNhanVien);
            this.panel1.Controls.Add(this.themBtn);
            this.panel1.Controls.Add(this.suaBtn);
            this.panel1.Controls.Add(this.xoaBtn);
            this.panel1.Location = new System.Drawing.Point(-46, -64);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1422, 882);
            this.panel1.TabIndex = 1;
            // 
            // homepageBtn
            // 
            this.homepageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homepageBtn.Location = new System.Drawing.Point(60, 79);
            this.homepageBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.homepageBtn.Name = "homepageBtn";
            this.homepageBtn.Size = new System.Drawing.Size(209, 39);
            this.homepageBtn.TabIndex = 19;
            this.homepageBtn.Text = "Trang chủ";
            this.homepageBtn.UseVisualStyleBackColor = true;
            this.homepageBtn.Click += new System.EventHandler(this.homepageBtn_Click);
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextbox.Location = new System.Drawing.Point(1042, 614);
            this.usernameTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(285, 30);
            this.usernameTextbox.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(904, 615);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tên tài khoản";
            // 
            // empRoleCbbox
            // 
            this.empRoleCbbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empRoleCbbox.FormattingEnabled = true;
            this.empRoleCbbox.Location = new System.Drawing.Point(1042, 390);
            this.empRoleCbbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.empRoleCbbox.Name = "empRoleCbbox";
            this.empRoleCbbox.Size = new System.Drawing.Size(285, 34);
            this.empRoleCbbox.TabIndex = 16;
            this.empRoleCbbox.DropDown += new System.EventHandler(this.empRoleCbbox_DropDown);
            // 
            // shopIdTextbox
            // 
            this.shopIdTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopIdTextbox.Location = new System.Drawing.Point(1042, 544);
            this.shopIdTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.shopIdTextbox.Name = "shopIdTextbox";
            this.shopIdTextbox.Size = new System.Drawing.Size(285, 31);
            this.shopIdTextbox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(904, 544);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mã shop";
            // 
            // empPhoneTextbox
            // 
            this.empPhoneTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empPhoneTextbox.Location = new System.Drawing.Point(1042, 312);
            this.empPhoneTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.empPhoneTextbox.Name = "empPhoneTextbox";
            this.empPhoneTextbox.Size = new System.Drawing.Size(285, 31);
            this.empPhoneTextbox.TabIndex = 12;
            // 
            // empNameTextbox
            // 
            this.empNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empNameTextbox.Location = new System.Drawing.Point(1042, 242);
            this.empNameTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.empNameTextbox.Name = "empNameTextbox";
            this.empNameTextbox.Size = new System.Drawing.Size(285, 31);
            this.empNameTextbox.TabIndex = 11;
            // 
            // beginDatepicker
            // 
            this.beginDatepicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginDatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.beginDatepicker.Location = new System.Drawing.Point(1042, 464);
            this.beginDatepicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.beginDatepicker.Name = "beginDatepicker";
            this.beginDatepicker.Size = new System.Drawing.Size(285, 31);
            this.beginDatepicker.TabIndex = 10;
            // 
            // empIdTextbox
            // 
            this.empIdTextbox.Enabled = false;
            this.empIdTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empIdTextbox.Location = new System.Drawing.Point(1042, 168);
            this.empIdTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.empIdTextbox.Name = "empIdTextbox";
            this.empIdTextbox.Size = new System.Drawing.Size(285, 31);
            this.empIdTextbox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(904, 462);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày bắt đầu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(904, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vị trí";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(907, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "SĐT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(907, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(907, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã nhân viên";
            // 
            // QLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 754);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "QLNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLNV";
            this.Load += new System.EventHandler(this.QLNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhanVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgNhanVien;
        private System.Windows.Forms.Button themBtn;
        private System.Windows.Forms.Button suaBtn;
        private System.Windows.Forms.Button xoaBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox empNameTextbox;
        private System.Windows.Forms.DateTimePicker beginDatepicker;
        private System.Windows.Forms.TextBox empIdTextbox;
        private System.Windows.Forms.TextBox shopIdTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox empPhoneTextbox;
        private System.Windows.Forms.ComboBox empRoleCbbox;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn empId;
        private System.Windows.Forms.DataGridViewTextBoxColumn empName;
        private System.Windows.Forms.DataGridViewTextBoxColumn empPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn empRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn beginDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn shopId;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.Button homepageBtn;
    }
}