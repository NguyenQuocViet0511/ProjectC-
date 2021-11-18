using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Data
{
    class ListNhanVien
    {
        private static ListNhanVien setting;
        public List<NhanVien> ListNV = new List<NhanVien>();




        public static ListNhanVien Setting
        {
            get
            {
                if (setting == null)

                    setting = new ListNhanVien();
                return setting;
            }
            set => setting = value;
        }
        public ListNhanVien()
        {

        }
        public void ReadFile(string path)
        {

            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {

                using (StreamReader Read = new StreamReader(fs))
                {
                    String line = String.Empty; // tạo rỗng cho nó
                    NhanVien NV;
                    int i = 0;
                    while ((line = Read.ReadLine()) != null)
                    {
                        if (!String.IsNullOrEmpty(line))
                        {
                            String[] NVarray = line.Split(',');
                            NV = new NhanVien();
                            NV.STT1 = i++;
                            NV.ID = Convert.ToInt32(NVarray[0]);
                            NV.Hoten1 = NVarray[1];
                            NV.Phongban1 = NVarray[2];
                            ListNV.Add(NV);
                        }
                    }
                }

            }
        }
}
}
