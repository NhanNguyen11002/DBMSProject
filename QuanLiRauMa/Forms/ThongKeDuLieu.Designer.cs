
namespace QLRauMaVer1.Forms
{
    partial class ThongKeDuLieu
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_func = new System.Windows.Forms.ComboBox();
            this.btn_Xem = new System.Windows.Forms.Button();
            this.pn_result = new System.Windows.Forms.Panel();
            this.dgv_result = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_shop = new System.Windows.Forms.ComboBox();
            this.homepageBtn = new System.Windows.Forms.Button();
            this.pn_result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(332, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(391, 54);
            this.label3.TabIndex = 6;
            this.label3.Text = "THỐNG KÊ DỮ LIỆU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(182, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Chức Năng ";
            // 
            // cbx_func
            // 
            this.cbx_func.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_func.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_func.FormattingEnabled = true;
            this.cbx_func.Items.AddRange(new object[] {
            "Danh sách đơn hàng chưa thanh toán",
            "Voucher có thể sử dụng trong ngày",
            "Xem chi phí điện, nước, mặt bằng của shop",
            "Lương mỗi tháng shop trả cho nhân viên",
            "Doanh thu của shop theo tháng",
            "Lợi nhuận của shop theo tháng",
            "NV có kinh nghiệm làm việc( từ 2 tháng đến 3 tháng)",
            "Tổng chi phí 3 tháng gần nhất",
            "Những chuỗi chi nhánh ở TP.HCM",
            "5 sản phẩm bán chạy nhất",
            "Sản phẩm đã bán trong ngày"});
            this.cbx_func.Location = new System.Drawing.Point(341, 128);
            this.cbx_func.Name = "cbx_func";
            this.cbx_func.Size = new System.Drawing.Size(505, 36);
            this.cbx_func.TabIndex = 8;
            // 
            // btn_Xem
            // 
            this.btn_Xem.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Xem.FlatAppearance.BorderSize = 0;
            this.btn_Xem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xem.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xem.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Xem.Location = new System.Drawing.Point(341, 180);
            this.btn_Xem.Name = "btn_Xem";
            this.btn_Xem.Size = new System.Drawing.Size(134, 39);
            this.btn_Xem.TabIndex = 9;
            this.btn_Xem.Text = "XEM";
            this.btn_Xem.UseVisualStyleBackColor = false;
            this.btn_Xem.Click += new System.EventHandler(this.btn_Xem_Click);
            // 
            // pn_result
            // 
            this.pn_result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_result.Controls.Add(this.dgv_result);
            this.pn_result.Location = new System.Drawing.Point(124, 240);
            this.pn_result.Name = "pn_result";
            this.pn_result.Size = new System.Drawing.Size(789, 437);
            this.pn_result.TabIndex = 10;
            // 
            // dgv_result
            // 
            this.dgv_result.AllowUserToAddRows = false;
            this.dgv_result.AllowUserToDeleteRows = false;
            this.dgv_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_result.Location = new System.Drawing.Point(25, 29);
            this.dgv_result.Name = "dgv_result";
            this.dgv_result.ReadOnly = true;
            this.dgv_result.RowHeadersWidth = 51;
            this.dgv_result.Size = new System.Drawing.Size(733, 379);
            this.dgv_result.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(178, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "KẾT QUẢ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(182, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Chọn Shop";
            // 
            // cb_shop
            // 
            this.cb_shop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_shop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_shop.FormattingEnabled = true;
            this.cb_shop.Location = new System.Drawing.Point(341, 78);
            this.cb_shop.Name = "cb_shop";
            this.cb_shop.Size = new System.Drawing.Size(505, 36);
            this.cb_shop.TabIndex = 12;
            // 
            // homepageBtn
            // 
            this.homepageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homepageBtn.Location = new System.Drawing.Point(23, 12);
            this.homepageBtn.Name = "homepageBtn";
            this.homepageBtn.Size = new System.Drawing.Size(102, 31);
            this.homepageBtn.TabIndex = 18;
            this.homepageBtn.Text = "Trang chủ";
            this.homepageBtn.UseVisualStyleBackColor = true;
            this.homepageBtn.Click += new System.EventHandler(this.homepageBtn_Click);
            // 
            // ThongKeDuLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1032, 703);
            this.Controls.Add(this.homepageBtn);
            this.Controls.Add(this.cb_shop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pn_result);
            this.Controls.Add(this.btn_Xem);
            this.Controls.Add(this.cbx_func);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "ThongKeDuLieu";
            this.Text = "ThongKeDuLieu";
            this.Load += new System.EventHandler(this.ThongKeDuLieu_Load);
            this.pn_result.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_func;
        private System.Windows.Forms.Button btn_Xem;
        private System.Windows.Forms.Panel pn_result;
        private System.Windows.Forms.DataGridView dgv_result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_shop;
        private System.Windows.Forms.Button homepageBtn;
    }
}