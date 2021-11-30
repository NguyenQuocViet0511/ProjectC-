
namespace Login.Fromlogin
{
    partial class Form_DangKy
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblThongBaoHoVaTen = new System.Windows.Forms.Label();
            this.BtnDangKy = new System.Windows.Forms.Button();
            this.lblQuayLai = new System.Windows.Forms.Label();
            this.CheckDongY = new System.Windows.Forms.CheckBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtHoVaTen = new MyCustom.WaterTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new MyCustom.WaterTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatKhau = new MyCustom.WaterTextBox();
            this.txtEmail = new MyCustom.WaterTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbltendangnhap = new System.Windows.Forms.Label();
            this.lblmatkhau = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(135, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 38);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tạo Tài Khoản Mới";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblemail);
            this.panel1.Controls.Add(this.lblmatkhau);
            this.panel1.Controls.Add(this.lbltendangnhap);
            this.panel1.Controls.Add(this.lblThongBaoHoVaTen);
            this.panel1.Controls.Add(this.BtnDangKy);
            this.panel1.Controls.Add(this.lblQuayLai);
            this.panel1.Controls.Add(this.CheckDongY);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtHoVaTen);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtTenDangNhap);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtMatKhau);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(31, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 435);
            this.panel1.TabIndex = 13;
            // 
            // lblThongBaoHoVaTen
            // 
            this.lblThongBaoHoVaTen.ForeColor = System.Drawing.Color.Red;
            this.lblThongBaoHoVaTen.Location = new System.Drawing.Point(80, 59);
            this.lblThongBaoHoVaTen.Name = "lblThongBaoHoVaTen";
            this.lblThongBaoHoVaTen.Size = new System.Drawing.Size(425, 13);
            this.lblThongBaoHoVaTen.TabIndex = 20;
            // 
            // BtnDangKy
            // 
            this.BtnDangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnDangKy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDangKy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDangKy.Location = new System.Drawing.Point(162, 327);
            this.BtnDangKy.Name = "BtnDangKy";
            this.BtnDangKy.Size = new System.Drawing.Size(230, 40);
            this.BtnDangKy.TabIndex = 19;
            this.BtnDangKy.Text = "Đăng Ký";
            this.BtnDangKy.UseVisualStyleBackColor = false;
            this.BtnDangKy.Click += new System.EventHandler(this.BtnDangKy_Click);
            // 
            // lblQuayLai
            // 
            this.lblQuayLai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuayLai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblQuayLai.Image = global::Login.Properties.Resources.left_20px;
            this.lblQuayLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblQuayLai.Location = new System.Drawing.Point(192, 386);
            this.lblQuayLai.Name = "lblQuayLai";
            this.lblQuayLai.Size = new System.Drawing.Size(182, 25);
            this.lblQuayLai.TabIndex = 18;
            this.lblQuayLai.Text = "Quay Lại Đăng Nhập";
            this.lblQuayLai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQuayLai.Click += new System.EventHandler(this.lblQuayLai_Click);
            this.lblQuayLai.MouseHover += new System.EventHandler(this.lblQuayLai_MouseHover);
            // 
            // CheckDongY
            // 
            this.CheckDongY.AutoSize = true;
            this.CheckDongY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckDongY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckDongY.Location = new System.Drawing.Point(57, 290);
            this.CheckDongY.Name = "CheckDongY";
            this.CheckDongY.Size = new System.Drawing.Size(148, 21);
            this.CheckDongY.TabIndex = 17;
            this.CheckDongY.Text = "đồng ý Điều Khoản";
            this.CheckDongY.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pictureBox4.Location = new System.Drawing.Point(55, 260);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(450, 2);
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pictureBox3.Location = new System.Drawing.Point(55, 189);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(450, 2);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pictureBox2.Location = new System.Drawing.Point(55, 121);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(450, 2);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pictureBox1.Location = new System.Drawing.Point(55, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 2);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoVaTen.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtHoVaTen.Location = new System.Drawing.Point(83, 20);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(422, 32);
            this.txtHoVaTen.TabIndex = 0;
            this.txtHoVaTen.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtHoVaTen.WaterMarkText = "Họ Và Tên ";
            // 
            // label5
            // 
            this.label5.Image = global::Login.Properties.Resources.icons8_secured_letter_20px_1;
            this.label5.Location = new System.Drawing.Point(54, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 30);
            this.label5.TabIndex = 12;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenDangNhap.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTenDangNhap.Location = new System.Drawing.Point(83, 85);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(422, 32);
            this.txtTenDangNhap.TabIndex = 1;
            this.txtTenDangNhap.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtTenDangNhap.WaterMarkText = "Tên Đăng Nhập";
            // 
            // label4
            // 
            this.label4.Image = global::Login.Properties.Resources.user;
            this.label4.Location = new System.Drawing.Point(54, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 30);
            this.label4.TabIndex = 11;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMatKhau.Location = new System.Drawing.Point(83, 152);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(422, 32);
            this.txtMatKhau.TabIndex = 2;
            this.txtMatKhau.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtMatKhau.WaterMarkText = "Mật Khẩu";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEmail.Location = new System.Drawing.Point(83, 223);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(422, 32);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtEmail.WaterMarkText = "Email";
            // 
            // label2
            // 
            this.label2.Image = global::Login.Properties.Resources.pass;
            this.label2.Location = new System.Drawing.Point(54, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 30);
            this.label2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Image = global::Login.Properties.Resources.icons8_name_20px_1;
            this.label1.Location = new System.Drawing.Point(54, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 30);
            this.label1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(31, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 60);
            this.panel2.TabIndex = 14;
            // 
            // lbltendangnhap
            // 
            this.lbltendangnhap.ForeColor = System.Drawing.Color.Red;
            this.lbltendangnhap.Location = new System.Drawing.Point(80, 126);
            this.lbltendangnhap.Name = "lbltendangnhap";
            this.lbltendangnhap.Size = new System.Drawing.Size(425, 13);
            this.lbltendangnhap.TabIndex = 21;
            // 
            // lblmatkhau
            // 
            this.lblmatkhau.ForeColor = System.Drawing.Color.Red;
            this.lblmatkhau.Location = new System.Drawing.Point(80, 194);
            this.lblmatkhau.Name = "lblmatkhau";
            this.lblmatkhau.Size = new System.Drawing.Size(425, 13);
            this.lblmatkhau.TabIndex = 22;
            // 
            // lblemail
            // 
            this.lblemail.ForeColor = System.Drawing.Color.Red;
            this.lblemail.Location = new System.Drawing.Point(80, 264);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(425, 13);
            this.lblemail.TabIndex = 23;
            // 
            // Form_DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(621, 541);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form_DangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Ký Tài Khoản Mới";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MyCustom.WaterTextBox txtHoVaTen;
        private MyCustom.WaterTextBox txtTenDangNhap;
        private MyCustom.WaterTextBox txtMatKhau;
        private MyCustom.WaterTextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblQuayLai;
        private System.Windows.Forms.CheckBox CheckDongY;
        private System.Windows.Forms.Button BtnDangKy;
        private System.Windows.Forms.Label lblThongBaoHoVaTen;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblmatkhau;
        private System.Windows.Forms.Label lbltendangnhap;
    }
}