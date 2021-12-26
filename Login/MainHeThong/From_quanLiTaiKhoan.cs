using Login.Data;
using Login.DataUser;
using Login.FromMain;
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

namespace Login.MainHeThong
{
    public partial class From_quanLiTaiKhoan : Form
    {
        static int index = -1;
        internal From_Main from_QuanLiTaiKhoan;
        ListUser listUser = new ListUser();
        public From_Main frm;
        public delegate void _dedongtab();
        public _dedongtab Dedongtab;
        public From_quanLiTaiKhoan()
        {
            InitializeComponent();
        }

        private void From_quanLiTaiKhoan_Load(object sender, EventArgs e)
        {
            loadData();

        }

        public static implicit operator From_quanLiTaiKhoan(From_Main v)
        {
            throw new NotImplementedException();
        }

        private void loadData()
        {
         
            listUser.DocFile(Const.Pathfile);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = Const.ListUser;
            dataGridView.DataSource = bindingSource;
            lblquantity.Text = "" + Const.ListUser.Count;
            dataGridView.Update();
            buttonDelete.FlatStyle = FlatStyle.Popup;
            buttonDelete.DefaultCellStyle.BackColor = Color.Red;
            buttonDelete.DefaultCellStyle.ForeColor = Color.White;
            buttonDelete.Text = "Xóa";
            buttonDelete.UseColumnTextForButtonValue = true;
          



        }
        User User = new User();
        internal From_TrangChu._MotabAdmin motabadmin;

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                index = dataGridView.CurrentRow.Index;

                if (index >= 0)
                {

                    User.MaID1 = Convert.ToInt32(dataGridView.Rows[index].Cells[1].Value.ToString());
                    User.HovaTen1 = dataGridView.Rows[index].Cells[2].Value.ToString();
                    User.GioiTinh1 = dataGridView.Rows[index].Cells[3].Value.ToString();
                    User.Ngaysinh1 = dataGridView.Rows[index].Cells[4].Value.ToString();
                    User.TenTaiKhoan1 = dataGridView.Rows[index].Cells[5].Value.ToString();
                    User.Matkhau1 = dataGridView.Rows[index].Cells[6].Value.ToString();
                    User.Email1 = dataGridView.Rows[index].Cells[7].Value.ToString();
                    User.DiaChi1 = dataGridView.Rows[index].Cells[8].Value.ToString();
                    User.Quyen1 = dataGridView.Rows[index].Cells[9].Value.ToString();

                }
                if (e.ColumnIndex == 0)
                {
                    String result = MyMessageBox.ShowBox("Bạn Có Muốn Xóa Không", "Thông Báo");
                    if (result.Equals("1"))
                    {
                        Const.ListUser.Remove(User);
                        listUser.GhiFile(Const.Pathfile);
                        loadData();
                    }
                    
                }


            }
        }

       
    }
}
