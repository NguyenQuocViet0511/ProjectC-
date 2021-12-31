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
    public partial class Form_QuenMatKhau : Form
    {
        ListUser ListUser;
        public Form_QuenMatKhau()
        {
            InitializeComponent();
        }

        private void lblQuayLai_Click(object sender, EventArgs e)
        {
        
            this.Hide();
       
        }
        private bool KiemTraEmail(string inputEmail)
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
        private bool KiemTraTenEmail()
        {
            string Email = txtEmail.Text;

            for (int j = 0; j < Const.ListUser.Count; j++)
            {
                if (Email.Equals(Const.ListUser[j].Email1))
                {
                    Const.User.MaID1 = Const.ListUser[j].MaID1;
                    Const.User.HovaTen1 = Const.ListUser[j].HovaTen1;
                    Const.User.GioiTinh1 = Const.ListUser[j].GioiTinh1;
                    Const.User.Ngaysinh1 = Const.ListUser[j].Ngaysinh1;
                    Const.User.TenTaiKhoan1 = Const.ListUser[j].TenTaiKhoan1;
                    Const.User.Matkhau1 = Const.ListUser[j].Matkhau1;
                    Const.User.DiaChi1 = Const.ListUser[j].DiaChi1;
                    Const.User.Quyen1 = Const.ListUser[j].Quyen1;
                    return true;
                }

            }
            return false;
        }
        private void BtnGuiEmail_Click(object sender, EventArgs e)
        {
            ListUser = new ListUser();
            ListUser.DocFile(Const.Pathfile);
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                lblemail.Text = "Vui Lòng Không được Dể Trống";
            }
            else
            {
                lblemail.Text = ""; 
            }
            if (!String.IsNullOrEmpty(txtEmail.Text))
            {
                if (KiemTraEmail(txtEmail.Text))
                {
                    if (KiemTraTenEmail())
                    {
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
                            mail.Subject = "Lấy Lại Mật Khẩu";
                            mail.Body = "Đây là Mã Code" + "" + randomString;
                            SmtpServer.Port = 587;
                            SmtpServer.Credentials = new System.Net.NetworkCredential("thuykieunguyen310@gmail.com", "etqhxcumxrodcatq");
                            SmtpServer.EnableSsl = true;

                            SmtpServer.Send(mail);

                            Form_CheckCodeQuenMatKhau form_CheckCodeQuenMatKhau = new Form_CheckCodeQuenMatKhau();
                            this.Hide();
                            form_CheckCodeQuenMatKhau.checkCode = randomString;
                            form_CheckCodeQuenMatKhau.ShowDialog();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    else
                    {
                        
                        MessageBox.Show("Email Này Không tồn Tại Vui Lòng Nhập Vào Email Khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
                else
                {
                    MessageBox.Show("Email Bạn Nhập Không đúng Định Dạng Vui Lòng Nhập lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

           
           
        }

        private void lblQuayLai_MouseHover(object sender, EventArgs e)
        {
            lblQuayLai.ForeColor = Color.Red;
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
        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //private Boolean CheckEmail()
        //{
        //    for()

        //    return false;
        //}
    }
}
