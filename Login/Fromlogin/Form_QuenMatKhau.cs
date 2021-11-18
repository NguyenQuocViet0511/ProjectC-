using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Fromlogin
{
    public partial class Form_QuenMatKhau : Form
    {
        public Form_QuenMatKhau()
        {
            InitializeComponent();
        }

        private void lblQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuiEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblQuayLai_MouseHover(object sender, EventArgs e)
        {
            lblQuayLai.ForeColor = Color.Red;
        }

        //private Boolean CheckEmail()
        //{
        //    for()

        //    return false;
        //}
    }
}
