using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Login.MainHeThong;

namespace Login.FromMain
{
    public partial class From_Main : Form
    {
        
        private bool openMenu = false;
        private bool MenuHethong = true;
        private bool Menugiaovien = true;
        private bool MenuSinhvien = true;

        public bool OpenMenu { get => openMenu; set => openMenu = value; }

        public From_Main()
        {
          
            InitializeComponent();
            Add();
            MenuBar();
            MenuDrop();
            timeDate.Enabled = true;
            DropMenuHeThong.IsMainMenu = true;
            DropMenuGiaoVien.IsMainMenu = true;
            DropMenuSinhVien.IsMainMenu = true;
        }

        private void MenuDrop()

        {
            panelgiaovien.Height = panelsinhvien.Height = panelhethong.Height = 0 ;


        }

        private void From_Main_Load(object sender, EventArgs e)
        {
            Frm_Login frm_Login = new Frm_Login();
            frm_Login.ShowDialog();
        }
        private void MenuBar()
        {
            if (this.PanelMenu.Width > 200)
            {
                openMenu = false;
                MenuDrop();
                imglayout.Dock = DockStyle.Top;
               
                PanelMenu.Width = 100;
                imglayouthome.Visible = false;
                imgcode.Visible = false;
                imglayoutend.Visible = false;
                imglayoutgiaovien.Visible = false;
                imglayouthethong.Visible = false;
                imglayoutsinhvien.Visible = false;
                Menu.Dock = DockStyle.Top;
                foreach (Button MenuButon in PanelMenu.Controls.OfType<Button>())
                {
                    MenuButon.Text = "";
                    MenuButon.ImageAlign = ContentAlignment.MiddleCenter;
                    MenuButon.Padding = new System.Windows.Forms.Padding(0);
                }


                //}
                //else
                //{
                //    PanelMenu.Width = 225;
                //    imgcode.Visible = true;
                //    imglayoutgiaovien.Visible = true;
                //    imglayouthethong.Visible = true;
                //    imglayoutsinhvien.Visible = true;
                //    imglayout.Dock = DockStyle.Bottom;
                //    imglayout.Visible = true;
                //    Menu.Dock = DockStyle.None;
                //    panelhethong.Height = 158;
                //    foreach (Button MenuButon in PanelMenu.Controls.OfType<Button>())
                //    {
                //        MenuButon.Text = MenuButon.Tag.ToString();
                //        MenuButon.ImageAlign = ContentAlignment.MiddleLeft;
                //        MenuButon.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
                //    }
            }

        }

        private void TimerPanelMenu_Tick(object sender, EventArgs e)
        {

            if (openMenu == true)
            {
                MenuDrop();
                MenuHethong = true;
                PanelMenu.Width -= 7;
                if (PanelMenu.Width < 101)
                {
                   
             
                imglayout.Dock = DockStyle.Top;

                PanelMenu.Width = 100;
                    imglayouthome.Visible = false;
                imgcode.Visible = false;
                imglayoutend.Visible = false;
                imglayoutgiaovien.Visible = false;
                imglayouthethong.Visible = false;
                imglayoutsinhvien.Visible = false;
                Menu.Dock = DockStyle.Top;
                foreach (Button MenuButon in PanelMenu.Controls.OfType<Button>())
                {
                    MenuButon.Text = "";
                    MenuButon.ImageAlign = ContentAlignment.MiddleCenter;
                    MenuButon.Padding = new System.Windows.Forms.Padding(0);
                }
                TimerPanelMenu.Enabled = false;
                openMenu = false;
            }
            }
            if (openMenu == false)
            {
                MenuHethong = false;
                MenuSinhvien = true;
                Menugiaovien = true;
                PanelMenu.Width += 7;
                if (PanelMenu.Width > 224)
                {
                 
                    imgcode.Visible = true;
                    imglayouthome.Visible = true;
                    imglayoutend.Visible = true;
                    imglayoutgiaovien.Visible = true;
                    imglayouthethong.Visible = true;
                    imglayoutsinhvien.Visible = true;
                    imglayout.Dock = DockStyle.Bottom;
                    imglayout.Visible = true;
                    Menu.Dock = DockStyle.None;
                    panelhethong.Height = 158;
                    foreach (Button MenuButon in PanelMenu.Controls.OfType<Button>())
                    {
                        MenuButon.Text = MenuButon.Tag.ToString();
                        MenuButon.ImageAlign = ContentAlignment.MiddleLeft;
                        MenuButon.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
                    }
                    TimerPanelMenu.Enabled = false;
                    openMenu = true;
                }

            }

        }
        private void Menu_Click(object sender, EventArgs e)
        {
            TimerPanelMenu.Enabled = true;
        }

 

