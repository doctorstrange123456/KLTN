namespace KhoaLuanTotNghiep
{
    partial class frmLogin
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
            this.lblDangNhap = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.chkGhiNho = new System.Windows.Forms.CheckBox();
            this.chkHienThi = new System.Windows.Forms.CheckBox();
            this.pnDangNhap = new System.Windows.Forms.Panel();
            this.pnDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDangNhap
            // 
            this.lblDangNhap.AutoSize = true;
            this.lblDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.lblDangNhap.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangNhap.ForeColor = System.Drawing.Color.White;
            this.lblDangNhap.Location = new System.Drawing.Point(96, 45);
            this.lblDangNhap.Name = "lblDangNhap";
            this.lblDangNhap.Size = new System.Drawing.Size(214, 37);
            this.lblDangNhap.TabIndex = 0;
            this.lblDangNhap.Text = "ĐĂNG NHẬP";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(33, 130);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(111, 23);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "User Name:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.White;
            this.lblPass.Location = new System.Drawing.Point(33, 196);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(106, 23);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Pass Word:";
            // 
            // txtUser
            // 
            this.txtUser.AccessibleName = "Nhập username";
            this.txtUser.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.Black;
            this.txtUser.Location = new System.Drawing.Point(150, 130);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(211, 37);
            this.txtUser.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(150, 190);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(211, 37);
            this.txtPass.TabIndex = 2;
            this.txtPass.WordWrap = false;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.Navy;
            this.btnDangNhap.Location = new System.Drawing.Point(51, 354);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(129, 58);
            this.btnDangNhap.TabIndex = 5;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Navy;
            this.btnThoat.Location = new System.Drawing.Point(217, 354);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(129, 58);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // chkGhiNho
            // 
            this.chkGhiNho.AutoSize = true;
            this.chkGhiNho.BackColor = System.Drawing.Color.Transparent;
            this.chkGhiNho.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGhiNho.ForeColor = System.Drawing.Color.White;
            this.chkGhiNho.Location = new System.Drawing.Point(257, 283);
            this.chkGhiNho.Name = "chkGhiNho";
            this.chkGhiNho.Size = new System.Drawing.Size(89, 23);
            this.chkGhiNho.TabIndex = 4;
            this.chkGhiNho.Text = "Ghi Nhớ";
            this.chkGhiNho.UseVisualStyleBackColor = false;
            this.chkGhiNho.CheckedChanged += new System.EventHandler(this.chkGhiNho_CheckedChanged);
            // 
            // chkHienThi
            // 
            this.chkHienThi.AutoSize = true;
            this.chkHienThi.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.chkHienThi.ForeColor = System.Drawing.Color.White;
            this.chkHienThi.Location = new System.Drawing.Point(65, 284);
            this.chkHienThi.Name = "chkHienThi";
            this.chkHienThi.Size = new System.Drawing.Size(160, 23);
            this.chkHienThi.TabIndex = 7;
            this.chkHienThi.Text = "Hiển Thị Mật Khẩu";
            this.chkHienThi.UseVisualStyleBackColor = true;
            this.chkHienThi.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pnDangNhap
            // 
            this.pnDangNhap.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnDangNhap.Controls.Add(this.chkHienThi);
            this.pnDangNhap.Controls.Add(this.chkGhiNho);
            this.pnDangNhap.Controls.Add(this.btnThoat);
            this.pnDangNhap.Controls.Add(this.btnDangNhap);
            this.pnDangNhap.Controls.Add(this.txtPass);
            this.pnDangNhap.Controls.Add(this.txtUser);
            this.pnDangNhap.Controls.Add(this.lblPass);
            this.pnDangNhap.Controls.Add(this.lblUser);
            this.pnDangNhap.Controls.Add(this.lblDangNhap);
            this.pnDangNhap.Location = new System.Drawing.Point(58, 68);
            this.pnDangNhap.Name = "pnDangNhap";
            this.pnDangNhap.Size = new System.Drawing.Size(400, 471);
            this.pnDangNhap.TabIndex = 1;
            this.pnDangNhap.Paint += new System.Windows.Forms.PaintEventHandler(this.pnDangNhap_Paint);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::KhoaLuanTotNghiep.Properties.Resources.dich_vu;
            this.ClientSize = new System.Drawing.Size(516, 607);
            this.Controls.Add(this.pnDangNhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnDangNhap.ResumeLayout(false);
            this.pnDangNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDangNhap;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.CheckBox chkGhiNho;
        private System.Windows.Forms.CheckBox chkHienThi;
        private System.Windows.Forms.Panel pnDangNhap;
    }
}