using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Data
{
    class NhanVien
    {
        int STT;
        int iD;
        String Hoten;
        string Phongban;
        public int STT1 { get => STT; set => STT = value; }
        public int ID { get => iD; set => iD = value; }
        public string Hoten1 { get => Hoten; set => Hoten = value; }
        public string Phongban1 { get => Phongban; set => Phongban = value; }


        public NhanVien(int stt, int Id, String Hoten, String PhongBan)
        {
            this.STT = stt;
            this.iD = Id;
            this.Hoten = Hoten;
            this.Phongban = PhongBan;
        }
        public NhanVien()
        {

        }
        public override bool Equals(object obj)
        {
            if (obj is NhanVien)
            {
                return this.iD.Equals(((NhanVien)obj).ID);
            }
            return false;
        }
    }
}