        private void btnhethong_Click_1(object sender, EventArgs e)
        {
            if(PanelMenu.Width > 224)
            {
                //if (panelhethong.Height < 1)
                //{
                //    panelhethong.Height = 158;
                //}
                //else
                //{

                //    if (panelhethong.Height > 157)
                //    {
                //        panelhethong.Height = 0;
                //    }
                //}
                TimeHeThong.Enabled = true;
                if (MenuHethong == true)
                {
                    panelgiaovien.Height = 0;
                    panelsinhvien.Height = 0;
                    MenuSinhvien = true;
                    Menugiaovien = true;
                }
               
                    
                
     
               
            
            }
            else
            {
                DropMenuHeThong.Show(btnhethong, btnhethong.Width, 0);
            }


        }

      

    

      

        private void btnThoat_MouseEnter(object sender, EventArgs e)
        {
            btnThoat.BackColor = Color.Red;
           
        }

        private void btnThoat_MouseLeave(object sender, EventArgs e)
        {
            btnThoat.BackColor = Color.Empty;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Thoát Không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.Cancel)
            {
                Frm_Login frm_Login = new Frm_Login();
                frm_Login.ShowDialog();
            }
        }

        private void btnhethong_MouseEnter(object sender, EventArgs e)
        {
            btnhethong.BackColor = Color.Orange;
        }

        private void btnhethong_MouseLeave(object sender, EventArgs e)
        {
            btnhethong.BackColor = Color.Empty;
        }

      

