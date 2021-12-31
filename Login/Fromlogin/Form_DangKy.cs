using Login.Data;
using Login.DataUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Fromlogin
{
    public partial class Form_DangKy : Form
    {
        User User;
        int id;
        ListUser ListUser;
        public Form_DangKy()
        {
            InitializeComponent();
            ListUser = new ListUser();
        }

        private void lblQuayLai_Click(object sender, EventArgs e)
        {
         
           
            this.Dispose();

            

        }

        private void lblQuayLai_MouseHover(object sender, EventArgs e)
        {
            lblQuayLai.ForeColor = Color.Red;
        }
        private void LoadId()
        {
            ListUser.DocFile(Const.Pathfile);
            List<int> rdid = new List<int>();
            int number = 1;

            for (int i = 0; i < Const.ListUser.Count; i++)
            {
                rdid.Add(Const.ListUser[i].MaID1);

            }
            for (int j = 0; j < rdid.Count; j++)
            {

                int a = rdid[j];
                if (number.Equals(a))
                {
                    number += 1;
                    id = number;
                }
                else
                {
                    id = number;
                }


            }
        }
        private bool KiemTraTenDangNhap()
        {
            string UserName = txtTenDangNhap.Text;

            for (int j = 0; j < Const.ListUser.Count; j++)
            {
                if (UserName.Equals(Const.ListUser[j].TenTaiKhoan1))
                {
                    return true;
                }

            }
            return false;
        }
        private bool KiemTraTenEmail()
        {
            string Email = txtEmail.Text;       

            for (int j = 0; j < Const.ListUser.Count; j++)
            {
                if (Email.Equals(Const.ListUser[j].Email1))
                {
                    return true;
                }

            }
            return false;
        }
        private  bool KiemTraEmail(string inputEmail)
        {
            inputEmail = inputEmail ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
        private void BtnDangKy_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtHoVaTen.Text))
            {
                lblThongBaoHoVaTen.Text = "Vui Lòng Không được để trống ";
            }
            else
            {
                lblThongBaoHoVaTen.Text = "";
            }
            if (String.IsNullOrEmpty(txtTenDangNhap.Text))
            {
                lbltendangnhap.Text = "Vui Lòng Không được để trống ";
            }
            else
            {
                lbltendangnhap.Text = "";
            }
            if (String.IsNullOrEmpty(txtMatKhau.Text))
            {
                lblmatkhau.Text = "Vui Lòng Không được để trống ";
            }
            else
            {
                lblmatkhau.Text = "";
            }
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                lblemail.Text = "Vui Lòng Không được để trống ";
            }
            else
            {
                lblemail.Text = "";
            }
            if (!String.IsNullOrEmpty(txtHoVaTen.Text) && !String.IsNullOrEmpty(txtTenDangNhap.Text) && !String.IsNullOrEmpty(txtMatKhau.Text) && !String.IsNullOrEmpty(txtEmail.Text))
            {
                LoadId();
                if (CheckDongY.Checked == true)
                {
                    if(KiemTraTenDangNhap())
                    {
                        MessageBox.Show("Tài Khoản Này Đã Có Vui Lòng Thử Tài Khoản Khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if(KiemTraEmail(txtEmail.Text))
                        {
                            if(KiemTraTenEmail())
                            {
                                MessageBox.Show("Email Này Đã tồn Tại Vui Lòng Nhập Vào Email Khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                User = new User();
                                User.MaID1 = id;
                                User.HovaTen1 = txtHoVaTen.Text;
                                User.TenTaiKhoan1 = txtTenDangNhap.Text;
                                User.Matkhau1 = txtMatKhau.Text;
                                User.Email1 = txtEmail.Text;
                                User.Quyen1 = "user";
                                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                                var random = new Random();
                                var randomString = new string(Enumerable.Repeat(chars, 6)
                                .Select(s => s[random.Next(s.Length)]).ToArray());
                                try
                                {
                                    MailMessage mail = new MailMessage();
                                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                                    mail.From = new MailAddress("your_email_address@gmail.com");
                                    mail.To.Add(txtEmail.Text);
                                    mail.Subject = "Tạo tài Khoản Mới";
                                    mail.Body = "Đây là Mã Code" + "" + randomString;
                                    SmtpServer.Port = 587;
                                    SmtpServer.Credentials = new System.Net.NetworkCredential("thuykieunguyen310@gmail.com", "etqhxcumxrodcatq");
                                    SmtpServer.EnableSsl = true;

                                    SmtpServer.Send(mail);

                                    Form_Checkcode form_Checkcode = new Form_Checkcode();
                                    this.Hide();
                                    form_Checkcode.CheckCode = randomString;
                                    form_Checkcode.UserDangKy = User;
                                    form_Checkcode.ShowDialog();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.ToString());
                                }
                            }

                         
                           
                        }
                        else
                        {
                            MessageBox.Show("Email Bạn Nhập Không đúng Định Dạng Vui Lòng Nhập lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                       
                    }
                }
                  
                else
                {
                    MessageBox.Show("Vui Lòng Chấp Nhập Thỏa Thuận", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }



        }

     

        private void rjButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
