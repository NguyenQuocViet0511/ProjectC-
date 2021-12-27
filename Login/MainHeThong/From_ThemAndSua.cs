using Login.Data;
using Login.DataUser;
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

namespace Login.MainHeThong
{
    public partial class From_ThemAndSua : Form
    {
        public bool Open = true;
        public bool Hide = true;
        public User UserEdit = new User();
        int id;
        public From_ThemAndSua()
        {
            InitializeComponent();
        }
        ListUser ListUser = new ListUser();
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BtnDangKy_Click(object sender, EventArgs e)
        {
            Open = true;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
            Open = true;
        }
        public void LoadAdd()
        {
            lbltieudechinh.Text = "Thêm Tài Khoản";
            lbltieude.Text = "Thêm Người Dùng Mới";
        }
        public void LoadEdit()
        {
            lbltieudechinh.Text = "Sửa Tài Khoản";
            lbltieude.Text = "Sửa Thông Tin Người Dùng";
        }
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
                if (a > number)
                {
                    number = a;
                  
                }              
            }
                 number += 1;
                 id = number;
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
        private void btndongy_Click(object sender, EventArgs e)
        {
            if(Open == true)
            {
                if (!String.IsNullOrEmpty(txtHoVaTen.Text) && !String.IsNullOrEmpty(txtTenDangNhap.Text) && !String.IsNullOrEmpty(txtMatKhau.Text) && rdnNam.Checked == true || rdnNu.Checked == true)
                {
                    LoadId();
                    User user;
                    if (KiemTraTenDangNhap())
                    {
                        MessageBox.Show("Tài Khoản Này Đã Có Vui Lòng Thử Tài Khoản Khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        user = new User();
                        user.MaID1 = id;
                        user.HovaTen1 = txtHoVaTen.Text;
                        if (rdnNam.Checked == true)
                        {
                            user.GioiTinh1 = "Nam";
                        }
                        else
                        {
                            user.GioiTinh1 = "Nữ";
                        }
                        user.TenTaiKhoan1 = txtTenDangNhap.Text;
                        user.Matkhau1 = txtMatKhau.Text;
                        user.Quyen1 = "user";
                        Const.ListUser.Add(user);
                        ListUser.GhiFile(Const.Pathfile);
                        MyMessageBox_1.ShowBox("Bạn Thêm Thành Công ", "Thông Báo");
                        LoadData();
                        this.Close();
                    }
                }
            }
            else
                {
                    ListUser = new ListUser();
                    ListUser.DocFile(Const.Pathfile);
                    for (int i = 0; i < Const.ListUser.Count; i++)
                    {
                        if (Const.ListUser[i].Equals(UserEdit))
                        {
                            Const.ListUser[i].HovaTen1 = txtHoVaTen.Text;
                            if(rdnNam.Checked == true)
                            {
                                Const.ListUser[i].GioiTinh1 = "Nam";
                            }else
                            {
                                Const.ListUser[i].GioiTinh1 = "Nữ";
                            }
                            Const.ListUser[i].TenTaiKhoan1 = txtTenDangNhap.Text;
                            Const.ListUser[i].Matkhau1 = txtMatKhau.Text;
                            MessageBox.Show("Sửa Thông Tin Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            ListUser.GhiFile(Const.Pathfile);
                            LoadData();
                            Open = true;
                        }

                      
                }
                   
                





            }
        }

        private void rdnNu_Click(object sender, EventArgs e)
        {
            if(rdnNu.Checked == true)
            {
                rdnNam.Checked = false;
            }
            if (rdnNam.Checked == true)
            {
                rdnNu.Checked = false;
            }
        }

        private void rdnNam_Click(object sender, EventArgs e)
        {
            if (rdnNu.Checked == true)
            {
                rdnNam.Checked = false;
            }
            if (rdnNam.Checked == true)
            {
                rdnNu.Checked = false;
            }
        }
        //
        public delegate void _LoadData();
        public _LoadData LoadData;
        //
        public void LoadDataLenBang()
        {
        
            txtHoVaTen.Text = UserEdit.HovaTen1;
            if(UserEdit.GioiTinh1.Equals("Nam"))
            {
                rdnNam.Checked = true;
            }
            else
            {
                rdnNu.Checked = true;
            }
            txtTenDangNhap.Text = UserEdit.TenTaiKhoan1;
            txtMatKhau.Text = UserEdit.Matkhau1;
            
        }

        private void lblhide_Click(object sender, EventArgs e)
        {

            if (Hide == true)
            {
                txtMatKhau.UseSystemPasswordChar = false;
                lblhide.Image = global::Login.Properties.Resources.eye_26px;
                Hide = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
                lblhide.Image = global::Login.Properties.Resources.invisible_26px;
                Hide = true;
            }
        }
    }
}
