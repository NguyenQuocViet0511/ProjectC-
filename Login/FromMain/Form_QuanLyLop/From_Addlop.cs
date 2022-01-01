using Login.Data;
using Login.DataLop;
using Login.MyCustome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.FromMain.Form_QuanLyLop
{
    public partial class From_Addlop : Form
    {
        int id;
        public bool Open = true;
        ListLop listLop = new ListLop();
         public Lop lopEdit = new Lop();
        public From_Addlop()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void LoadId()
        {
            listLop.DocFile(Const.PathfileLop);
            List<int> rdid = new List<int>();
            int number = 1;

            for (int i = 0; i < Const.ListLop.Count; i++)
            {
                rdid.Add(Const.ListLop[i].ID1);

            }
            for (int j = 0; j < rdid.Count; j++)
            {

                int a = rdid[j];
                if (a > number)
                {
                    number = a;

                }
            }
            number += 1;
            id = number;
        }
        //
        public void LoadAdd()
        {
            lbltieude.Text = "Thêm Lớp";
            btn_Them.Text = "Thêm";
          


        }
        public void LoadEdit()
        {
            lbltieude.Text = "Chỉnh Sửa Lớp";
            btn_Them.Text = "Sửa";
           

        }
        //
        private bool KiemTraLop()
        {
            string lop = txtLop.Text;

            for (int j = 0; j < Const.ListLop.Count; j++)
            {
                if (lop.Equals(Const.ListLop[j].Lop1.ToString()))
                {
                    return true;
                }

            }
            return false;
        }
        //
        public void LoadDataLenBang()
        {

            txtLop.Text = lopEdit.Lop1;

        }
        //
        public delegate void _LoadData();
        public _LoadData LoadData;
        private void btn_Them_Click(object sender, EventArgs e)
        {

            if (Open == true)
            {
                if (!String.IsNullOrEmpty(txtLop.Text))
                {
                    LoadId();
                    Lop lop;
                    if (KiemTraLop())
                    {
                        MessageBox.Show("Lớp Này Đã Có Vui Lòng Thử Lớp Khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        lop = new Lop();
                        lop.ID1 = id;
                        lop.Lop1 = txtLop.Text;                     
                        Const.ListLop.Add(lop);
                        listLop.GhiFile(Const.PathfileLop);
                        MyMessageBox_1.ShowBox("Bạn Thêm Thành Công ", "Thông Báo");
                        LoadData();
                        this.Close();
                    }
                }
            }
            else
            {

                listLop.DocFile(Const.PathfileLop);
                for (int i = 0; i < Const.ListLop.Count; i++)
                {
                    if (Const.ListLop[i].Equals(lopEdit))
                    {
                        Const.ListLop[i].Lop1 = txtLop.Text;
       
                        MessageBox.Show("Sửa Thông Tin Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        listLop.GhiFile(Const.PathfileLop);
                        LoadData();
                        Open = true;
                    }


                }
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbltieude_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
