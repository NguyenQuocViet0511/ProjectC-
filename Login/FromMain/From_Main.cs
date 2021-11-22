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
    }
}
