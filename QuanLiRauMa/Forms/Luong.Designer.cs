
namespace QLRauMaVer1.Forms
{
    partial class Luong
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
            this.clearBtn = new System.Windows.Forms.Button();
            this.salaryshiftTextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.salaryidTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.suaBtn = new System.Windows.Forms.Button();
            this.xoaBtn = new System.Windows.Forms.Button();
            this.themBtn = new System.Windows.Forms.Button();
            this.homepageBtn = new System.Windows.Forms.Button();
            this.empnameTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.emproleTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.shiftTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.monthTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.salaryTextbox = new System.Windows.Forms.TextBox();
            this.dtgLuong = new System.Windows.Forms.DataGridView();
            this.salaryid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary_empid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary_empname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary_emprole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary_emproleid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empshift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryshift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empidTextbox = new System.Windows.Forms.TextBox();
            this.dtgNhanVien = new System.Windows.Forms.DataGridView();
            this.empid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emproldid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emprole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_salaryshift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(901, 648);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(133, 45);
            this.clearBtn.TabIndex = 47;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click_1);
            // 
            // salaryshiftTextbox
            // 
            this.salaryshiftTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryshiftTextbox.Location = new System.Drawing.Point(1078, 509);
            this.salaryshiftTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.salaryshiftTextbox.Name = "salaryshiftTextbox";
            this.salaryshiftTextbox.ReadOnly = true;
            this.salaryshiftTextbox.Size = new System.Drawing.Size(238, 31);
            this.salaryshiftTextbox.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(910, 519);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(149, 25);
            this.label8.TabIndex = 45;
            this.label8.Text = "Lương theo ca";
            // 
            // calculateBtn
            // 
            this.calculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateBtn.Location = new System.Drawing.Point(708, 648);
            this.calculateBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(136, 39);
            this.calculateBtn.TabIndex = 44;
            this.calculateBtn.Text = "Tính lương";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click_1);
            // 
            // salaryidTextbox
            // 
            this.salaryidTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryidTextbox.Location = new System.Drawing.Point(1117, 64);
            this.salaryidTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.salaryidTextbox.Name = "salaryidTextbox";
            this.salaryidTextbox.ReadOnly = true;
            this.salaryidTextbox.Size = new System.Drawing.Size(199, 31);
            this.salaryidTextbox.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(953, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 25);
            this.label7.TabIndex = 42;
            this.label7.Text = "Mã phiếu lương";
            // 
            // suaBtn
            // 
            this.suaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suaBtn.Location = new System.Drawing.Point(1089, 721);
            this.suaBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.suaBtn.Name = "suaBtn";
            this.suaBtn.Size = new System.Drawing.Size(136, 45);
            this.suaBtn.TabIndex = 41;
            this.suaBtn.Text = "Sửa";
            this.suaBtn.UseVisualStyleBackColor = true;
            this.suaBtn.Click += new System.EventHandler(this.suaBtn_Click_1);
            // 
            // xoaBtn
            // 
            this.xoaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoaBtn.Location = new System.Drawing.Point(898, 721);
            this.xoaBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xoaBtn.Name = "xoaBtn";
            this.xoaBtn.Size = new System.Drawing.Size(136, 45);
            this.xoaBtn.TabIndex = 40;
            this.xoaBtn.Text = "Xóa";
            this.xoaBtn.UseVisualStyleBackColor = true;
            this.xoaBtn.Click += new System.EventHandler(this.xoaBtn_Click_1);
            // 
            // themBtn
            // 
            this.themBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themBtn.Location = new System.Drawing.Point(708, 721);
            this.themBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.themBtn.Name = "themBtn";
            this.themBtn.Size = new System.Drawing.Size(136, 45);
            this.themBtn.TabIndex = 39;
            this.themBtn.Text = "Thêm";
            this.themBtn.UseVisualStyleBackColor = true;
            this.themBtn.Click += new System.EventHandler(this.themBtn_Click);
            // 
            // homepageBtn
            // 
            this.homepageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homepageBtn.Location = new System.Drawing.Point(14, 26);
            this.homepageBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.homepageBtn.Name = "homepageBtn";
            this.homepageBtn.Size = new System.Drawing.Size(136, 38);
            this.homepageBtn.TabIndex = 38;
            this.homepageBtn.Text = "Trang chủ";
            this.homepageBtn.UseVisualStyleBackColor = true;
            this.homepageBtn.Click += new System.EventHandler(this.homepageBtn_Click);
            // 
            // empnameTextbox
            // 
            this.empnameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empnameTextbox.Location = new System.Drawing.Point(1078, 214);
            this.empnameTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.empnameTextbox.Name = "empnameTextbox";
            this.empnameTextbox.ReadOnly = true;
            this.empnameTextbox.Size = new System.Drawing.Size(238, 31);
            this.empnameTextbox.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(946, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 36;
            this.label6.Text = "Tên NV";
            // 
            // emproleTextbox
            // 
            this.emproleTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emproleTextbox.Location = new System.Drawing.Point(1078, 289);
            this.emproleTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emproleTextbox.Name = "emproleTextbox";
            this.emproleTextbox.ReadOnly = true;
            this.emproleTextbox.Size = new System.Drawing.Size(238, 31);
            this.emproleTextbox.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(953, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.TabIndex = 34;
            this.label5.Text = "Vị trí";
            // 
            // shiftTextbox
            // 
            this.shiftTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shiftTextbox.Location = new System.Drawing.Point(1078, 432);
            this.shiftTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.shiftTextbox.Name = "shiftTextbox";
            this.shiftTextbox.Size = new System.Drawing.Size(238, 31);
            this.shiftTextbox.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(953, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Số ca ";
            // 
            // monthTextbox
            // 
            this.monthTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthTextbox.Location = new System.Drawing.Point(1078, 361);
            this.monthTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.monthTextbox.Name = "monthTextbox";
            this.monthTextbox.Size = new System.Drawing.Size(238, 31);
            this.monthTextbox.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(953, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "Tháng";
            // 
            // salaryTextbox
            // 
            this.salaryTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryTextbox.Location = new System.Drawing.Point(1078, 578);
            this.salaryTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.salaryTextbox.Name = "salaryTextbox";
            this.salaryTextbox.ReadOnly = true;
            this.salaryTextbox.Size = new System.Drawing.Size(238, 31);
            this.salaryTextbox.TabIndex = 29;
            // 
            // dtgLuong
            // 
            this.dtgLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salaryid,
            this.salary_empid,
            this.salary_empname,
            this.salary_emprole,
            this.salary_emproleid,
            this.month,
            this.empshift,
            this.salaryshift,
            this.salaryamount});
            this.dtgLuong.Location = new System.Drawing.Point(14, 71);
            this.dtgLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgLuong.Name = "dtgLuong";
            this.dtgLuong.RowHeadersWidth = 51;
            this.dtgLuong.RowTemplate.Height = 24;
            this.dtgLuong.Size = new System.Drawing.Size(868, 446);
            this.dtgLuong.TabIndex = 24;
            this.dtgLuong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgLuong_CellContentClick_1);
            // 
            // salaryid
            // 
            this.salaryid.DataPropertyName = "salary_id";
            this.salaryid.HeaderText = "Mã phiếu lương";
            this.salaryid.MinimumWidth = 6;
            this.salaryid.Name = "salaryid";
            this.salaryid.ReadOnly = true;
            this.salaryid.Width = 125;
            // 
            // salary_empid
            // 
            this.salary_empid.DataPropertyName = "emp_id";
            this.salary_empid.HeaderText = "Mã nhân viên";
            this.salary_empid.MinimumWidth = 6;
            this.salary_empid.Name = "salary_empid";
            this.salary_empid.ReadOnly = true;
            this.salary_empid.Visible = false;
            this.salary_empid.Width = 125;
            // 
            // salary_empname
            // 
            this.salary_empname.DataPropertyName = "emp_name";
            this.salary_empname.HeaderText = "Tên nhân viên";
            this.salary_empname.MinimumWidth = 6;
            this.salary_empname.Name = "salary_empname";
            this.salary_empname.ReadOnly = true;
            this.salary_empname.Width = 125;
            // 
            // salary_emprole
            // 
            this.salary_emprole.DataPropertyName = "emp_role_name";
            this.salary_emprole.HeaderText = "Vị trí";
            this.salary_emprole.MinimumWidth = 6;
            this.salary_emprole.Name = "salary_emprole";
            this.salary_emprole.ReadOnly = true;
            this.salary_emprole.Width = 125;
            // 
            // salary_emproleid
            // 
            this.salary_emproleid.DataPropertyName = "emp_role";
            this.salary_emproleid.HeaderText = "Mã vị trí";
            this.salary_emproleid.MinimumWidth = 6;
            this.salary_emproleid.Name = "salary_emproleid";
            this.salary_emproleid.ReadOnly = true;
            this.salary_emproleid.Visible = false;
            this.salary_emproleid.Width = 125;
            // 
            // month
            // 
            this.month.DataPropertyName = "salary_month";
            this.month.HeaderText = "Tháng";
            this.month.MinimumWidth = 6;
            this.month.Name = "month";
            this.month.ReadOnly = true;
            this.month.Width = 125;
            // 
            // empshift
            // 
            this.empshift.DataPropertyName = "shift_count";
            this.empshift.HeaderText = "Số ca";
            this.empshift.MinimumWidth = 6;
            this.empshift.Name = "empshift";
            this.empshift.ReadOnly = true;
            this.empshift.Width = 125;
            // 
            // salaryshift
            // 
            this.salaryshift.DataPropertyName = "salary_shift";
            this.salaryshift.HeaderText = "Lương theo ca";
            this.salaryshift.MinimumWidth = 6;
            this.salaryshift.Name = "salaryshift";
            this.salaryshift.ReadOnly = true;
            this.salaryshift.Width = 125;
            // 
            // salaryamount
            // 
            this.salaryamount.DataPropertyName = "salary_amount";
            this.salaryamount.HeaderText = "Tổng lương";
            this.salaryamount.MinimumWidth = 6;
            this.salaryamount.Name = "salaryamount";
            this.salaryamount.ReadOnly = true;
            this.salaryamount.Width = 125;
            // 
            // empidTextbox
            // 
            this.empidTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empidTextbox.Location = new System.Drawing.Point(1078, 140);
            this.empidTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.empidTextbox.Name = "empidTextbox";
            this.empidTextbox.ReadOnly = true;
            this.empidTextbox.Size = new System.Drawing.Size(238, 31);
            this.empidTextbox.TabIndex = 27;
            // 
            // dtgNhanVien
            // 
            this.dtgNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empid,
            this.empname,
            this.emproldid,
            this.emprole,
            this.emp_salaryshift});
            this.dtgNhanVien.Location = new System.Drawing.Point(14, 525);
            this.dtgNhanVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgNhanVien.Name = "dtgNhanVien";
            this.dtgNhanVien.RowHeadersWidth = 51;
            this.dtgNhanVien.RowTemplate.Height = 24;
            this.dtgNhanVien.Size = new System.Drawing.Size(621, 264);
            this.dtgNhanVien.TabIndex = 25;
            this.dtgNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgNhanVien_CellContentClick_1);
            // 
            // empid
            // 
            this.empid.DataPropertyName = "emp_id";
            this.empid.HeaderText = "Mã nhân viên";
            this.empid.MinimumWidth = 6;
            this.empid.Name = "empid";
            this.empid.ReadOnly = true;
            this.empid.Width = 125;
            // 
            // empname
            // 
            this.empname.DataPropertyName = "emp_name";
            this.empname.HeaderText = "Tên nhân viên";
            this.empname.MinimumWidth = 6;
            this.empname.Name = "empname";
            this.empname.ReadOnly = true;
            this.empname.Width = 125;
            // 
            // emproldid
            // 
            this.emproldid.DataPropertyName = "emp_role";
            this.emproldid.HeaderText = "Mã vị trí";
            this.emproldid.MinimumWidth = 6;
            this.emproldid.Name = "emproldid";
            this.emproldid.ReadOnly = true;
            this.emproldid.Visible = false;
            this.emproldid.Width = 125;
            // 
            // emprole
            // 
            this.emprole.DataPropertyName = "emp_role_name";
            this.emprole.HeaderText = "Vị trí";
            this.emprole.MinimumWidth = 6;
            this.emprole.Name = "emprole";
            this.emprole.ReadOnly = true;
            this.emprole.Width = 125;
            // 
            // emp_salaryshift
            // 
            this.emp_salaryshift.DataPropertyName = "salary_shift";
            this.emp_salaryshift.HeaderText = "Lương theo ca";
            this.emp_salaryshift.MinimumWidth = 6;
            this.emp_salaryshift.Name = "emp_salaryshift";
            this.emp_salaryshift.ReadOnly = true;
            this.emp_salaryshift.Visible = false;
            this.emp_salaryshift.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(953, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã NV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(910, 588);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tổng tiền lương";
            // 
            // Luong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1330, 816);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.salaryshiftTextbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.salaryidTextbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.suaBtn);
            this.Controls.Add(this.xoaBtn);
            this.Controls.Add(this.themBtn);
            this.Controls.Add(this.homepageBtn);
            this.Controls.Add(this.empnameTextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.emproleTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.shiftTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.monthTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.salaryTextbox);
            this.Controls.Add(this.dtgLuong);
            this.Controls.Add(this.empidTextbox);
            this.Controls.Add(this.dtgNhanVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Luong";
            this.Text = "Luong";
            this.Load += new System.EventHandler(this.Luong_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.TextBox salaryshiftTextbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.TextBox salaryidTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button suaBtn;
        private System.Windows.Forms.Button xoaBtn;
        private System.Windows.Forms.Button themBtn;
        private System.Windows.Forms.Button homepageBtn;
        private System.Windows.Forms.TextBox empnameTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emproleTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox shiftTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox monthTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox salaryTextbox;
        private System.Windows.Forms.DataGridView dtgLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryid;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary_empid;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary_empname;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary_emprole;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary_emproleid;
        private System.Windows.Forms.DataGridViewTextBoxColumn month;
        private System.Windows.Forms.DataGridViewTextBoxColumn empshift;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryshift;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryamount;
        private System.Windows.Forms.TextBox empidTextbox;
        private System.Windows.Forms.DataGridView dtgNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn empid;
        private System.Windows.Forms.DataGridViewTextBoxColumn empname;
        private System.Windows.Forms.DataGridViewTextBoxColumn emproldid;
        private System.Windows.Forms.DataGridViewTextBoxColumn emprole;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_salaryshift;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}