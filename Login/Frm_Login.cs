using Login.Data;
using Login.Fromlogin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Frm_Login : Form
    {
        Boolean isThoat = true;
        public Frm_Login()
        {
            InitializeComponent();
            user = new UserDao();
        }
        UserDao user;
        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDangNhap.Text))
            {
                LblThongBapTenDangNhap.Text = "Vui Lòng Không được Để Trống";
               
            }
            else
            {
                LblThongBapTenDangNhap.Text = "";
            }
            if (String.IsNullOrEmpty(txtMatkhau.Text))
                {
                    LblThongBaoMatKhau.Text = "Vui Lòng Không được Để Trống";
            }
            else { 
               
                    LblThongBaoMatKhau.Text = "";
            }
            if (!string.IsNullOrEmpty(txtTenDangNhap.Text) && !string.IsNullOrEmpty(txtMatkhau.Text))
               
                if (KiemTraDangNhap(txtTenDangNhap.Text, txtMatkhau.Text))
                {
                              this.Close();
                
                 }else
            {
                    LblThongBapTenDangNhap.Text = "Sai Tên Tài Khoản Hoặc Mật Khẩu";
                    LblThongBaoMatKhau.Text = "Sai Tên Tài Khoản Hoặc Mật Khẩu";
                }




        }

        private bool KiemTraDangNhap(string userName, string passWord)
        {
            if(user.user.UserName.Equals(userName) && user.user.PassWord.Equals(passWord))
            {
                return true;
            }
            return false;
        }


   
       

        private void LQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void LQuenMatKhau_MouseHover(object sender, EventArgs e)
        {
            //LQuenMatKhau.ForeColor = Color.Red;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có Muốn Thoát chương trình không ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {

                Application.Exit();



            }
        }

        private void LDangKyTaiKhoan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_DangKy form_DangKy = new Form_DangKy();
            form_DangKy.ShowDialog();
        }
    }
}
