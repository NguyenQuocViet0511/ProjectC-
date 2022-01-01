using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.DataLop
{
   public class Lop
    {
        private int ID;
        private String lop;

        public int ID1 { get => ID; set => ID = value; }
        public string Lop1 { get => lop; set => lop = value; }
        public Lop(int ID, String Lop)
        {
            this.ID = ID;
            this.lop = Lop;
        }
        public Lop()
        {

        }
        public override bool Equals(object obj)
        {
            if (obj is Lop)
            {
                return this.ID.Equals(((Lop)obj).ID1);
            }
            return false;
        }
    }
}
