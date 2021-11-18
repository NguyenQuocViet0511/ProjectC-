using Login.Data;
using Login.DataUser;
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

        public Frm_Login()
        {
            InitializeComponent();
           
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = Properties.Settings.Default.Account;
            txtMatkhau.Text = Properties.Settings.Default.Password;
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            ListUser listUser = new ListUser();
            listUser.DocFile(Const.Pathfile);
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
               
                if (KiemTraTaiKhoanDangNhap(txtTenDangNhap.Text, txtMatkhau.Text))
                {

                    MessageBox.Show("Bạn Đã Đăng Nhập Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                
                 }else
            {
                    LblThongBapTenDangNhap.Text = "Sai Tên Tài Khoản Hoặc Mật Khẩu";
                    LblThongBaoMatKhau.Text = "Sai Tên Tài Khoản Hoặc Mật Khẩu";
                }

            if (Remember.Checked)
            {
                Properties.Settings.Default.Account = txtTenDangNhap.Text;
                Properties.Settings.Default.Password = txtMatkhau.Text;
                Properties.Settings.Default.Save();

            }
            else
            {
                Properties.Settings.Default.Account = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }


        }

        private Boolean KiemTraTaiKhoanDangNhap(String TenTaiKhoan,String MatKhau)
        {
           for(int i = 0; i< Const.ListUser.Count; i++)
            {
                if(Const.ListUser[i].TenTaiKhoan1.Equals(TenTaiKhoan) && Const.ListUser[i].Matkhau1.Equals(MatKhau))
                {
                    return true;
                }
            }
            return false;
        }





        private void LQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_QuenMatKhau form_QuenMatKhau = new Form_QuenMatKhau();
            form_QuenMatKhau.ShowDialog();
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
