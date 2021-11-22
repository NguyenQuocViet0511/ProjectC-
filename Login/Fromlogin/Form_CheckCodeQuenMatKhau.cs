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
   
    public partial class Form_CheckCodeQuenMatKhau : Form
    {
        public String checkCode;
        public Form_CheckCodeQuenMatKhau()
        {
            InitializeComponent();
        }

        private void BtnXacMinhCode_Click(object sender, EventArgs e)
        {
            if(txtCode.Text.Equals(checkCode))
            {
                Form_MatKhauMoi form_MatKhauMoi = new Form_MatKhauMoi();
                this.Hide();
                form_MatKhauMoi.ShowDialog();

            }
            else
            {
                MessageBox.Show("Mã Code Sai" , "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
}
}
