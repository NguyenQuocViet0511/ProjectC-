using Login.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.DataUser
{
  public  class ListUser
    {

        

        public ListUser()
        {
            
        }
        public void GhiFile(String path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                using (StreamWriter SW = new StreamWriter(fs))
                {
                    for (int i = 0; i < Const.ListUser.Count; i++)
                    {
                        SW.WriteLine(String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8}", Const.ListUser[i].MaID1, Const.ListUser[i].HovaTen1, Const.ListUser[i].GioiTinh1, Const.ListUser[i].Ngaysinh1, Const.ListUser[i].TenTaiKhoan1, Const.ListUser[i].Matkhau1, Const.ListUser[i].Email1, Const.ListUser[i].DiaChi1, Const.ListUser[i].Quyen1));
                    }
                }
            }
        }
        public void DocFile(string path)
        {
            Const.ListUser.Clear();

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read))
            {

                using (StreamReader Read = new StreamReader(fs))
                {
                    String line = String.Empty; // tạo rỗng cho nó
                    User user;
                    while ((line = Read.ReadLine()) != null)
                    {
                        if (!String.IsNullOrEmpty(line))
                        {
                            String[] Tach = line.Split(',');
                            user = new User();
                            user.MaID1 = Convert.ToInt32(Tach[0]);
                            user.HovaTen1 = Tach[1];
                            user.GioiTinh1 = Tach[2];
                            user.Ngaysinh1 = Tach[3];
                            user.TenTaiKhoan1 = Tach[4];
                            user.Matkhau1 = Tach[5];
                            user.Email1 = Tach[6];
                            user.DiaChi1 = Tach[7];
                            user.Quyen1 = Tach[8];
                            
                            Const.ListUser.Add(user);
                        }
                    }
                }

            }

        }
    }
}
