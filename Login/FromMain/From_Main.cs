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
        }

        private void From_Main_Load(object sender, EventArgs e)
        {
            Frm_Login frm_Login = new Frm_Login();
            frm_Login.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Menu_Click(object sender, EventArgs e)
        {

            TimerPanelMenu.Enabled = true;
           

        }



        

private void TimerPanelMenu_Tick(object sender, EventArgs e)
        {

            if (openMenu == true)
            {
                PanelMenu.Width -= 2;
                if (PanelMenu.Width == 50)
                {
                    TimerPanelMenu.Enabled = false;
                    openMenu = false;
                }
            }
            if (openMenu == false)
            {
                PanelMenu.Width += 2;
                if (PanelMenu.Width == 200)
                {
                    TimerPanelMenu.Enabled = false;
                    openMenu = true;
                }

            }
         
        }
}
}
