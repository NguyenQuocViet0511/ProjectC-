using Login.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.DataQuyen
{
  public class Quyen
    {
        private String quyen;

        public string Quyen1 { get => quyen; set => quyen = value; }
        public Quyen(String Quyen)
        {
            this.quyen = Quyen;
        }
        public Quyen()
        {
        }
    }
}
