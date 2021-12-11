using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.DataUser
{
    public class User
    {
        private int MaID;
        private String HovaTen;
        private String GioiTinh;
        private String Ngaysinh;
        private String TenTaiKhoan;
        private String Matkhau; 
        private String Email;
        private String DiaChi;
        private String Quyen;

        public int MaID1 { get => MaID; set => MaID = value; }
        public string HovaTen1 { get => HovaTen; set => HovaTen = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public string Ngaysinh1 { get => Ngaysinh; set => Ngaysinh = value; }
        public string TenTaiKhoan1 { get => TenTaiKhoan; set => TenTaiKhoan = value; }
        public string Matkhau1 { get => Matkhau; set => Matkhau = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string Quyen1 { get => Quyen; set => Quyen = value; }
       

        public User(int MaID, String HoVaTen,String GioiTinh,String NgaySinh, String TenTaiKhoan, String MatKhau, String Email, String Diachi, String Quyen)
    {
            this.MaID = MaID;
            this.HovaTen = HoVaTen;
            this.GioiTinh = GioiTinh;
            this.Ngaysinh = NgaySinh;
            this.TenTaiKhoan = TenTaiKhoan;
            this.Matkhau = MatKhau;
            this.Email = Email;
            this.DiaChi = Diachi;
            this.Quyen = Quyen;

    }
        public User()
        {
        }
        public override bool Equals(object obj)
        {
            if (obj is User)
            {
                return this.MaID.Equals(((User)obj).MaID1);
            }
            return false;
        }
    }
}
