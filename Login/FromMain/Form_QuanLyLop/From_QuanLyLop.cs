using Login.Data;
using Login.DataLop;
using Login.DataSinhVien;
using Login.FromMain.Form_QuanLySinhVien;
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

namespace Login.FromMain.Form_QuanLyLop
{
    public partial class From_QuanLyLop : Form
    {
        BindingList<Lop> ListLopfillter = new BindingList<Lop>();
        Lop lop = new Lop();
        static int index = -1;
        ListLop listLop = new ListLop();
        internal From_Main from_QuanLyLop;

        public From_QuanLyLop()
        {
            InitializeComponent();
            loaddata();
            PhanQuyen(Const.UserLogin.Quyen1);
        }
        private void loaddata()
        {

            listLop.DocFile(Const.PathfileLop);
            ListLopfillter.Clear();
            for (int i = 0; i < Const.ListLop.Count; i++)
            {
                ListLopfillter.Add(Const.ListLop[i]);
            }
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = ListLopfillter;
            dataGridView.DataSource = bindingSource;
            lblquantity.Text = "" + Const.ListLop.Count;
            dataGridView.Update();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dataGridView.CurrentRow.Index;


            if (index >= 0)
            {

                lop.ID1 = Convert.ToInt32(dataGridView.Rows[index].Cells[2].Value.ToString());
                lop.Lop1 =dataGridView.Rows[index].Cells[3].Value.ToString();
                
            }
            if (e.ColumnIndex == 1)
            {
                String result = MyMessageBox.ShowBox("Bạn Có Muốn Xóa Không", "Thông Báo");
                if (result.Equals("1"))
                {
                    Const.ListLop.Remove(lop);
                    listLop.GhiFile(Const.PathfileLop);
                    loaddata();
                }

            }
            if (e.ColumnIndex == 0)
            {
                From_Addlop form_Addlop = new From_Addlop()
                {
                    LoadData = new From_Addlop._LoadData(LoadData)
                };
                form_Addlop.LoadEdit();
                form_Addlop.Open = false;
                form_Addlop.lopEdit = lop;
                form_Addlop.LoadDataLenBang();
                form_Addlop.ShowDialog();
            }
        }
        public delegate void _LoadData();
        private void LoadData()
        {
            loaddata();

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            From_Addlop form_Addlop = new From_Addlop()
            {

                LoadData = new From_Addlop._LoadData(LoadData)
            };
            if (form_Addlop.Open == true)
            {
                form_Addlop.LoadAdd();
                form_Addlop.ShowDialog();
            }
        }
        private void PhanQuyen(String quyen)
        {
            switch (quyen)
            {
                case "Admin":

                    break;
                case "Manager":

                    buttonDelete.Visible = false;
                    break;
                case "user":
                 
                    buttonDelete.Visible = false;
                    ButtonEdit.Visible = false;
                    btnThem.Enabled = false;
                   
                    break;

            }
        }
        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {

            BindingList<Lop> Fitter = new BindingList<Lop>(ListLopfillter.Where(lop => lop.Lop1.Contains(txttimkiem.Text)).ToList());
            dataGridView.DataSource = Fitter;
        }
    }
}

