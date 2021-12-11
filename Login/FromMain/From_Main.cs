using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Login.Data;
using Login.FromMain.Form_DoiMatkhau;
using Login.MainHeThong;
using Login.MyCustome;

namespace Login.FromMain
{
    public partial class From_Main : Form
    {
        
        private bool openMenu = true;
        public bool OpenMenu { get => openMenu; set => openMenu = value; }

        public From_Main()
        {
          
            InitializeComponent();
            //Add();
          
            MenuBar();
            timeDate.Enabled = true;
           
        }

   

        private void From_Main_Load(object sender, EventArgs e)
        {
            Frm_Login frm_Login = new Frm_Login();
            frm_Login.ShowDialog();
            lblLoginName.Text = "Đang Đăng Nhập Bởi Người Dùng " + Const.UserLogin.HovaTen1;
        }
        private void MenuBar()
        {
            if (openMenu == true)
            {
                PanelMenu.Width = 100;

                openMenu = false;
                foreach (Button menuButton in PanelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    btnimg.Dock = DockStyle.Top;
                    btnimg.Visible = true;
                    btnimg.Padding = new System.Windows.Forms.Padding(0,10,0,0);
                    img.Visible = false;
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new System.Windows.Forms.Padding(0);
                }
                BntMenu.Image = global::Login.Properties.Resources.arrow_32px;
            }
            else
            {
                PanelMenu.Width = 250;
                btnimg.Dock = DockStyle.None;
                btnimg.Visible = false;
                openMenu = true;
                img.Visible = true;
                foreach (Button menuButton in PanelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = menuButton.Tag.ToString();


                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;

                    menuButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
                }
                BntMenu.Image = global::Login.Properties.Resources.arrow_pointing_left_32px;
            }

        }

      
     

    
        private void timeDate_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lblDate.Text = String.Format("Lịch Hôm Nay Là : " + "{0:dd-MM-yyyy - hh:mm:ss tt}", dateTime);

        }







        /// 
        /// add tab  from quan li tai khoan khi nhan button quan li tai khoan
        private void btnQuanLitaikhoan_Click(object sender, EventArgs e)
        {
           QuanLitaikhoan();
        }

        private void QuanLitaikhoan()
        {

            this.TrangThaiMo = true;
            this.tieudeTab = "Quản Lí Tài Khoản";
            //if (!CheckOpenTab(tieudeTab))
            //{
            //    TabItem tab = tc_Main.CreateTab(tieudeTab);
            //    tab.Name = "Quản Lí Tai Khoản";
            //    From_quanLiTaiKhoan from_QuanLiTaiKhoan = new From_quanLiTaiKhoan()
            //    {

            //        from_QuanLiTaiKhoan = this,
            //        TopLevel = false,
            //        Dock = DockStyle.Fill
            //    };
            //    tab.AttachedControl.Controls.Add(from_QuanLiTaiKhoan);
            //    from_QuanLiTaiKhoan.Show();
            //    tc_Main.SelectedTabIndex = tc_Main.Tabs.Count - 1;



            //}
        }

      

       

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            //Add();

            }

   

        private void quảnLíTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLitaikhoan();
        }



        private void BtnThoat_Click_1(object sender, EventArgs e)
        {
            String result = MyMessageBox.ShowBox("Bạn Có Muốn Thoát Không", "Thông Báo");
            if(result.Equals("1"))
            {
                Application.Exit();
            }



        }

        private void btnDropCreen_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnZoomCreen_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }else
            {
                this.WindowState = FormWindowState.Maximized;
            }



          
        }
     

        private void BntMenu_Click(object sender, EventArgs e)
        {
            MenuBar();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            String Result = MyMessageBox.ShowBox("Bạn Có Muốn Đăng Xuất", "Thông Báo");
            if(Result.Equals("1"))
            {
                Frm_Login frm_Login = new Frm_Login();
                frm_Login.ShowDialog();
            }
           
        }

        private void btnTrangChu_Click_1(object sender, EventArgs e)
        {
            if(PanelMenu.Width < 101)
            {
                MenuBar();
            }
          
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            if (PanelMenu.Width < 101)
            {
                MenuBar();
            }
        }

        private void BtndoimatKhau_Click(object sender, EventArgs e)
        {
            if (PanelMenu.Width < 101)
            {
                MenuBar();
            }
            DoiMatkhau();
        }

        private void BtnThongtinBanThan_Click(object sender, EventArgs e)
        {
            if (PanelMenu.Width < 101)
            {
                MenuBar();
            }
            ThongtincaNhan();
        }

        private void BtnQuanLiLop_Click(object sender, EventArgs e)
        {
            if (PanelMenu.Width < 101)
            {
                MenuBar();
            }
        }

        private void BtnQuanLiSinhVien_Click(object sender, EventArgs e)
        {
            if (PanelMenu.Width < 101)
            {
                MenuBar();
            }
        }

        private void tabMain_TabItemClose(object sender, TabStripActionEventArgs e)
        {
            String Result = MyMessageBox.ShowBox("Bạn Có Muốn Thoát Không ", "Thông Báo");
            if(Result.Equals("1"))
            {
                TabItem tab = tabMain.SelectedTab;
                tabMain.Tabs.Remove(tab);
            }

        }
        #region TabControl 
        bool TrangThaiMo = false;
        public delegate void _dedongtab();
        public From_Main frm;
        string tieudeTab;
        //kiem tra Tab Mo
        private bool CheckOpenTab(String name)
        {
            for (int i = 0; i < tabMain.Tabs.Count; i++)
            {
                if (tabMain.Tabs[i].Text == name)
                {
                    tabMain.SelectedTabIndex = i;
                    return true;
                }

            }
            return false;
        }
        //Tab doi Mat Khau
        private void DoiMatkhau()
        {

            this.TrangThaiMo = true;
            this.tieudeTab = "Đổi Mật Khẩu";
            if (!CheckOpenTab(tieudeTab))
            {
                TabItem tab = tabMain.CreateTab(tieudeTab);
                tab.Name = "Đổi Mật Khẩu";
                From_doiMatKhau from_DoiMatKhau = new From_doiMatKhau()
                {

                    from_DoiMatKhau = this,
                    TopLevel = false,
                    Dock = DockStyle.Fill
                };
                tab.AttachedControl.Controls.Add(from_DoiMatKhau);
                from_DoiMatKhau.Show();
                tabMain.SelectedTabIndex = tabMain.Tabs.Count - 1;
            }
        }
        //Tab Thong Tin ca nhan
        private void ThongtincaNhan()
        {

            this.TrangThaiMo = true;
            this.tieudeTab = "Thông Tin Cá Nhân";
            if (!CheckOpenTab(tieudeTab))
            {
                TabItem tab = tabMain.CreateTab(tieudeTab);
                tab.Name = "Thông Tin Cá Nhân";
                Form_ThongTinCaNhan.From_ThongTinCaNhan thongTinCaNhan = new Form_ThongTinCaNhan.From_ThongTinCaNhan()
                {

                    thongTinCaNhan = this,
                    TopLevel = false,
                    Dock = DockStyle.Fill
                };
                tab.AttachedControl.Controls.Add(thongTinCaNhan);
                thongTinCaNhan.Show();
                tabMain.SelectedTabIndex = tabMain.Tabs.Count - 1;
            }
        }

        #endregion
    }
}