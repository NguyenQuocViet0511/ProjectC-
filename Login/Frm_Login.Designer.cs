
namespace Login
{
    partial class Frm_Login
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.LblThongBapTenDangNhap = new System.Windows.Forms.Label();
            this.LblThongBaoMatKhau = new System.Windows.Forms.Label();
            this.txtMatkhau = new MyCustom.WaterTextBox();
            this.txtTenDangNhap = new MyCustom.WaterTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LDangKyTaiKhoan = new System.Windows.Forms.LinkLabel();
            this.LQuenMatKhau = new System.Windows.Forms.LinkLabel();
            this.Remember = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(21, 212);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(233, 53);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Tag = "";
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(199, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Đăng Nhập";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.LblThongBapTenDangNhap);
            this.panel1.Controls.Add(this.LblThongBaoMatKhau);
            this.panel1.Controls.Add(this.txtMatkhau);
            this.panel1.Controls.Add(this.txtTenDangNhap);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.LDangKyTaiKhoan);
            this.panel1.Controls.Add(this.LQuenMatKhau);
            this.panel1.Controls.Add(this.Remember);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Location = new System.Drawing.Point(23, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 368);
            this.panel1.TabIndex = 8;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(290, 212);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(221, 53);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // LblThongBapTenDangNhap
            // 
            this.LblThongBapTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblThongBapTenDangNhap.ForeColor = System.Drawing.Color.Red;
            this.LblThongBapTenDangNhap.Location = new System.Drawing.Point(44, 65);
            this.LblThongBapTenDangNhap.Name = "LblThongBapTenDangNhap";
            this.LblThongBapTenDangNhap.Size = new System.Drawing.Size(467, 22);
            this.LblThongBapTenDangNhap.TabIndex = 15;
            // 
            // LblThongBaoMatKhau
            // 
            this.LblThongBaoMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblThongBaoMatKhau.ForeColor = System.Drawing.Color.Red;
            this.LblThongBaoMatKhau.Location = new System.Drawing.Point(44, 152);
            this.LblThongBaoMatKhau.Name = "LblThongBaoMatKhau";
            this.LblThongBaoMatKhau.Size = new System.Drawing.Size(467, 22);
            this.LblThongBaoMatKhau.TabIndex = 14;
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatkhau.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMatkhau.Location = new System.Drawing.Point(52, 110);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(459, 32);
            this.txtMatkhau.TabIndex = 2;
            this.txtMatkhau.Tag = "";
            this.txtMatkhau.UseSystemPasswordChar = true;
            this.txtMatkhau.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtMatkhau.WaterMarkText = "Mật Khẩu";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenDangNhap.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTenDangNhap.Location = new System.Drawing.Point(52, 24);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(459, 32);
            this.txtTenDangNhap.TabIndex = 1;
            this.txtTenDangNhap.Tag = "";
            this.txtTenDangNhap.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtTenDangNhap.WaterMarkText = "Tên Đăng Nhập";
            // 
            // label3
            // 
            this.label3.Image = global::Login.Properties.Resources.pass;
            this.label3.Location = new System.Drawing.Point(16, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 27);
            this.label3.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Blue;
            this.pictureBox2.Location = new System.Drawing.Point(21, 147);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(490, 2);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Image = global::Login.Properties.Resources.user;
            this.label2.Location = new System.Drawing.Point(16, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 27);
            this.label2.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Blue;
            this.pictureBox1.Location = new System.Drawing.Point(21, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(490, 2);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // LDangKyTaiKhoan
            // 
            this.LDangKyTaiKhoan.ActiveLinkColor = System.Drawing.Color.Red;
            this.LDangKyTaiKhoan.AutoSize = true;
            this.LDangKyTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LDangKyTaiKhoan.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LDangKyTaiKhoan.Location = new System.Drawing.Point(42, 295);
            this.LDangKyTaiKhoan.Name = "LDangKyTaiKhoan";
            this.LDangKyTaiKhoan.Size = new System.Drawing.Size(454, 29);
            this.LDangKyTaiKhoan.TabIndex = 7;
            this.LDangKyTaiKhoan.TabStop = true;
            this.LDangKyTaiKhoan.Text = "Đăng Ký Tài Khoản Tại Đây nếu chưa có?";
            this.LDangKyTaiKhoan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LDangKyTaiKhoan_LinkClicked);
            // 
            // LQuenMatKhau
            // 
            this.LQuenMatKhau.AutoSize = true;
            this.LQuenMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LQuenMatKhau.Location = new System.Drawing.Point(393, 174);
            this.LQuenMatKhau.Name = "LQuenMatKhau";
            this.LQuenMatKhau.Size = new System.Drawing.Size(118, 20);
            this.LQuenMatKhau.TabIndex = 4;
            this.LQuenMatKhau.TabStop = true;
            this.LQuenMatKhau.Tag = "";
            this.LQuenMatKhau.Text = "Quên Mật khẩu";
            this.LQuenMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LQuenMatKhau_LinkClicked);
            this.LQuenMatKhau.MouseHover += new System.EventHandler(this.LQuenMatKhau_MouseHover);
            // 
            // Remember
            // 
            this.Remember.AutoSize = true;
            this.Remember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Remember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Remember.ForeColor = System.Drawing.Color.Blue;
            this.Remember.Location = new System.Drawing.Point(21, 174);
            this.Remember.Name = "Remember";
            this.Remember.Size = new System.Drawing.Size(216, 24);
            this.Remember.TabIndex = 3;
            this.Remember.Tag = "";
            this.Remember.Text = "Nhớ tài khoản và mật khẩu";
            this.Remember.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(23, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 52);
            this.panel2.TabIndex = 6;
            // 
            // Frm_Login
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(577, 457);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập Tài Khoản";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel LDangKyTaiKhoan;
        private System.Windows.Forms.LinkLabel LQuenMatKhau;
        private System.Windows.Forms.CheckBox Remember;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MyCustom.WaterTextBox txtTenDangNhap;
        private MyCustom.WaterTextBox txtMatkhau;
        private System.Windows.Forms.Label LblThongBaoMatKhau;
        private System.Windows.Forms.Label LblThongBapTenDangNhap;
        private System.Windows.Forms.Button btnExit;
    }
}

