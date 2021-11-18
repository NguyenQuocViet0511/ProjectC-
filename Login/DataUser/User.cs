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
        private String TenTaiKhoan;
        private String Matkhau;
        private String Email;
        private String Quyen;

        public int MaID1 { get => MaID; set => MaID = value; }
        public string HovaTen1 { get => HovaTen; set => HovaTen = value; }
        public string TenTaiKhoan1 { get => TenTaiKhoan; set => TenTaiKhoan = value; }
        public string Matkhau1 { get => Matkhau; set => Matkhau = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Quyen1 { get => Quyen; set => Quyen = value; }
    
    public User(int MaID, String HoVaTen, String TenTaiKhoan, String MatKhau, String Email, String Quyen)
    {
            this.MaID = MaID;
            this.HovaTen = HoVaTen;
            this.TenTaiKhoan = TenTaiKhoan;
            this.Matkhau = MatKhau;
            this.Email = Email;
            this.Quyen = Quyen;

    }
        public User()
        {
        }

    }
}
