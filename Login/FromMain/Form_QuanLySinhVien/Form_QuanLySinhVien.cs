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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.FromMain.Form_QuanLySinhVien
{
    public partial class Form_QuanLySinhVien : Form
    {
        BindingList<SinhVien> ListSinhVienfillter = new BindingList<SinhVien>();
        SinhVien SinhVien = new SinhVien();
        static int index = -1;
        ListSinhVien ListSinhVien = new ListSinhVien();
        internal From_Main form_QuanLySinhVien;

        public Form_QuanLySinhVien()
        {
            InitializeComponent();
            loadData();
        }
        private void loadData()
        {

            ListSinhVien.DocFile(Const.PathfileSV);
            ListSinhVienfillter.Clear();
            for (int i = 0; i < Const.ListSinhVien.Count; i++)
            {
                ListSinhVienfillter.Add(Const.ListSinhVien[i]);
            }
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = ListSinhVienfillter;
            dataGridView.DataSource = bindingSource;
            lblquantity.Text = "" + Const.ListSinhVien.Count;
            dataGridView.Update();
        }
        
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                index = dataGridView.CurrentRow.Index;

                if (index >= 0)
                {

                    SinhVien.STT1 = Convert.ToInt32(dataGridView.Rows[index].Cells[2].Value.ToString());
                    SinhVien.MaSV1 = Convert.ToInt32(dataGridView.Rows[index].Cells[3].Value.ToString());
                    SinhVien.HovaTen1 = dataGridView.Rows[index].Cells[4].Value.ToString();
                    SinhVien.GioiTinh1 = dataGridView.Rows[index].Cells[5].Value.ToString();
                    SinhVien.NgaySinh1 = dataGridView.Rows[index].Cells[6].Value.ToString();
                    SinhVien.DiaChi1 = dataGridView.Rows[index].Cells[7].Value.ToString();
                    SinhVien.Lop1 = dataGridView.Rows[index].Cells[8].Value.ToString();                   
                }
                if (e.ColumnIndex == 1)
                {
                    String result = MyMessageBox.ShowBox("Bạn Có Muốn Xóa Không", "Thông Báo");
                    if (result.Equals("1"))
                    {
                        Const.ListSinhVien.Remove(SinhVien);
                        ListSinhVien.GhiFile(Const.PathfileSV);
                        loadData();
                    }

                }
                if (e.ColumnIndex == 0)
                {

                    Form_AddUser form_AddUser = new Form_AddUser()
                    {

                        LoadData = new Form_AddUser._LoadData(LoadData)
                    };
                    form_AddUser.LoadEdit();
                    form_AddUser.Open = false;
                    form_AddUser.SinhvienEdit = SinhVien;
                    form_AddUser.LoadDataLenBang();
                    form_AddUser.ShowDialog();
                }
            }
        }
        //
        public delegate void _LoadData();
        private void LoadData()
        {
            loadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form_AddUser form_AddUser = new Form_AddUser()
            {

                LoadData = new Form_AddUser._LoadData(LoadData)
            };
            if (form_AddUser.Open == true)
            {
                form_AddUser.LoadAdd();
                form_AddUser.ShowDialog();
            }
        }
        private void loadDataText()
        {
            ListSinhVien.DocFile(Const.PathfileSV);
        }
        private void txttimkiemtheoten_TextChanged(object sender, EventArgs e)
        {
            BindingList<SinhVien> Fitter = new BindingList<SinhVien>(ListSinhVienfillter.Where(SinhVien => SinhVien.HovaTen1.Contains(txttimkiemtheoten.Text)).ToList());
            dataGridView.DataSource = Fitter;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
                BindingList<SinhVien> Fitter = new BindingList<SinhVien>(ListSinhVienfillter.Where(SinhVien => Convert.ToString(SinhVien.MaSV1).Contains(txttimkiemtheoma.Text)).ToList());
                dataGridView.DataSource = Fitter;
            
           
        }

        private void btnphanlop_Click(object sender, EventArgs e)
        {
            if(cknphanlop.Checked == true)
            {
                loadDataText();
                for (int i = 0; i < Const.ListSinhVien.Count; i++)
                {
                    if(Const.ListSinhVien[i].Equals(SinhVien))
                    {
                        if(String.IsNullOrEmpty(Const.ListSinhVien[i].Lop1))
                        {
                            Const.ListSinhVien[i].Lop1 = cbnPhanLop.SelectedItem.ToString();
                            ListSinhVien.GhiFile(Const.PathfileSV);
                            loadData();
                            MessageBox.Show("Phân Lớp Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Sinh Viên Này Đã Có Lớp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                    }
                }

            }
        }

        private void btnchuyenlop_Click(object sender, EventArgs e)
        {
            if (cknchuyenlop.Checked == true)
            {
                loadDataText();
                for (int i = 0; i < Const.ListSinhVien.Count; i++)
                {                   
                    if (Const.ListSinhVien[i].Equals(SinhVien))
                    {
                        if(!String.IsNullOrEmpty(Const.ListSinhVien[i].Lop1))
                        {
                            Const.ListSinhVien[i].Lop1 = cbnChuyenLop.SelectedItem.ToString();
                            ListSinhVien.GhiFile(Const.PathfileSV);
                            loadData();
                            MessageBox.Show("Chuyển Lớp Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Sinh Viên Này Chưa Có Lớp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }



                    }
                }

            }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ckntimkiemtheolop.Checked == true)
            {
                cbnTimKiemLop.Visible = true;
                BindingList<SinhVien> Fitter = new BindingList<SinhVien>(ListSinhVienfillter.Where(SinhVien => SinhVien.Lop1.Contains(cbnTimKiemLop.SelectedItem.ToString())).ToList());
                dataGridView.DataSource = Fitter;
            }
     
            
          
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ckntimkiemtheolop_CheckedChanged(object sender, EventArgs e)
        {
            if(ckntimkiemtheolop.Checked == true)
            {
                
            }
            else
            {
                LoadData();
            }
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            // saveFileDialog.InitialDirectory = @"d:\";//Hien thi thu muc khoi tao
            saveFileDialog.RestoreDirectory = true;

            saveFileDialog.Filter = "Text files (*.xls)|*.xls|All files (*.*)|*.*";//Lọc loại file
            saveFileDialog.DefaultExt = "xls";//Phần mở rộng mặc định
            saveFileDialog.AddExtension = true;

            saveFileDialog.Title = "Lưu file Excel";//Tiêu đề của hộp thoại
            saveFileDialog.FileName = string.Format("DanhSachSinhVien_{0}{1:00}{2:00}{3:00}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Minute);//trungthuong2021101801
            if (saveFileDialog.ShowDialog() == DialogResult.OK)//kiểm tra nếu nhấn vào button save trên hộp thoại
            {
                //nhanVienNhanGiaiDao.XuatExcel(saveFileDialog.FileName);
                MessageBox.Show("Xuất file thành công");
            }
        }
    }
}

