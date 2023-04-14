
namespace QLRauMaVer1.Forms
{
    partial class ConnectDB
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
            this.btn_connect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkbox_default = new System.Windows.Forms.CheckBox();
            this.txt_cnt = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(209, 291);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(136, 34);
            this.btn_connect.TabIndex = 18;
            this.btn_connect.Text = "CONNECT";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(351, 41);
            this.label4.TabIndex = 17;
            this.label4.Text = "ĐĂNG NHẬP VÀO CSDL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(22, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Server Name";
            // 
            // chkbox_default
            // 
            this.chkbox_default.AutoSize = true;
            this.chkbox_default.Checked = true;
            this.chkbox_default.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbox_default.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkbox_default.Location = new System.Drawing.Point(209, 252);
            this.chkbox_default.Name = "chkbox_default";
            this.chkbox_default.Size = new System.Drawing.Size(258, 33);
            this.chkbox_default.TabIndex = 15;
            this.chkbox_default.Text = "Default Server Name";
            this.chkbox_default.UseVisualStyleBackColor = true;
            this.chkbox_default.CheckedChanged += new System.EventHandler(this.chkbox_default_CheckedChanged);
            // 
            // txt_cnt
            // 
            this.txt_cnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_cnt.Location = new System.Drawing.Point(209, 206);
            this.txt_cnt.Name = "txt_cnt";
            this.txt_cnt.ReadOnly = true;
            this.txt_cnt.Size = new System.Drawing.Size(267, 34);
            this.txt_cnt.TabIndex = 14;
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_pass.Location = new System.Drawing.Point(209, 152);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(267, 34);
            this.txt_pass.TabIndex = 13;
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_username.Location = new System.Drawing.Point(209, 97);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(267, 34);
            this.txt_username.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(57, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(57, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Username";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_connect);
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.chkbox_default);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_cnt);
            this.panel1.Controls.Add(this.txt_pass);
            this.panel1.Location = new System.Drawing.Point(103, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 353);
            this.panel1.TabIndex = 19;
            // 
            // ConnectDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ConnectDB";
            this.Text = "ConnectDB";
            this.Load += new System.EventHandler(this.ConnectDB_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkbox_default;
        private System.Windows.Forms.TextBox txt_cnt;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}