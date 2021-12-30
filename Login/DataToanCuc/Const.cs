using Login.DataQuyen;
using Login.DataSinhVien;
using Login.DataUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Data
{
   public class Const
    {
      static  public List<User> ListUser = new List<User>();
        static public List<Quyen> ListQuyen = new List<Quyen>();
        static public List<SinhVien> ListSinhVien = new List<SinhVien>();
      static  public String Pathfile = String.Format(@"{0}\DanhSachUser.ini", Application.StartupPath);
        static public String PathfileSV = String.Format(@"{0}\DanhSachSinhVien.ini", Application.StartupPath);
        static public String PathfileQuyen = String.Format(@"{0}\Quyen.ini", Application.StartupPath);
        static  public List<String> CheckuserName = new List<string>();
      static public List<String> CheckEmail = new List<string>();
      static public User User = new User();
      static public User UserLogin = new User();
    }
}
