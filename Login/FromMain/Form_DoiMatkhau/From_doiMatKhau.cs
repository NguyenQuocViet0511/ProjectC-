using Login.Data;
using Login.DataUser;
using Login.MyCustome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.FromMain.Form_DoiMatkhau
{
    public partial class From_doiMatKhau : Form
    {
        internal From_Main from_DoiMatKhau;
        private bool Hide = true;
        private bool Hide1 = true;
        public From_doiMatKhau()
        {
            InitializeComponent();
        }

        public static implicit operator From_doiMatKhau(From_Main v)
        {
            throw new NotImplementedException();
        }

        private void btndoimatkhau_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmatkhaucu.Text))
            {
                lblmatkhaucu.Text = "Vui Lòng Không được Để Trống";

            }
            else
            {
                lblmatkhaucu.Text = "";
            }
            if (string.IsNullOrEmpty(txtmatkhaumoi.Text))
            {
                lblmatkhaumoi.Text = "Vui Lòng Không được Để Trống";

            }
            else
            {
                lblmatkhaumoi.Text = "";
            }
            if (string.IsNullOrEmpty(txtnhaplaimatkhau.Text))
            {
                lblnhaplaimatkhau.Text = "Vui Lòng Không được Để Trống";

            }
            else
            {
                lblnhaplaimatkhau.Text = "";
            }
            if (!String.IsNullOrEmpty(txtmatkhaucu.Text) && !String.IsNullOrEmpty(txtmatkhaumoi.Text) && !String.IsNullOrEmpty(txtnhaplaimatkhau.Text))
            {
                String Result = MyMessageBox.ShowBox("Bạn Muốn Đổi Không", "Thông Báo");
                if (Result.Equals("1"))
                {
                    ListUser listUser = new ListUser();
                    listUser.DocFile(Const.Pathfile);

                    for (int i = 0; i < Const.ListUser.Count; i++)
                    {
                        if (Const.ListUser[i].Equals(Const.UserLogin))
                        {
                            if (Const.ListUser[i].Matkhau1.Equals(txtmatkhaucu.Text))
                            {
                                if (txtmatkhaumoi.Text.Equals(txtnhaplaimatkhau.Text))
                                {
                                    Const.ListUser[i].Matkhau1 = txtmatkhaumoi.Text;
                                    listUser.GhiFile(Const.Pathfile);
                                    txtmatkhaucu.Text = "";
                                    txtmatkhaumoi.Text = "";
                                    txtnhaplaimatkhau.Text = "";
                                    MyMessageBox_1.ShowBox("Đổi Mật Khẩu Thành Công", "Thông Báo");

                                }
                                else
                                {
                                    MyMessageBox_1.ShowBox("Mật Khẩu Không Giống nhau", "Thông Báo");
                                }
                            }
                            else
                            {
                                MyMessageBox_1.ShowBox("Mật Khẩu Cũ Sai", "Thông Báo");
                            }
                        }
                    }
                }
                else
                {
                    txtmatkhaucu.Text = "";
                    txtmatkhaumoi.Text = "";
                    txtnhaplaimatkhau.Text = "";
                }
            }
            


        }

        private void lblhide_Click(object sender, EventArgs e)
        {
            if (Hide == true)
            {
                txtmatkhaumoi.UseSystemPasswordChar = false;
                lblhide.Image = global::Login.Properties.Resources.eye_26px;
                Hide = false;
            }
            else
            {
                txtmatkhaumoi.UseSystemPasswordChar = true;
                lblhide.Image = global::Login.Properties.Resources.invisible_26px;
                Hide = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (Hide1 == true)
            {
                txtnhaplaimatkhau.UseSystemPasswordChar = false;
                label1.Image = global::Login.Properties.Resources.eye_26px;
                Hide1 = false;
            }
            else
            {
                txtnhaplaimatkhau.UseSystemPasswordChar = true;
                label1.Image = global::Login.Properties.Resources.invisible_26px;
                Hide1 = true;
            }
        }
    }
}