        private void timeDate_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lblDate.Text = String.Format("Lịch Hôm Nay Là : " + "{0:dd-MM-yyyy - hh:mm:ss tt}", dateTime);

        }

        private void btnsinhvien_Click_1(object sender, EventArgs e)
        {
          
            if (PanelMenu.Width > 224)
            {
                if(MenuSinhvien == true)
                {
                    panelhethong.Height = 0;
                    MenuHethong = true;
                    panelgiaovien.Height = 0;
                    Menugiaovien = true;
                }
                TimeSinhVien.Enabled = true;
            }
            else
            {
                DropMenuSinhVien.Show(btnhethong, btnsinhvien.Width, btnhethong.Height);
            }
        }

        private void btngiaovien_Click_1(object sender, EventArgs e)
        {
            if (PanelMenu.Width > 224)
            {
                if (Menugiaovien == true)
                {
                    panelhethong.Height = 0;
                    MenuHethong = true;
                    panelsinhvien.Height = 0;
                    MenuSinhvien = true;
                }
                TimeGiaoVien.Enabled = true;
            }
            else
            {
                DropMenuGiaoVien.Show(btnsinhvien, btngiaovien.Width, btnsinhvien.Height);
            }
        }

        private void TimeHeThong_Tick(object sender, EventArgs e)
        {
            if(MenuHethong == true)
            {
                panelhethong.Height += 7;
                if(panelhethong.Height > 157)
                {
                    TimeHeThong.Enabled = false;
                    MenuHethong = false;
                }
            }
            else
            {
               
                    panelhethong.Height -= 7;
                    if (panelhethong.Height < 1)
                    {
                        TimeHeThong.Enabled = false;
                        MenuHethong = true;
                    }
                
            }

        }

        private void TimeSinhVien_Tick(object sender, EventArgs e)
        {
      
            if (MenuSinhvien == true)
            {
                
                panelsinhvien.Height += 7;
                if (panelsinhvien.Height > 115)
                {
                    TimeSinhVien.Enabled = false;
                    MenuSinhvien = false;
                }
            }
            else
            {

                panelsinhvien.Height -= 7;
                if (panelsinhvien.Height < 1)
                {
                    TimeSinhVien.Enabled = false;
                    MenuSinhvien = true;
                }

            }
        }

        private void TimeGiaoVien_Tick(object sender, EventArgs e)
        {

            if (Menugiaovien == true)
            {
                panelgiaovien.Height += 7;
                if (panelgiaovien.Height > 115)
                {
                    TimeGiaoVien.Enabled = false;
                    Menugiaovien = false;
                }
            }
            else
            {

                panelgiaovien.Height -= 7;
                if (panelgiaovien.Height < 1)
                {
                    TimeGiaoVien.Enabled = false;
                    Menugiaovien = true;
                }

            }
        }
        /// <summary>
        /// thiet lap tab
        /// </summary>
        #region Thiet Lap Tab DoTbar2
        bool TrangThaiMo = false;
        public delegate void _dedongtab();
        
        public From_Main frm;
        string tieudeTab;
        private bool CheckOpenTab(String name)
        {
            for(int i = 0; i < tc_Main.Tabs.Count; i++)
            {
                if(tc_Main.Tabs[i].Text == name)
                {
                    tc_Main.SelectedTabIndex = i ;
                    return true;
                }

            }
            return false;
        }
     
       

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
            if (!CheckOpenTab(tieudeTab))
            {
                TabItem tab = tc_Main.CreateTab(tieudeTab);
                tab.Name = "Quản Lí Tai Khoản";
                From_quanLiTaiKhoan from_QuanLiTaiKhoan = new From_quanLiTaiKhoan()
                {

                    from_QuanLiTaiKhoan = this,
                    TopLevel = false,
                    Dock = DockStyle.Fill
                };
                tab.AttachedControl.Controls.Add(from_QuanLiTaiKhoan);
                from_QuanLiTaiKhoan.Show();
                tc_Main.SelectedTabIndex = tc_Main.Tabs.Count - 1;



            }
        }

        private void tc_Main_TabItemClose(object sender, TabStripActionEventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Thoát Trang Này Không ", "Thông Báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) != DialogResult.Cancel)
            {
                TabItem tab = tc_Main.SelectedTab;
                tc_Main.Tabs.Remove(tab);
            }
          
        }

        private void btnsinhvien_MouseEnter(object sender, EventArgs e)
        {
            btnsinhvien.BackColor = Color.Orange;
        }

        private void btnsinhvien_MouseLeave(object sender, EventArgs e)
        {
            btnsinhvien.BackColor = Color.Empty;
        }

        private void btngiaovien_MouseEnter(object sender, EventArgs e)
        {
            btngiaovien.BackColor = Color.Orange;
        }

        private void btngiaovien_MouseLeave(object sender, EventArgs e)
        {
            btngiaovien.BackColor = Color.Empty;
        }

        private void btnTrangChu_MouseEnter(object sender, EventArgs e)
        {
            btnTrangChu.BackColor = Color.Orange;
        }

        private void btnTrangChu_MouseLeave(object sender, EventArgs e)
        {
            btnTrangChu.BackColor = Color.Empty;
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            Add();



            }

        private void Add()
        {
            this.TrangThaiMo = true;
            this.tieudeTab = "Trang Chủ";
            if (!CheckOpenTab(tieudeTab))
            {
                TabItem tab = tc_Main.CreateTab(tieudeTab);
                tab.Name = "Trang Chủ";
                From_TrangChu from_TrangChu = new From_TrangChu()
                {

                    from_TrangChu = this,
                    TopLevel = false,
                    Dock = DockStyle.Fill
                };
                tab.AttachedControl.Controls.Add(from_TrangChu);
                from_TrangChu.Show();
                tc_Main.SelectedTabIndex = tc_Main.Tabs.Count - 1;
            }
    }

        private void quảnLíTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLitaikhoan();
        }
    }
}