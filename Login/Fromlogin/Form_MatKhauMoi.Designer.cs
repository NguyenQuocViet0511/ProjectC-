
namespace Login.Fromlogin
{
    partial class Form_MatKhauMoi
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CkbHienMatKhau = new System.Windows.Forms.CheckBox();
            this.TxtNhapLaiMatKhau = new MyCustom.WaterTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMatkhauMoi = new MyCustom.WaterTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuayLai = new System.Windows.Forms.Label();
            this.BtnXacMinhCode = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(524, 60);
            this.panel2.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(93, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 38);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mật Khẩu Mới";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.CkbHienMatKhau);
            this.panel1.Controls.Add(this.TxtNhapLaiMatKhau);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtMatkhauMoi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblQuayLai);
            this.panel1.Controls.Add(this.BtnXacMinhCode);
            this.panel1.Location = new System.Drawing.Point(12, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 347);
            this.panel1.TabIndex = 27;
            // 
            // CkbHienMatKhau
            // 
            this.CkbHienMatKhau.AutoSize = true;
            this.CkbHienMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CkbHienMatKhau.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CkbHienMatKhau.Location = new System.Drawing.Point(23, 200);
            this.CkbHienMatKhau.Name = "CkbHienMatKhau";
            this.CkbHienMatKhau.Size = new System.Drawing.Size(97, 18);
            this.CkbHienMatKhau.TabIndex = 31;
            this.CkbHienMatKhau.Text = "Hiện Mật Khẩu";
            this.CkbHienMatKhau.UseVisualStyleBackColor = true;
            this.CkbHienMatKhau.CheckedChanged += new System.EventHandler(this.CkbHienMatKhau_CheckedChanged);
            // 
            // TxtNhapLaiMatKhau
            // 
            this.TxtNhapLaiMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNhapLaiMatKhau.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtNhapLaiMatKhau.Location = new System.Drawing.Point(50, 136);
            this.TxtNhapLaiMatKhau.Name = "TxtNhapLaiMatKhau";
            this.TxtNhapLaiMatKhau.Size = new System.Drawing.Size(459, 32);
            this.TxtNhapLaiMatKhau.TabIndex = 28;
            this.TxtNhapLaiMatKhau.Tag = "";
            this.TxtNhapLaiMatKhau.UseSystemPasswordChar = true;
            this.TxtNhapLaiMatKhau.WaterMarkColor = System.Drawing.Color.Gray;
            this.TxtNhapLaiMatKhau.WaterMarkText = "Nhập Lại Mật Khẩu";
            // 
            // label4
            // 
            this.label4.Image = global::Login.Properties.Resources.pass;
            this.label4.Location = new System.Drawing.Point(14, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 27);
            this.label4.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Blue;
            this.pictureBox1.Location = new System.Drawing.Point(19, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(490, 2);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // txtMatkhauMoi
            // 
            this.txtMatkhauMoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatkhauMoi.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMatkhauMoi.Location = new System.Drawing.Point(50, 75);
            this.txtMatkhauMoi.Name = "txtMatkhauMoi";
            this.txtMatkhauMoi.Size = new System.Drawing.Size(459, 32);
            this.txtMatkhauMoi.TabIndex = 25;
            this.txtMatkhauMoi.Tag = "";
            this.txtMatkhauMoi.UseSystemPasswordChar = true;
            this.txtMatkhauMoi.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtMatkhauMoi.WaterMarkText = "Mật Khẩu Mới";
            // 
            // label2
            // 
            this.label2.Image = global::Login.Properties.Resources.pass;
            this.label2.Location = new System.Drawing.Point(14, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 27);
            this.label2.TabIndex = 27;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Blue;
            this.pictureBox2.Location = new System.Drawing.Point(19, 112);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(490, 2);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(46, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 61);
            this.label1.TabIndex = 24;
            this.label1.Text = "Vui Lòng Nhập Vào Mật Khẩu Mới Để Hoàn Tất ";
            // 
            // lblQuayLai
            // 
            this.lblQuayLai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuayLai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblQuayLai.Image = global::Login.Properties.Resources.left_20px;
            this.lblQuayLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblQuayLai.Location = new System.Drawing.Point(170, 295);
            this.lblQuayLai.Name = "lblQuayLai";
            this.lblQuayLai.Size = new System.Drawing.Size(182, 25);
            this.lblQuayLai.TabIndex = 23;
            this.lblQuayLai.Text = "Quay Lại Đăng Nhập";
            this.lblQuayLai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQuayLai.Click += new System.EventHandler(this.lblQuayLai_Click);
            this.lblQuayLai.MouseHover += new System.EventHandler(this.lblQuayLai_MouseHover);
            // 
            // BtnXacMinhCode
            // 
            this.BtnXacMinhCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnXacMinhCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnXacMinhCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnXacMinhCode.Location = new System.Drawing.Point(142, 237);
            this.BtnXacMinhCode.Name = "BtnXacMinhCode";
            this.BtnXacMinhCode.Size = new System.Drawing.Size(230, 40);
            this.BtnXacMinhCode.TabIndex = 20;
            this.BtnXacMinhCode.Text = "Xác Nhận";
            this.BtnXacMinhCode.UseVisualStyleBackColor = false;
            this.BtnXacMinhCode.Click += new System.EventHandler(this.BtnXacMinhCode_Click);
            // 
            // Form_MatKhauMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(549, 440);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form_MatKhauMoi";
            this.Text = "Mật Khẩu Mới";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuayLai;
        private System.Windows.Forms.Button BtnXacMinhCode;
        private MyCustom.WaterTextBox TxtNhapLaiMatKhau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MyCustom.WaterTextBox txtMatkhauMoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox CkbHienMatKhau;
    }
}