
namespace Login.FromMain.Form_QuanLySinhVien
{
    partial class Form_AddUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdo_Nam = new System.Windows.Forms.RadioButton();
            this.rdo_Nu = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NgaySinh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(646, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm Sinh Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 466);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(646, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "...";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel1.Text = "...";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(190, 132);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(382, 30);
            this.txt_Name.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Họ Và Tên:";
            // 
            // rdo_Nam
            // 
            this.rdo_Nam.AutoSize = true;
            this.rdo_Nam.Location = new System.Drawing.Point(190, 178);
            this.rdo_Nam.Name = "rdo_Nam";
            this.rdo_Nam.Size = new System.Drawing.Size(71, 29);
            this.rdo_Nam.TabIndex = 6;
            this.rdo_Nam.TabStop = true;
            this.rdo_Nam.Text = "Nam";
            this.rdo_Nam.UseVisualStyleBackColor = true;
            // 
            // rdo_Nu
            // 
            this.rdo_Nu.AutoSize = true;
            this.rdo_Nu.Location = new System.Drawing.Point(337, 178);
            this.rdo_Nu.Name = "rdo_Nu";
            this.rdo_Nu.Size = new System.Drawing.Size(55, 29);
            this.rdo_Nu.TabIndex = 7;
            this.rdo_Nu.TabStop = true;
            this.rdo_Nu.Text = "Nữ";
            this.rdo_Nu.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giới Tính:";
            // 
            // txt_NgaySinh
            // 
            this.txt_NgaySinh.Location = new System.Drawing.Point(190, 225);
            this.txt_NgaySinh.Name = "txt_NgaySinh";
            this.txt_NgaySinh.Size = new System.Drawing.Size(382, 30);
            this.txt_NgaySinh.TabIndex = 10;
            this.txt_NgaySinh.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày Sinh:";
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Them.FlatAppearance.BorderSize = 0;
            this.btn_Them.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(190, 406);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(152, 45);
            this.btn_Them.TabIndex = 11;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Huy.FlatAppearance.BorderSize = 0;
            this.btn_Huy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.btn_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.ForeColor = System.Drawing.Color.White;
            this.btn_Huy.Location = new System.Drawing.Point(420, 406);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(152, 45);
            this.btn_Huy.TabIndex = 12;
            this.btn_Huy.Text = "Huỷ";
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Địa Chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Sinh Viên:";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(190, 85);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(382, 30);
            this.txt_ID.TabIndex = 3;
            this.txt_ID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(190, 273);
            this.txt_DiaChi.Multiline = true;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(382, 112);
            this.txt_DiaChi.TabIndex = 14;
            this.txt_DiaChi.Text = " ";
            // 
            // Form_AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(646, 488);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_NgaySinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdo_Nu);
            this.Controls.Add(this.rdo_Nam);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form_AddUser";
            this.Text = "Form_AddUser";
            this.Load += new System.EventHandler(this.Form_AddUser_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdo_Nam;
        private System.Windows.Forms.RadioButton rdo_Nu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_NgaySinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_DiaChi;
    }
}