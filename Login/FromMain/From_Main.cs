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
using Login.MainHeThong;
using Login.MyCustome;

namespace Login.FromMain
{
    public partial class From_Main : Form
    {
        
        private bool openMenu = true;
        private bool MenuHethong = true;
        private bool Menugiaovien = true;
        private bool MenuSinhvien = true;

        public bool OpenMenu { get => openMenu; set => openMenu = value; }

        public From_Main()
        {
          
            InitializeComponent();
            //Add();
            MenuBar();
            MenuDrop();
            timeDate.Enabled = true;
            DropMenuHeThong.IsMainMenu = true;
            DropMenuGiaoVien.IsMainMenu = true;
            DropMenuSinhVien.IsMainMenu = true;
        }

        private void MenuDrop()

        {
           


        }

        private void From_Main_Load(object sender, EventArgs e)
        {
            Frm_Login frm_Login = new Frm_Login();
            frm_Login.ShowDialog();
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
                    btnimg.Padding = new System.Windows.Forms.Padding(0,20,0,0);
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
        /// <summary>
        /// thiet lap tab
        /// </summary>
        #region Thiet Lap Tab DoTbar2
        bool TrangThaiMo = false;
        public delegate void _dedongtab();
        
        public From_Main frm;
        string tieudeTab;
        //private bool CheckOpenTab(String name)
        //{
        //    for(int i = 0; i < tc_Main.Tabs.Count; i++)
        //    {
        //        if(tc_Main.Tabs[i].Text == name)
        //        {
        //            tc_Main.SelectedTabIndex = i ;
        //            return true;
        //        }

        //    }
        //    return false;
        //}
     
       

        #endregion

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

    //    private void Add()
    //    {
    //        this.TrangThaiMo = true;
    //        this.tieudeTab = "Trang Chủ";
    //        if (!CheckOpenTab(tieudeTab))
    //        {
    //            TabItem tab = tc_Main.CreateTab(tieudeTab);
    //            tab.Name = "Trang Chủ";
    //            From_TrangChu from_TrangChu = new From_TrangChu()
    //            {

    //                from_TrangChu = this,
    //                TopLevel = false,
    //                Dock = DockStyle.Fill
    //            };
    //            tab.AttachedControl.Controls.Add(from_TrangChu);
    //            from_TrangChu.Show();
    //            tc_Main.SelectedTabIndex = tc_Main.Tabs.Count - 1;
    //        }
    //}

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



            //private void tc_Main_TabItemClose(object sender, TabStripActionEventArgs e)
            //{
            //    if (MessageBox.Show("Bạn Có Muốn Thoát Trang Này Không ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.Cancel)
            //    {
            //        TabItem tab = tc_Main.SelectedTab;
            //        tc_Main.Tabs.Remove(tab);
            //    }
            //}
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
        }

        private void BtnThongtinBanThan_Click(object sender, EventArgs e)
        {
            if (PanelMenu.Width < 101)
            {
                MenuBar();
            }
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
    }
}