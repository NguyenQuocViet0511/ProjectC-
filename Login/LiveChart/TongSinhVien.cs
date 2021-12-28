using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.LiveChart
{
  public  class TongSinhVien
    {
        private int year;
        private int month;
        private double values;

        public int Year { get => year; set => year = value; }
        public int Month { get => month; set => month = value; }
        public double Values { get => values; set => values = value; }
    }
}
