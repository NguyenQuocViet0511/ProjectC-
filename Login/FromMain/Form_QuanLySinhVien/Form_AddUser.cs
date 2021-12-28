using Login.Data;
using Login.DataSinhVien;
using Login.DataUser;
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

namespace Login.FromMain.Form_QuanLySinhVien
{
    public partial class Form_AddUser : Form
    {
        public SinhVien SinhvienEdit = new SinhVien();
        ListSinhVien ListSinhVien = new ListSinhVien();
        int id;
        public bool Open = true;
        public Form_AddUser()
        {
            InitializeComponent();
        }

        private void Form_AddUser_Load(object sender, EventArgs e)
        {

        }
        public void LoadAdd()
        {
            lbltieude.Text = "Thêm Sinh Viên";
            btn_Them.Text = "Thêm";
            txt_MaSV.Enabled = true;


        }
        public void LoadEdit()
        {
            lbltieude.Text = "Chỉnh Sửa Sinh Viên";
            btn_Them.Text = "Sửa";
            txt_MaSV.Enabled = false;

        }
        //
        public delegate void _LoadData();
        public _LoadData LoadData;
        //
        public void LoadDataLenBang()
        {

            txt_MaSV.Text = SinhvienEdit.MaSV1.ToString();
            txt_Name.Text = SinhvienEdit.HovaTen1.ToString();
            if(SinhvienEdit.GioiTinh1.Equals("Nam"))
            {
                rdo_Nam.Checked = true;
            }
            else
            {
                rdo_Nu.Checked = true;
            }
            txt_NgaySinh.Text = SinhvienEdit.NgaySinh1.ToString();
            txt_DiaChi.Text = SinhvienEdit.DiaChi1.ToString();
           

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void btn_Huy_Click(object sender, EventArgs e)
        {
            Open = true;
            this.Close();
        }

        private void lbltieude_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //load
        private void LoadId()
        {
            ListSinhVien.DocFile(Const.PathfileSV);
            List<int> rdid = new List<int>();
            int number = 1;

            for (int i = 0; i < Const.ListSinhVien.Count; i++)
            {
                rdid.Add(Const.ListSinhVien[i].STT1);

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
        private bool KiemTraMaSV()
        {
            string Masv = txt_MaSV.Text;

            for (int j = 0; j < Const.ListSinhVien.Count; j++)
            {
                if (Masv.Equals(Const.ListSinhVien[j].MaSV1.ToString()))
                {
                    return true;
                }

            }
            return false;
        }

        //
        private void btn_Them_Click(object sender, EventArgs e)
        {

            if (Open == true)
            {
                if (!String.IsNullOrEmpty(txt_MaSV.Text) && !String.IsNullOrEmpty(txt_DiaChi.Text) && !String.IsNullOrEmpty(txt_Name.Text) && !String.IsNullOrEmpty(txt_NgaySinh.Text) && rdo_Nu.Checked == true || rdo_Nam.Checked == true)
                {
                    LoadId();
                    SinhVien sinhVien;
                    if (KiemTraMaSV())
                    {
                        MessageBox.Show("Mã Sinh Viên Này Đã Có Vui Lòng Thử Mã Khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        sinhVien = new SinhVien();
                        sinhVien.STT1 = id;
                        sinhVien.MaSV1 = Convert.ToInt32(txt_MaSV.Text);
                        sinhVien.HovaTen1 = txt_Name.Text;
                        if (rdo_Nam.Checked == true)
                        {
                            sinhVien.GioiTinh1 = "Nam";
                        }
                        else
                        {
                            sinhVien.GioiTinh1 = "Nữ";
                        }
                        sinhVien.NgaySinh1 = txt_NgaySinh.Text;
                        sinhVien.DiaChi1 = txt_DiaChi.Text;
                        Const.ListSinhVien.Add(sinhVien);
                        ListSinhVien.GhiFile(Const.PathfileSV);
                        MyMessageBox_1.ShowBox("Bạn Thêm Thành Công ", "Thông Báo");
                        LoadData();
                        this.Close();
                    }
                }
            }
            else
            {

                ListSinhVien.DocFile(Const.PathfileSV);
                for (int i = 0; i < Const.ListSinhVien.Count; i++)
                {
                    if (Const.ListSinhVien[i].Equals(SinhvienEdit))
                    {
                        Const.ListSinhVien[i].HovaTen1 = txt_Name.Text;
                        if (rdo_Nam.Checked == true)
                        {
                            Const.ListSinhVien[i].GioiTinh1 = "Nam";
                        }
                        else
                        {
                            Const.ListSinhVien[i].GioiTinh1 = "Nữ";
                        }
                        Const.ListSinhVien[i].NgaySinh1 = txt_NgaySinh.Text;
                        Const.ListSinhVien[i].DiaChi1 = txt_DiaChi.Text;
                        MessageBox.Show("Sửa Thông Tin Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        ListSinhVien.GhiFile(Const.PathfileSV);
                        LoadData();
                        Open = true;
                    }


                }
            }
        }
    }
}
