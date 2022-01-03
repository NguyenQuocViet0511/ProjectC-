using Login.Data;
using Login.DataLop;
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
        List<String> vs = new List<string>();
        SinhVien SinhVien = new SinhVien();
        private bool mo = true;
        static int index = -1;
        ListSinhVien ListSinhVien = new ListSinhVien();
        internal From_Main form_QuanLySinhVien;

        public Form_QuanLySinhVien()
        {
            InitializeComponent();
            loadData();
            PhanQuyen(Const.UserLogin.Quyen1);
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
                if(index >= 0)
                {
                    if (cbnPhanLop.SelectedIndex == -1)
                    {
                        MessageBox.Show("Bạn Chưa Chọn Lớp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        loadDataText();
                        for (int i = 0; i < Const.ListSinhVien.Count; i++)
                        {
                            if (Const.ListSinhVien[i].Equals(SinhVien))
                            {
                                if (String.IsNullOrEmpty(Const.ListSinhVien[i].Lop1))
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
                }else

                {
                    MessageBox.Show("Bạn Chưa Chọn Sinh Viên Nào", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



        }
        }

        private void btnchuyenlop_Click(object sender, EventArgs e)
        {
            if (cknchuyenlop.Checked == true)
            {

                if (index >= 0)
                {
                    if (cbnChuyenLop.SelectedIndex == -1)
                    {
                        MessageBox.Show("Bạn Chưa Chọn Lớp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        loadDataText();
                        for (int i = 0; i < Const.ListSinhVien.Count; i++)
                        {
                            if (Const.ListSinhVien[i].Equals(SinhVien))
                            {
                                if (!String.IsNullOrEmpty(Const.ListSinhVien[i].Lop1))
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
                else

                {
                    MessageBox.Show("Bạn Chưa Chọn Sinh Viên Nào", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
                   

            }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ckntimkiemtheolop.Checked == true)
            {
               

                if (mo == false)
                {
                    BindingList<SinhVien> Fitter = new BindingList<SinhVien>(ListSinhVienfillter.Where(SinhVien => SinhVien.Lop1.Contains(cbnTimKiemLop.SelectedItem.ToString())).ToList());
                    dataGridView.DataSource = Fitter;
                }


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
                
                loadLop();              
                cbnTimKiemLop.DataSource = vs;
                cbnTimKiemLop.SelectedIndex = -1;

            }
            else
            {
                mo = true;
                cbnTimKiemLop.DataSource = null;
                LoadData();
            }
        }

       
        private void btnin_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            //code Xuất Excel 
            //foreach (SinhVien item in Const.ListSinhVien)
            //{
            //    string line = string.Format("{0},{1},{2},{3},{4},{5},{6}", item.STT1, item.MaSV1, item.HovaTen1, item.GioiTinh1, item.NgaySinh1, item.DiaChi1, item.Lop1);
            //    list.Add(line);
            //}
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
                //XuatFileExcel.XuatExcel(saveFileDialog.FileName, list, "Danh Sách Sinh Viên","","STT", "Mã Sinh Viên", "Họ Và Tên", "Giới Tính" , "Ngày Sinh", "Địa Chỉ", "Lớp");
                XuatFileExcel.XuatExcel(saveFileDialog.FileName,dataGridView, "Danh Sách Sinh Viên");
                MessageBox.Show("Xuất file thành công", "Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        //
        private void loadLop()
        {
           
            vs.Clear();
            ListLop listLop = new ListLop();
            listLop.DocFile(Const.PathfileLop);
            for(int i = 0; i < Const.ListLop.Count;i++)
            {
                vs.Add(Const.ListLop[i].Lop1);
            }
          
            
        }
        //
        private void cknphanlop_CheckedChanged(object sender, EventArgs e)
        {
            if(cknphanlop.Checked == true)
            {
                loadLop();
                cbnPhanLop.DataSource = vs;
            }
            else
            {
    
                cbnPhanLop.DataSource = null;
            }
        }

        private void cknchuyenlop_CheckedChanged(object sender, EventArgs e)
        {
            if (cknchuyenlop.Checked == true)
            {
                loadLop();
                cbnChuyenLop.DataSource = vs;
            }
            else
            {
                cbnChuyenLop.DataSource = null;
            }
        }
        private void PhanQuyen(String quyen)
        {
            switch (quyen)
            {
                case "Admin":

                    break;
                case "Manager":
                    
                    ButtonDelete.Visible = false;
                    break;
                case "user":
                    panellop.Enabled = false;
                    ButtonDelete.Visible = false;
                    buttonEdit.Visible = false;
                    btnThem.Enabled = false;
                    paneltimkiem.Enabled = false;
                    break;

            }
        }
        private void cbnTimKiemLop_MouseClick(object sender, MouseEventArgs e)
        {
            if(ckntimkiemtheolop.Checked == true)
            {
                mo = false;
            }
           
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }
    }
            
}

