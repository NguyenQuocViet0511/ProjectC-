using Login.Data;
using Login.DataUser;
using Login.Fromlogin;
using Login.FromMain;
using Login.MyCustome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Frm_Login : Form
    {
        private bool Hide = true;
        public Frm_Login()
        {
            InitializeComponent();
           
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = Properties.Settings.Default.Account;
            txtMatkhau.Text = Properties.Settings.Default.Password;
        }


        public delegate void _LoadDataname();
        public _LoadDataname LoadDataname;
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

                    MyMessageBox_1.ShowBox("Bạn Đã Đăng Nhập Thành Công", "Thông Báo");
                    LoadDataname();


                    this.Close();
                  

                }
                else
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
                    Const.UserLogin = Const.ListUser[i];
                    return true;
                }
            }
            return false;
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


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
            String result = MyMessageBox.ShowBox("Bạn có Muốn Thoát không ", "Thông Báo");

            if (result.Equals("1"))
            {

                Application.Exit();

            }
        }

        private void LDangKyTaiKhoan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.Hide();
            Form_DangKy form_DangKy = new Form_DangKy();
            form_DangKy.ShowDialog();
   
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if(Hide == true)
            {
                txtMatkhau.UseSystemPasswordChar = false;
                lblhide.Image = global::Login.Properties.Resources.eye_26px;
                Hide = false;
            }
            else
            {
                txtMatkhau.UseSystemPasswordChar = true;
                lblhide.Image = global::Login.Properties.Resources.invisible_26px;
                Hide = true;
            }
        }

      

        private void rjButton1_Click_1(object sender, EventArgs e)
        {
            String Result = MyMessageBox.ShowBox("Bạn Có Muốn Thoát Không", "Thông Báo");
            if (Result.Equals("1"))
            {
                Application.Exit();
            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    
}
}
