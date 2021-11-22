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
                        SW.WriteLine(String.Format("{0},{1},{2},{3},{4},{5}", Const.ListUser[i].MaID1, Const.ListUser[i].HovaTen1, Const.ListUser[i].TenTaiKhoan1, Const.ListUser[i].Matkhau1, Const.ListUser[i].Email1, Const.ListUser[i].Quyen1));
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
                            user.TenTaiKhoan1 = Tach[2];
                            user.Matkhau1 = Tach[3];
                            user.Email1 = Tach[4];
                            user.Quyen1 = Tach[5];
                            
                            Const.ListUser.Add(user);
                        }
                    }
                }

            }

        }
    }
}
