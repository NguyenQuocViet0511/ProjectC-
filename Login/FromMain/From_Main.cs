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

namespace Login.FromMain
{
    public partial class From_Main : Form
    {
        private bool openMenu = true;

        public bool OpenMenu { get => openMenu; set => openMenu = value; }

        public From_Main()
        {
          
            InitializeComponent();
            MenuBar();
            MenuDrop();
            DropMenuHethong.IsMainMenu = true;
            DropMeniGiaoVien.IsMainMenu = true;
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
                MenuDrop();
                imglayout.Visible = false;
                PanelMenu.Width = 100;
                imgcode.Visible = false;
                Menu.Dock = DockStyle.Top;
                foreach (Button MenuButon in PanelMenu.Controls.OfType<Button>())
                {
                    MenuButon.Text = "";
                    MenuButon.ImageAlign = ContentAlignment.MiddleCenter;
                    MenuButon.Padding = new Padding(0);
                }


            }
            else
            {
                PanelMenu.Width = 225;
                imgcode.Visible = true;
                imglayout.Visible = true;
                Menu.Dock = DockStyle.None;
                foreach (Button MenuButon in PanelMenu.Controls.OfType<Button>())
                {
                    MenuButon.Text = MenuButon.Tag.ToString();
                    MenuButon.ImageAlign = ContentAlignment.MiddleLeft;
                    MenuButon.Padding = new Padding(10, 0, 0, 0);
                }
            }

        }

        private void TimerPanelMenu_Tick(object sender, EventArgs e)
        {

            //if (openMenu == true)
            //{
            //    PanelMenu.Width -= 2;
            //    if (PanelMenu.Width == 50)
            //    {
            //        TimerPanelMenu.Enabled = false;
            //        openMenu = false;
            //    }
            //}
            //if (openMenu == false)
            //{
            //    PanelMenu.Width += 2;
            //    if (PanelMenu.Width == 200)
            //    {
            //        TimerPanelMenu.Enabled = false;
            //        openMenu = true;
            //    }

            //}
         
        }

     

        private void Menu_Click(object sender, EventArgs e)
        {
            MenuBar();
        }

 

        private void btnhethong_Click_1(object sender, EventArgs e)
        {
            if(PanelMenu.Width > 224)
            {
                if (panelhethong.Height < 1)
                {
                    panelhethong.Height = 117;
                }
                else
                {

                    if (panelhethong.Height > 115)
                    {
                        panelhethong.Height = 0;
                    }
                }
            }
            else
            {
                DropMenuHethong.Show(btnhethong, btnhethong.Width, 0);
            }


        }

        private void btnsinhvien_Click(object sender, EventArgs e)
        {
            if (PanelMenu.Width > 224)
            {
                if (panelsinhvien.Height < 1)
                {
                    panelsinhvien.Height = 117;
                }
                else
                {

                    if (panelsinhvien.Height > 115)
                    {
                        panelsinhvien.Height = 0;
                    }
                }
            }
            else
            {
                DropMenuSinhVien.Show(btnhethong, btnsinhvien.Width, btnhethong.Height);
            }
        }

        private void btngiaovien_Click(object sender, EventArgs e)
        {

            if (PanelMenu.Width > 224)
            {
                if (panelgiaovien.Height < 1)
                {
                    panelgiaovien.Height = 117;
                }
                else
                {

                    if (panelgiaovien.Height > 115)
                    {
                        panelgiaovien.Height = 0;
                    }
                }
            }
            else
            {
                DropMeniGiaoVien.Show(btnsinhvien, btngiaovien.Width , btnsinhvien.Height);
            }
        }
    }
}
