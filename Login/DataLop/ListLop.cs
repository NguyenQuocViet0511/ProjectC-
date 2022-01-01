using Login.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.DataLop
{
  public  class ListLop
    {
        public ListLop()
        {

        }
        public void GhiFile(String path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                using (StreamWriter SW = new StreamWriter(fs))
                {
                    for (int i = 0; i < Const.ListLop.Count; i++)
                    {
                        SW.WriteLine(String.Format("{0},{1}", Const.ListLop[i].ID1, Const.ListLop[i].Lop1));
                    }
                }
            }
        }
        public void DocFile(string path)
        {
            Const.ListLop.Clear();

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read))
            {

                using (StreamReader Read = new StreamReader(fs))
                {
                    String line = String.Empty; // tạo rỗng cho nó
                    Lop lop;
                    while ((line = Read.ReadLine()) != null)
                    {
                        if (!String.IsNullOrEmpty(line))
                        {
                            String[] Tach = line.Split(',');
                            lop = new Lop();
                            lop.ID1 = Convert.ToInt32(Tach[0]);
                            lop.Lop1 = Tach[1];
                            Const.ListLop.Add(lop);
                        }
                    }
                }

            }

        }
    }
}
