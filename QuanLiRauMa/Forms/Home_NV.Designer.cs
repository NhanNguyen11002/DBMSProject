
namespace QLRauMaVer1
{
    partial class NhanVienHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVienHome));
            this.xemThongTinBtn = new System.Windows.Forms.PictureBox();
            this.doiMatKhauBtn = new System.Windows.Forms.PictureBox();
            this.labelXinchao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.xemThongTinBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doiMatKhauBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // xemThongTinBtn
            // 
            this.xemThongTinBtn.Image = ((System.Drawing.Image)(resources.GetObject("xemThongTinBtn.Image")));
            this.xemThongTinBtn.Location = new System.Drawing.Point(224, 164);
            this.xemThongTinBtn.Name = "xemThongTinBtn";
            this.xemThongTinBtn.Size = new System.Drawing.Size(100, 104);
            this.xemThongTinBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.xemThongTinBtn.TabIndex = 1;
            this.xemThongTinBtn.TabStop = false;
            this.xemThongTinBtn.Click += new System.EventHandler(this.xemThongTinBtn_Click);
            // 
            // doiMatKhauBtn
            // 
            this.doiMatKhauBtn.Image = ((System.Drawing.Image)(resources.GetObject("doiMatKhauBtn.Image")));
            this.doiMatKhauBtn.Location = new System.Drawing.Point(447, 164);
            this.doiMatKhauBtn.Name = "doiMatKhauBtn";
            this.doiMatKhauBtn.Size = new System.Drawing.Size(100, 104);
            this.doiMatKhauBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.doiMatKhauBtn.TabIndex = 3;
            this.doiMatKhauBtn.TabStop = false;
            this.doiMatKhauBtn.Click += new System.EventHandler(this.doiMatKhauBtn_Click);
            // 
            // labelXinchao
            // 
            this.labelXinchao.AutoSize = true;
            this.labelXinchao.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXinchao.Location = new System.Drawing.Point(47, 41);
            this.labelXinchao.Name = "labelXinchao";
            this.labelXinchao.Size = new System.Drawing.Size(91, 28);
            this.labelXinchao.TabIndex = 4;
            this.labelXinchao.Text = "Xin chào";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("VNF-Comic Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Xem thông tin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("VNF-Comic Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(443, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Đổi mật khẩu";
            // 
            // logoutBtn
            // 
            this.logoutBtn.Font = new System.Drawing.Font("VNF-Comic Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Location = new System.Drawing.Point(595, 47);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(120, 31);
            this.logoutBtn.TabIndex = 8;
            this.logoutBtn.Text = "Đăng xuất";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // NhanVienHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelXinchao);
            this.Controls.Add(this.doiMatKhauBtn);
            this.Controls.Add(this.xemThongTinBtn);
            this.MaximizeBox = false;
            this.Name = "NhanVienHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NhanVien Home";
            this.Load += new System.EventHandler(this.NhanVienHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xemThongTinBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doiMatKhauBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox xemThongTinBtn;
        private System.Windows.Forms.PictureBox doiMatKhauBtn;
        private System.Windows.Forms.Label labelXinchao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button logoutBtn;
    }
}

