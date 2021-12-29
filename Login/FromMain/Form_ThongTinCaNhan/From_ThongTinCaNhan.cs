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

namespace Login.FromMain.Form_ThongTinCaNhan
{

    
    public partial class From_ThongTinCaNhan : Form
    {
        internal From_Main thongTinCaNhan;
        private bool oppen = true;

        public From_ThongTinCaNhan()
        {
            InitializeComponent();
        }

        private void From_ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            AddThongTin();
            Hide();
        }

        private void AddThongTin()
        {
            txtHoVaten.Text = Const.UserLogin.HovaTen1;
            txtgioitinh.Text = Const.UserLogin.GioiTinh1;
            Date.Value = DateTime.Parse(Const.UserLogin.Ngaysinh1);
            txtemail.Text = Const.UserLogin.Email1;
            txtdiachi.Text = Const.UserLogin.DiaChi1;
        }
        private void AddThongTinnew()
        {
            txtHoVaten.Text = Const.UserLogin.HovaTen1;
            txtgioitinh.Text = Const.UserLogin.GioiTinh1;
            Date.Value = DateTime.Parse(Const.UserLogin.Ngaysinh1);
            txtemail.Text = Const.UserLogin.Email1;
            txtdiachi.Text = Const.UserLogin.DiaChi1;
        }
        private void Hide()
        {
         
        
                txtdiachi.Enabled = false;
                txtemail.Enabled = false;
                txtgioitinh.Enabled = false;
                txtHoVaten.Enabled = false;
                Date.Enabled = false;
      
        }
        private bool KiemTraTenEmail()
        {
            ListUser listUser = new ListUser();
            listUser.DocFile(Const.Pathfile);
            string Email = txtemail.Text;

            for (int j = 0; j < Const.ListUser.Count; j++)
            {
                if (Email.Equals(Const.ListUser[j].Email1))
                {
                    return true;
                }

            }
            return false;
        }
        private void btn_Click(object sender, EventArgs e)
        {
            if(oppen == true)
            {
                txtdiachi.Enabled = true;
                txtemail.Enabled = true;
                txtgioitinh.Enabled = true;
                txtHoVaten.Enabled = true;
                Date.Enabled = true;
                btn.Text = "Đồng ý";
                oppen = false;
            }
            else
            {
                Hide();
                ListUser listUser = new ListUser();
                listUser.DocFile(Const.Pathfile);
                String Result = MyMessageBox.ShowBox("Bạn Có Muốn Sửa Không", "Thông Báo");
                if(Result.Equals("1"))
                {
                    for (int i = 0; i < Const.ListUser.Count; i++)
                    {
                        if (Const.ListUser[i].Equals(Const.UserLogin))
                        {
                            Const.ListUser[i].HovaTen1 = txtHoVaten.Text;
                            Const.ListUser[i].GioiTinh1 = txtgioitinh.Text;
                            Const.ListUser[i].Ngaysinh1 = Date.Value.Month + "/" + Date.Value.Day + "/" + Date.Value.Year;                      
                            Const.ListUser[i].Email1 = txtemail.Text;
                            Const.ListUser[i].DiaChi1 = txtdiachi.Text;
                            // add new moi
                            Const.UserLogin.HovaTen1 = txtHoVaten.Text;
                            Const.UserLogin.GioiTinh1 = txtgioitinh.Text;
                            Const.UserLogin.Ngaysinh1 = Date.Value.Month + "/" + Date.Value.Day + "/" + Date.Value.Year;
                            Const.UserLogin.Email1 = txtemail.Text;
                            Const.UserLogin.DiaChi1 = txtdiachi.Text;
                            listUser.GhiFile(Const.Pathfile);
                        }
                    }
                }
                else
                {
                    AddThongTinnew();
                }




                btn.Text = "Chỉnh Sửa";
                oppen = true;
            }
        }

       
    }
}
