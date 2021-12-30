using Login.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.DataQuyen
{
    public class ListQuyen
    {
        public void DocFile(string path)
        {
            Const.ListQuyen.Clear();

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read))
            {

                using (StreamReader Read = new StreamReader(fs))
                {
                    String line = String.Empty; // tạo rỗng cho nó
                    Quyen quyen;
                    while ((line = Read.ReadLine()) != null)
                    {
                        if (!String.IsNullOrEmpty(line))
                        {
                            
                            quyen = new Quyen();
                            quyen.Quyen1 = line;
                            Const.ListQuyen.Add(quyen);
                        }
                    }
                }

            }

        }
    }
}
