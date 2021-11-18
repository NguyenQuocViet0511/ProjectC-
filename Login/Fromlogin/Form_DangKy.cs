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
    public partial class Form_DangKy : Form
    {
        public Form_DangKy()
        {
            InitializeComponent();
        }

        private void lblQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblQuayLai_MouseHover(object sender, EventArgs e)
        {
            lblQuayLai.ForeColor = Color.Red;
        }

        private void BtnDangKy_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtHoVaTen.Text))
            {
                lblThongBaoHoVaTen.Text = "Vui Lòng Không được để trống ";
            }
            else
            {
                lblThongBaoHoVaTen.Text = "";
            }
}
}
}
