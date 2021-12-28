using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.DataSinhVien
{
   public class SinhVien
    {
        private int STT;
        private int MaSV;
        private String HovaTen;
        private String GioiTinh;
        private String NgaySinh;
        private String DiaChi;
        private String Lop;

        public int STT1 { get => STT; set => STT = value; }
        public int MaSV1 { get => MaSV; set => MaSV = value; }
        public string HovaTen1 { get => HovaTen; set => HovaTen = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public string NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string Lop1 { get => Lop; set => Lop = value; }
        public SinhVien()
        {

        }
        public SinhVien(int STT, int MaSV,String hovaten,String Gioitinh,String ngaysinh,String diachi,String Lop)
        {
            this.STT = STT;
            this.MaSV = MaSV;
            this.HovaTen = hovaten;
            this.GioiTinh = Gioitinh;
            this.NgaySinh = ngaysinh;
            this.DiaChi = diachi;
            this.Lop = Lop;
        }
        public override bool Equals(object obj)
        {
            if (obj is SinhVien)
            {
                return this.STT.Equals(((SinhVien)obj).STT1);
            }
            return false;
        }
    }
}
