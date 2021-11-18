using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Data
{
    public class NhanVienNhanGiaiDao
    {
        public List<NhanVienTrungGiai> nhanVienTrungGiais;
        public string path { get; set; }


        public NhanVienNhanGiaiDao()
        {
            nhanVienTrungGiais = new List<NhanVienTrungGiai>();

           
        }

        public void DocNoiDung(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string line = string.Empty;
                    NhanVienTrungGiai nhanVienTrungGiai;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (!string.IsNullOrEmpty(line))
                        {
                            string[] vs = line.Split(',');
                            nhanVienTrungGiai = new NhanVienTrungGiai()
                            {
                                ID = Convert.ToInt32(vs[0]),
                                Hoten1 = vs[1],
                                Phongban1 = vs[2],
                                Giai1 = vs[3]
                            };
                            nhanVienTrungGiais.Add(nhanVienTrungGiai);
                        }
                    }
                }
            }
        }
        public void GhiNoiDung(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    //Sử dụng cấu trúc using để khai báo đối tượng FileStream
                    foreach (NhanVienTrungGiai item in nhanVienTrungGiais)
                    {
                        //Phương thức WriteLine dùng để ghi một đoạn string lên file text. sau đó xuống dòng
                        sw.WriteLine(string.Format("{0},{1},{2},{3}", item.ID, item.Hoten1, item.Phongban1, item.Giai1));
                    }
                }
            }
        }

        internal void XuatExcel(string path)
        {
            List<string> list = new List<string>();
            //code Xuất Excel 
            foreach (NhanVienTrungGiai item in nhanVienTrungGiais)
            {
                string line = string.Format("{0},{1},{2},{3}",item.ID, item.Hoten1, item.Phongban1, item.Giai1);
                list.Add(line);
            }
            string[] title = new string[]{
                "Mã Nhân Viên","Họ và tên","Phòng ban", "Giải"
            };
            XuatFileExcel.XuatExcel(path, list, "Danh sách nhân viên trúng giải", "Đã ký", title);
            // XuatFileExcel.XuatExcel(path, list, "Danh sách nhân viên trúng giải", "Đã ký", "id","name","phong ban");
        }

        internal void XuatExcel(string path, DataGridView dgv)
        {
            XuatFileExcel.XuatExcel(path, dgv, 1, "Tahoma", 16, 12);

        }
    }
}