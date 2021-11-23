
namespace Login.Fromlogin
{
    partial class Form_CheckCodeQuenMatKhau
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCode = new MyCustom.WaterTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuayLai = new System.Windows.Forms.Label();
            this.BtnXacMinhCode = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.label3.Text = "Kiểm Tra Code Email";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblQuayLai);
            this.panel1.Controls.Add(this.BtnXacMinhCode);
            this.panel1.Location = new System.Drawing.Point(12, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 347);
            this.panel1.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtCode);
            this.panel3.Location = new System.Drawing.Point(50, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(423, 42);
            this.panel3.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.Image = global::Login.Properties.Resources.icons8_secured_letter_20px_1;
            this.label5.Location = new System.Drawing.Point(13, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 31);
            this.label5.TabIndex = 22;
            // 
            // txtCode
            // 
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCode.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCode.Location = new System.Drawing.Point(42, 5);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(383, 32);
            this.txtCode.TabIndex = 0;
            this.txtCode.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtCode.WaterMarkText = "Code";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(46, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 61);
            this.label1.TabIndex = 24;
            this.label1.Text = "Vui Lòng Nhập Vào Code Được Gửi Về Email Của Bạn Để Hoàn Thành Đăng Ký";
            // 
            // lblQuayLai
            // 
            this.lblQuayLai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuayLai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblQuayLai.Image = global::Login.Properties.Resources.left_20px;
            this.lblQuayLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblQuayLai.Location = new System.Drawing.Point(168, 280);
            this.lblQuayLai.Name = "lblQuayLai";
            this.lblQuayLai.Size = new System.Drawing.Size(182, 25);
            this.lblQuayLai.TabIndex = 23;
            this.lblQuayLai.Text = "Quay Lại Đăng Nhập";
            this.lblQuayLai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQuayLai.MouseHover += new System.EventHandler(this.lblQuayLai_MouseHover);
            // 
            // BtnXacMinhCode
            // 
            this.BtnXacMinhCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnXacMinhCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnXacMinhCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnXacMinhCode.Location = new System.Drawing.Point(142, 202);
            this.BtnXacMinhCode.Name = "BtnXacMinhCode";
            this.BtnXacMinhCode.Size = new System.Drawing.Size(230, 40);
            this.BtnXacMinhCode.TabIndex = 20;
            this.BtnXacMinhCode.Text = "Xác Minh Code";
            this.BtnXacMinhCode.UseVisualStyleBackColor = false;
            this.BtnXacMinhCode.Click += new System.EventHandler(this.BtnXacMinhCode_Click);
            // 
            // Form_CheckCodeQuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(549, 441);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form_CheckCodeQuenMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Kiểm Tra";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private MyCustom.WaterTextBox txtCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuayLai;
        private System.Windows.Forms.Button BtnXacMinhCode;
    }
}