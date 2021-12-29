using Login.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.DataSinhVien
{
   public class ListSinhVien
    {

        public ListSinhVien()
        {

        }
        public void GhiFile(String path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                using (StreamWriter SW = new StreamWriter(fs))
                {
                    for (int i = 0; i < Const.ListSinhVien.Count; i++)
                    {
                        SW.WriteLine(String.Format("{0},{1},{2},{3},{4},{5},{6}", Const.ListSinhVien[i].STT1, Const.ListSinhVien[i].MaSV1, Const.ListSinhVien[i].HovaTen1, Const.ListSinhVien[i].GioiTinh1, Const.ListSinhVien[i].NgaySinh1, Const.ListSinhVien[i].DiaChi1, Const.ListSinhVien[i].Lop1));
                    }
                }
            }
        }
        public void DocFile(string path)
        {
            Const.ListSinhVien.Clear();

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read))
            {

                using (StreamReader Read = new StreamReader(fs))
                {
                    String line = String.Empty; // tạo rỗng cho nó
                    SinhVien sinhvien;
                    while ((line = Read.ReadLine()) != null)
                    {
                        if (!String.IsNullOrEmpty(line))
                        {
                            String[] Tach = line.Split(',');
                            sinhvien = new SinhVien();
                            sinhvien.STT1 = Convert.ToInt32(Tach[0]);
                            sinhvien.MaSV1 = Convert.ToInt32(Tach[1]);
                            sinhvien.HovaTen1 = Tach[2];
                            sinhvien.GioiTinh1 = Tach[3];
                            sinhvien.NgaySinh1 = Tach[4];
                            sinhvien.DiaChi1 = Tach[5];
                            sinhvien.Lop1 = Tach[6];
                            Const.ListSinhVien.Add(sinhvien);
                        }
                    }
                }

            }

        }
        internal void XuatExcel(string path)
        {
            List<string> list = new List<string>();
            //code Xuất Excel 
            foreach (SinhVien item in Const.ListSinhVien)
            {
                string line = string.Format("{0},{1},{2},{3},{4},{5},{6}", item.STT1, item.MaSV1, item.HovaTen1, item.GioiTinh1,item.NgaySinh1,item.DiaChi1,item.Lop1);
                list.Add(line);
            }
            string[] title = new string[]{
                "ma so","Họ và tên","Phòng ban", "Giải","Thanh tien"
            };
            XuatFileExcel.XuatExcel(path, list, "Danh sách Sinh Viên ", "Đang Có", title);
            // XuatFileExcel.XuatExcel(path, list, "Danh sách nhân viên trúng giải", "Đã ký", "id","name","phong ban");
        }

       
    }
}
