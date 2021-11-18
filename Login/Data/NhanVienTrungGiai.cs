using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Data
{
    public class NhanVienTrungGiai : IComparable
    {

        int STT;
        int iD;
        String Hoten;
        String Phongban;
        String Giai;
        public int STT1 { get => STT; set => STT = value; }
        public string Hoten1 { get => Hoten; set => Hoten = value; }
        public string Phongban1 { get => Phongban; set => Phongban = value; }
        public string Giai1 { get => Giai; set => Giai = value; }
        public int ID { get => iD; set => iD = value; }

        
        public NhanVienTrungGiai()
        {
        }

        public int CompareTo(object obj)
        {
            return ((NhanVienTrungGiai)obj).STT1.CompareTo(this.STT);
        }
    }
}
