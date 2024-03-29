﻿using Login.Data;
using Login.DataQuyen;
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
        BindingList<User> ListUserfillter = new BindingList<User>();
        static int index = -1;
        internal From_Main from_QuanLiTaiKhoan;
        ListUser listUser = new ListUser();
        //public From_Main frm;
        //public delegate void _dedongtab();
        //public _dedongtab Dedongtab;
        public From_quanLiTaiKhoan()
        {
            InitializeComponent();
        }

        private void From_quanLiTaiKhoan_Load(object sender, EventArgs e)
        {
            loadData();
            PhanQuyen(Const.UserLogin.Quyen1);

        }

        public static implicit operator From_quanLiTaiKhoan(From_Main v)
        {
            throw new NotImplementedException();
        }

        private void loadData()
        {
            
            listUser.DocFile(Const.Pathfile);
            ListUserfillter.Clear();
            for (int i = 0; i< Const.ListUser.Count;i++)
            {
                ListUserfillter.Add(Const.ListUser[i]);
            }
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = ListUserfillter;
            dataGridView.DataSource = bindingSource;
            lblquantity.Text = "" + Const.ListUser.Count;
            dataGridView.Update();
        }
        User User = new User();
        internal From_TrangChu._MotabAdmin motabadmin;

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                index = dataGridView.CurrentRow.Index;

                if (index >= 0)
                {

                    User.MaID1 = Convert.ToInt32(dataGridView.Rows[index].Cells[2].Value.ToString());
                    User.HovaTen1 = dataGridView.Rows[index].Cells[3].Value.ToString();
                    User.GioiTinh1 = dataGridView.Rows[index].Cells[4].Value.ToString();
                    User.Ngaysinh1 = dataGridView.Rows[index].Cells[5].Value.ToString();
                    User.TenTaiKhoan1 = dataGridView.Rows[index].Cells[6].Value.ToString();
                    User.Matkhau1 = dataGridView.Rows[index].Cells[7].Value.ToString();
                    User.Email1 = dataGridView.Rows[index].Cells[8].Value.ToString();
                    User.DiaChi1 = dataGridView.Rows[index].Cells[9].Value.ToString();
                    User.Quyen1 = dataGridView.Rows[index].Cells[10].Value.ToString();

                }
                if (e.ColumnIndex == 1)
                {
                    String result = MyMessageBox.ShowBox("Bạn Có Muốn Xóa Không", "Thông Báo");
                    if (result.Equals("1"))
                    {
                        Const.ListUser.Remove(User);
                        listUser.GhiFile(Const.Pathfile);
                        loadData();
                    }

                }
                if (e.ColumnIndex == 0)
                {

                    From_ThemAndSua from_ThemAndSua = new From_ThemAndSua()
                    {

                        LoadData = new From_ThemAndSua._LoadData(LoadData)
                    };
                    from_ThemAndSua.LoadEdit();
                    from_ThemAndSua.Open = false;
                    from_ThemAndSua.UserEdit = User;
                    from_ThemAndSua.LoadDataLenBang();
                    from_ThemAndSua.ShowDialog();
                }
            }
        }
        
        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {


            BindingList<User> filtered = new BindingList<User>(ListUserfillter.Where(user => user.TenTaiKhoan1.Contains(txttimkiem.Text)).ToList());
            dataGridView.DataSource = filtered;
        }
        //
        public delegate void _LoadData();    
        private void LoadData()
        {
            loadData();
        }
        //
        private void btnThem_Click(object sender, EventArgs e)
        {
            From_ThemAndSua from_ThemAndSua = new From_ThemAndSua()
            {

                LoadData = new From_ThemAndSua._LoadData(LoadData)
            };
            if(from_ThemAndSua.Open == true)
            {
                from_ThemAndSua.LoadAdd();
                from_ThemAndSua.ShowDialog();
            }
            
        }
        private void PhanQuyen(String quyen)
        {
            switch(quyen)
            {
                case "Admin":

                    break;
                case "Manager":
                    PanelPhanQuyen.Enabled = false;
                    buttonDelete.Visible = false;
                    break;
                case "user":
                    PanelPhanQuyen.Enabled = false;
                    buttonDelete.Visible = false;
                    ButtonEdit.Visible = false;
                    btnThem.Enabled = false;
                    
                    break;

            }
        }
        private void btnrefresh_Click(object sender, EventArgs e)
        {
            loadData();
        }
        ListQuyen listQuyen = new ListQuyen();
       
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

          
            if (checkBox1.Checked == true)
            {
                listQuyen.DocFile(Const.PathfileQuyen);
                List<String> Quyen = new List<string>();
                for (int i = 0; i < Const.ListQuyen.Count; i++)
                {
                    Quyen.Add(Const.ListQuyen[i].Quyen1);
                }
                comboBox1.DataSource = Quyen;
            }
            else
            {
                comboBox1.SelectedIndex = -1;
                comboBox1.DataSource = null;
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                if(index >= 0)
                {
                    if (comboBox1.SelectedIndex == -1)
                    {
                        MessageBox.Show("Bạn Chưa Chọn Quyền", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        for (int i = 0; i < Const.ListUser.Count; i++)
                        {
                            if (Const.ListUser[i].Equals(User))
                            {
                              
                                
                                    Const.ListUser[i].Quyen1 = comboBox1.SelectedItem.ToString();
                                    listUser.GhiFile(Const.Pathfile);
                                    loadData();
                                    MessageBox.Show("Phân Quyền Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                               


                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Bạn Chưa Chọn User Nào ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }
    }
}
