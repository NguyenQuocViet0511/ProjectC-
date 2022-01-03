using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Login.Data;
using Login.FromMain.Form_DoiMatkhau;
using Login.FromMain.Form_QuanLyLop;
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
     
            Trangchu();
        
            MenuBar();
            timeDate.Enabled = true;
           
        }

   

        private void From_Main_Load(object sender, EventArgs e)
        {
            
            Frm_Login frm_Login = new Frm_Login() { LoadDataname = new Frm_Login._LoadDataname(LoadDataname)};
           
            frm_Login.ShowDialog();
            lblLoginName.Text = "Đang Đăng Nhập Bởi Người Dùng " + Const.UserLogin.HovaTen1;
        }
        public delegate void _LoadDataname();
      
        public void LoadDataname()
        {

            
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
                    btnimg.Image = global::Login.Properties.Resources.logo3;
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

      

       
        private void PhanQuyen()
        {
            switch(Const.UserLogin.Quyen1)
            {
                case "Admin":
                    BtnAdmin.Enabled = true;
                    BtnQuanLiLop.Enabled = true;
                    BtnQuanLiSinhVien.Enabled = true;
                    break;
                case "Manager":
                    BtnAdmin.Enabled = true;
                    BtnQuanLiLop.Enabled = true;
                    BtnQuanLiSinhVien.Enabled = true;
                    break;
                case "user":
                    BtnAdmin.Enabled = false;
                    BtnQuanLiLop.Enabled = false;
                    BtnQuanLiSinhVien.Enabled = false;
                    break;

            }
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
                Const.UserLogin = null;
                Frm_Login frm_Login = new Frm_Login() { LoadDataname = new Frm_Login._LoadDataname(LoadDataname) };

                tabMain.Tabs.Clear();
                Trangchu();
                
                frm_Login.ShowDialog();
            }
           
        }

        private void btnTrangChu_Click_1(object sender, EventArgs e)
        {
            if(PanelMenu.Width < 101)
            {
                MenuBar();
            }
            Trangchu();
          
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            if (PanelMenu.Width < 101)
            {
                MenuBar();
            }
            admin();
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
            QuanLiLop();
        }

        private void BtnQuanLiSinhVien_Click(object sender, EventArgs e)
        {
            if (PanelMenu.Width < 101)
            {
                MenuBar();
            }
            QuanLiSinhVien();
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
        //
        private void Dongtab()
        {
            foreach (TabItem item in tabMain.Tabs)
            {
                if (item.IsSelected)
                {
                    tabMain.Tabs.Remove(item);
                    return;
                }
            }
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
        //quan li tai khoan
        private void admin()
        {

            this.TrangThaiMo = true;
            this.tieudeTab = "Quản Lí Tài Khoản";
            if (!CheckOpenTab(tieudeTab))
            {
                TabItem tab = tabMain.CreateTab(tieudeTab);
                tab.Name = "Quản Lí Tài Khoản";
                From_quanLiTaiKhoan from_QuanLiTaiKhoan = new From_quanLiTaiKhoan()
                {
                    
                    from_QuanLiTaiKhoan = this,
                    TopLevel = false,
                    Dock = DockStyle.Fill
                };
                tab.AttachedControl.Controls.Add(from_QuanLiTaiKhoan);
                from_QuanLiTaiKhoan.Show();
                tabMain.SelectedTabIndex = tabMain.Tabs.Count - 1;
            }
        }
        //trang chu
        private void Trangchu()
        {

            this.TrangThaiMo = true;
            this.tieudeTab = "Trang Chủ";
            if (!CheckOpenTab(tieudeTab))
            {
                TabItem tab = tabMain.CreateTab(tieudeTab);
                tab.Name = "Trang Chủ";
                From_TrangChu from_TrangChu = new From_TrangChu()
                {

                    motabSV = new From_TrangChu._MotabSV(motabSV),
                    motabAdmin = new From_TrangChu._MotabAdmin(motabAdmin),
                    motabLop = new From_TrangChu._MotabLop(motabLop),
                    from_TrangChu = this,
                    TopLevel = false,
                    Dock = DockStyle.Fill
                };
                tab.AttachedControl.Controls.Add(from_TrangChu);
           
                from_TrangChu.Show();
                tabMain.SelectedTabIndex = tabMain.Tabs.Count - 1;
            }
        }
        //quan li sinh vien

        private void QuanLiSinhVien()
        {

            this.TrangThaiMo = true;
            this.tieudeTab = "Quản Lí Sinh Viên";
            if (!CheckOpenTab(tieudeTab))
            {
                TabItem tab = tabMain.CreateTab(tieudeTab);
                tab.Name = "Sinh Viên";
                Form_QuanLySinhVien.Form_QuanLySinhVien form_QuanLySinhVien = new Form_QuanLySinhVien.Form_QuanLySinhVien()
                {

                    form_QuanLySinhVien = this,
                    TopLevel = false,
                    Dock = DockStyle.Fill
                };
                tab.AttachedControl.Controls.Add(form_QuanLySinhVien);
                form_QuanLySinhVien.Show();
                tabMain.SelectedTabIndex = tabMain.Tabs.Count - 1;
            }
        }
        //quan li lop
        private void QuanLiLop()
        {

            this.TrangThaiMo = true;
            this.tieudeTab = "Quản Lí Lớp";
            if (!CheckOpenTab(tieudeTab))
            {
                TabItem tab = tabMain.CreateTab(tieudeTab);
                tab.Name = "Lớp";
                From_QuanLyLop from_QuanLyLop = new From_QuanLyLop()
                {

                    from_QuanLyLop = this,
                    TopLevel = false,
                    Dock = DockStyle.Fill
                };
                tab.AttachedControl.Controls.Add(from_QuanLyLop);
                from_QuanLyLop.Show();
                tabMain.SelectedTabIndex = tabMain.Tabs.Count - 1;
            }
        }
        #endregion

        private void tabMain_TabItemClose_1(object sender, TabStripActionEventArgs e)
        {
            String Result = MyMessageBox.ShowBox("Bạn Có Muốn Thoát Không ", "Thông Báo");
            if (Result.Equals("1"))
            {
                TabItem tab = tabMain.SelectedTab;
                tabMain.Tabs.Remove(tab);
            }
        }


        //mo tab
        public From_Main Frm;
        public delegate void _MotabSV();
        public delegate void _MotabAdmin();
        public delegate void _MotabLop();


        //



        private void motabSV()
        {
            QuanLiSinhVien();
        }
        private void motabAdmin()
        {
            admin();
        }
        private void motabLop()
        {
            QuanLiLop();
        }
        //
    }
}