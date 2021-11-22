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
    public partial class Form_MatKhauMoi : Form
    {
        ListUser ListUser;
        public Form_MatKhauMoi()
        {
            InitializeComponent();
        }

        private void BtnXacMinhCode_Click(object sender, EventArgs e)
        {
            ListUser = new ListUser();
            ListUser.DocFile(Const.Pathfile);
            for(int i = 0; i< Const.ListUser.Count;i++)
            {
                if(Const.ListUser[i].Equals(Const.User))
                {
                    if(txtMatkhauMoi.Text.Equals(TxtNhapLaiMatKhau.Text))
                    {
                        Const.ListUser[i].Matkhau1 = txtMatkhauMoi.Text;
                        MessageBox.Show("Mật Khẩu Mới Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListUser.GhiFile(Const.Pathfile);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Mật Khẩu Không Giống Nhau", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }



                }
            }

        }
    }
}
