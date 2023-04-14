
namespace QLRauMaVer1.Forms
{
    partial class DonHang_SuperAdmin
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
            this.payment_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgOrderproduct = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentmethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voucher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.orderidTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.homepageBtn = new System.Windows.Forms.Button();
            this.paymentGrbox = new System.Windows.Forms.GroupBox();
            this.payMethodCbbox = new System.Windows.Forms.ComboBox();
            this.voucherCbbox = new System.Windows.Forms.ComboBox();
            this.payBtn = new System.Windows.Forms.Button();
            this.totalpriceTextbox = new System.Windows.Forms.TextBox();
            this.productGrbox = new System.Windows.Forms.GroupBox();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.productAmountTextbox = new System.Windows.Forms.TextBox();
            this.dtgMenu = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addOrderBtn = new System.Windows.Forms.Button();
            this.shopCbbox = new System.Windows.Forms.ComboBox();
            this.createdayDatepicker = new System.Windows.Forms.DateTimePicker();
            this.phoneTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgQLDH = new System.Windows.Forms.DataGridView();
            this.xoaBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrderproduct)).BeginInit();
            this.panel1.SuspendLayout();
            this.paymentGrbox.SuspendLayout();
            this.productGrbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMenu)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgQLDH)).BeginInit();
            this.SuspendLayout();
            // 
            // payment_status
            // 
            this.payment_status.DataPropertyName = "payment_status";
            this.payment_status.HeaderText = "Trạng thái TT";
            this.payment_status.MinimumWidth = 6;
            this.payment_status.Name = "payment_status";
            this.payment_status.ReadOnly = true;
            this.payment_status.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Shop";
            // 
            // dtgOrderproduct
            // 
            this.dtgOrderproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOrderproduct.Location = new System.Drawing.Point(531, 45);
            this.dtgOrderproduct.Name = "dtgOrderproduct";
            this.dtgOrderproduct.RowHeadersWidth = 51;
            this.dtgOrderproduct.Size = new System.Drawing.Size(414, 207);
            this.dtgOrderproduct.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 22);
            this.label7.TabIndex = 9;
            this.label7.Text = "VND";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Thành tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Voucher";
            // 
            // id
            // 
            this.id.DataPropertyName = "product_id";
            this.id.HeaderText = "Mã";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // name_product
            // 
            this.name_product.DataPropertyName = "name_product";
            this.name_product.HeaderText = "Tên món";
            this.name_product.MinimumWidth = 6;
            this.name_product.Name = "name_product";
            this.name_product.ReadOnly = true;
            this.name_product.Width = 125;
            // 
            // cost
            // 
            this.cost.DataPropertyName = "cost";
            this.cost.HeaderText = "Giá tiền";
            this.cost.MinimumWidth = 6;
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            this.cost.Width = 125;
            // 
            // order_id
            // 
            this.order_id.DataPropertyName = "order_id";
            this.order_id.HeaderText = "OrderID";
            this.order_id.MinimumWidth = 6;
            this.order_id.Name = "order_id";
            this.order_id.ReadOnly = true;
            this.order_id.Width = 125;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "c_phone_number";
            this.phone.HeaderText = "SĐT";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Width = 125;
            // 
            // date
            // 
            this.date.DataPropertyName = "create_day";
            this.date.HeaderText = "Ngày tạo";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 125;
            // 
            // shopid
            // 
            this.shopid.DataPropertyName = "shop_id";
            this.shopid.HeaderText = "Shop";
            this.shopid.MinimumWidth = 6;
            this.shopid.Name = "shopid";
            this.shopid.ReadOnly = true;
            this.shopid.Width = 125;
            // 
            // paymentmethod
            // 
            this.paymentmethod.DataPropertyName = "payment_method";
            this.paymentmethod.HeaderText = "Phương thức TT";
            this.paymentmethod.MinimumWidth = 6;
            this.paymentmethod.Name = "paymentmethod";
            this.paymentmethod.ReadOnly = true;
            this.paymentmethod.Width = 125;
            // 
            // voucher
            // 
            this.voucher.DataPropertyName = "voucher_id";
            this.voucher.HeaderText = "Voucher";
            this.voucher.MinimumWidth = 6;
            this.voucher.Name = "voucher";
            this.voucher.ReadOnly = true;
            this.voucher.Width = 125;
            // 
            // finalprice
            // 
            this.finalprice.DataPropertyName = "payment_amount";
            this.finalprice.HeaderText = "Thành tiền";
            this.finalprice.MinimumWidth = 6;
            this.finalprice.Name = "finalprice";
            this.finalprice.ReadOnly = true;
            this.finalprice.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date";
            // 
            // orderidTextbox
            // 
            this.orderidTextbox.Font = new System.Drawing.Font("VNF-Comic Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderidTextbox.Location = new System.Drawing.Point(156, 598);
            this.orderidTextbox.Name = "orderidTextbox";
            this.orderidTextbox.Size = new System.Drawing.Size(83, 33);
            this.orderidTextbox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Phương thức TT";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel1.Controls.Add(this.homepageBtn);
            this.panel1.Controls.Add(this.orderidTextbox);
            this.panel1.Controls.Add(this.paymentGrbox);
            this.panel1.Controls.Add(this.productGrbox);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dtgQLDH);
            this.panel1.Controls.Add(this.xoaBtn);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1582, 653);
            this.panel1.TabIndex = 1;
            // 
            // homepageBtn
            // 
            this.homepageBtn.Font = new System.Drawing.Font("VNF-Comic Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homepageBtn.Location = new System.Drawing.Point(24, 3);
            this.homepageBtn.Name = "homepageBtn";
            this.homepageBtn.Size = new System.Drawing.Size(104, 27);
            this.homepageBtn.TabIndex = 8;
            this.homepageBtn.Text = "Trang chủ";
            this.homepageBtn.UseVisualStyleBackColor = true;
            this.homepageBtn.Click += new System.EventHandler(this.homepageBtn_Click);
            // 
            // paymentGrbox
            // 
            this.paymentGrbox.BackColor = System.Drawing.Color.PaleGreen;
            this.paymentGrbox.Controls.Add(this.label7);
            this.paymentGrbox.Controls.Add(this.label6);
            this.paymentGrbox.Controls.Add(this.label5);
            this.paymentGrbox.Controls.Add(this.label2);
            this.paymentGrbox.Controls.Add(this.payMethodCbbox);
            this.paymentGrbox.Controls.Add(this.voucherCbbox);
            this.paymentGrbox.Controls.Add(this.payBtn);
            this.paymentGrbox.Controls.Add(this.totalpriceTextbox);
            this.paymentGrbox.Font = new System.Drawing.Font("VNF-Comic Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentGrbox.Location = new System.Drawing.Point(1098, 36);
            this.paymentGrbox.Name = "paymentGrbox";
            this.paymentGrbox.Size = new System.Drawing.Size(435, 287);
            this.paymentGrbox.TabIndex = 6;
            this.paymentGrbox.TabStop = false;
            this.paymentGrbox.Text = "Thanh toán";
            // 
            // payMethodCbbox
            // 
            this.payMethodCbbox.FormattingEnabled = true;
            this.payMethodCbbox.Items.AddRange(new object[] {
            "Trực tiếp",
            "Momo",
            "Giao hàng"});
            this.payMethodCbbox.Location = new System.Drawing.Point(165, 46);
            this.payMethodCbbox.Name = "payMethodCbbox";
            this.payMethodCbbox.Size = new System.Drawing.Size(198, 30);
            this.payMethodCbbox.TabIndex = 5;
            // 
            // voucherCbbox
            // 
            this.voucherCbbox.FormattingEnabled = true;
            this.voucherCbbox.Location = new System.Drawing.Point(127, 89);
            this.voucherCbbox.Name = "voucherCbbox";
            this.voucherCbbox.Size = new System.Drawing.Size(236, 30);
            this.voucherCbbox.TabIndex = 4;
            // 
            // payBtn
            // 
            this.payBtn.Location = new System.Drawing.Point(136, 188);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(107, 46);
            this.payBtn.TabIndex = 2;
            this.payBtn.Text = "Thanh toán";
            this.payBtn.UseVisualStyleBackColor = true;
            // 
            // totalpriceTextbox
            // 
            this.totalpriceTextbox.Location = new System.Drawing.Point(127, 134);
            this.totalpriceTextbox.Name = "totalpriceTextbox";
            this.totalpriceTextbox.ReadOnly = true;
            this.totalpriceTextbox.Size = new System.Drawing.Size(152, 29);
            this.totalpriceTextbox.TabIndex = 1;
            // 
            // productGrbox
            // 
            this.productGrbox.BackColor = System.Drawing.Color.PaleGreen;
            this.productGrbox.Controls.Add(this.dtgOrderproduct);
            this.productGrbox.Controls.Add(this.addProductBtn);
            this.productGrbox.Controls.Add(this.productAmountTextbox);
            this.productGrbox.Controls.Add(this.dtgMenu);
            this.productGrbox.Font = new System.Drawing.Font("VNF-Comic Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productGrbox.Location = new System.Drawing.Point(509, 341);
            this.productGrbox.Name = "productGrbox";
            this.productGrbox.Size = new System.Drawing.Size(986, 303);
            this.productGrbox.TabIndex = 5;
            this.productGrbox.TabStop = false;
            this.productGrbox.Text = "Danh sách món";
            // 
            // addProductBtn
            // 
            this.addProductBtn.Location = new System.Drawing.Point(263, 260);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(119, 37);
            this.addProductBtn.TabIndex = 2;
            this.addProductBtn.Text = "Thêm món";
            this.addProductBtn.UseVisualStyleBackColor = true;
            // 
            // productAmountTextbox
            // 
            this.productAmountTextbox.Location = new System.Drawing.Point(143, 264);
            this.productAmountTextbox.Name = "productAmountTextbox";
            this.productAmountTextbox.Size = new System.Drawing.Size(100, 29);
            this.productAmountTextbox.TabIndex = 1;
            // 
            // dtgMenu
            // 
            this.dtgMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name_product,
            this.cost});
            this.dtgMenu.Location = new System.Drawing.Point(44, 45);
            this.dtgMenu.Name = "dtgMenu";
            this.dtgMenu.RowHeadersWidth = 51;
            this.dtgMenu.RowTemplate.Height = 24;
            this.dtgMenu.Size = new System.Drawing.Size(468, 207);
            this.dtgMenu.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleGreen;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.addOrderBtn);
            this.groupBox1.Controls.Add(this.shopCbbox);
            this.groupBox1.Controls.Add(this.createdayDatepicker);
            this.groupBox1.Controls.Add(this.phoneTextbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("VNF-Comic Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(105, 341);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 239);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tạo đơn hàng";
            // 
            // addOrderBtn
            // 
            this.addOrderBtn.Location = new System.Drawing.Point(119, 150);
            this.addOrderBtn.Name = "addOrderBtn";
            this.addOrderBtn.Size = new System.Drawing.Size(81, 37);
            this.addOrderBtn.TabIndex = 4;
            this.addOrderBtn.Text = "Tạo đơn";
            this.addOrderBtn.UseVisualStyleBackColor = true;
            this.addOrderBtn.Click += new System.EventHandler(this.addOrderBtn_Click_1);
            // 
            // shopCbbox
            // 
            this.shopCbbox.FormattingEnabled = true;
            this.shopCbbox.Location = new System.Drawing.Point(92, 114);
            this.shopCbbox.Name = "shopCbbox";
            this.shopCbbox.Size = new System.Drawing.Size(202, 30);
            this.shopCbbox.TabIndex = 3;
            // 
            // createdayDatepicker
            // 
            this.createdayDatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.createdayDatepicker.Location = new System.Drawing.Point(92, 68);
            this.createdayDatepicker.Name = "createdayDatepicker";
            this.createdayDatepicker.Size = new System.Drawing.Size(202, 29);
            this.createdayDatepicker.TabIndex = 2;
            // 
            // phoneTextbox
            // 
            this.phoneTextbox.Location = new System.Drawing.Point(92, 28);
            this.phoneTextbox.Name = "phoneTextbox";
            this.phoneTextbox.Size = new System.Drawing.Size(202, 29);
            this.phoneTextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "SĐT";
            // 
            // dtgQLDH
            // 
            this.dtgQLDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgQLDH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order_id,
            this.phone,
            this.date,
            this.shopid,
            this.paymentmethod,
            this.voucher,
            this.finalprice,
            this.payment_status});
            this.dtgQLDH.Location = new System.Drawing.Point(24, 36);
            this.dtgQLDH.Name = "dtgQLDH";
            this.dtgQLDH.RowHeadersWidth = 51;
            this.dtgQLDH.RowTemplate.Height = 24;
            this.dtgQLDH.Size = new System.Drawing.Size(1060, 287);
            this.dtgQLDH.TabIndex = 3;
            // 
            // xoaBtn
            // 
            this.xoaBtn.Font = new System.Drawing.Font("VNF-Comic Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoaBtn.Location = new System.Drawing.Point(266, 590);
            this.xoaBtn.Name = "xoaBtn";
            this.xoaBtn.Size = new System.Drawing.Size(114, 48);
            this.xoaBtn.TabIndex = 0;
            this.xoaBtn.Text = "Xóa";
            this.xoaBtn.UseVisualStyleBackColor = true;
            // 
            // DonHang_SuperAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 653);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "DonHang_SuperAdmin";
            this.Text = "DonHang_SuperAdmin";
            this.Load += new System.EventHandler(this.DonHang_SuperAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrderproduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.paymentGrbox.ResumeLayout(false);
            this.paymentGrbox.PerformLayout();
            this.productGrbox.ResumeLayout(false);
            this.productGrbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMenu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgQLDH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn payment_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgOrderproduct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn shopid;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentmethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucher;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalprice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox orderidTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox paymentGrbox;
        private System.Windows.Forms.ComboBox payMethodCbbox;
        private System.Windows.Forms.ComboBox voucherCbbox;
        private System.Windows.Forms.Button payBtn;
        private System.Windows.Forms.TextBox totalpriceTextbox;
        private System.Windows.Forms.GroupBox productGrbox;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.TextBox productAmountTextbox;
        private System.Windows.Forms.DataGridView dtgMenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addOrderBtn;
        private System.Windows.Forms.ComboBox shopCbbox;
        private System.Windows.Forms.DateTimePicker createdayDatepicker;
        private System.Windows.Forms.TextBox phoneTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgQLDH;
        private System.Windows.Forms.Button xoaBtn;
        private System.Windows.Forms.Button homepageBtn;
    }
}