using Login.Data;
using Login.DataUser;
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
    public partial class Form_Checkcode : Form
    {
        public String CheckCode;
        public User UserDangKy = new User();
        public Form_Checkcode()
        {
            InitializeComponent();
        }

        private void Form_Checkcode_Load(object sender, EventArgs e)
        {

        }

        private void BtnXacMinhCode_Click(object sender, EventArgs e)
        {
            if(txtCode.Text.Equals(CheckCode))
                {
                Const.ListUser.Add(UserDangKy);
                
                ListUser listUser = new ListUser();
                listUser.GhiFile(Const.Pathfile);
                MessageBox.Show("Đăng Ký Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Mã Code Sai", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblQuayLai_Click(object sender, EventArgs e)
        {
      
            Frm_Login frm_Login = new Frm_Login();
            this.Dispose();
            frm_Login.ShowDialog();
     
        }

        private void lblQuayLai_MouseHover(object sender, EventArgs e)
        {
            lblQuayLai.ForeColor = Color.Red;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
