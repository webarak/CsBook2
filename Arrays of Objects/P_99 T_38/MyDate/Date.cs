using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDate
{
    class Date
    {
        private int day;
        private int month;
        private int year;

        public Date(int d, int m, int y)//פעולה בונה
        {
            this.day = d;
            this.month = m;
            this.year = y;
        }
        public int Get_Month()
        {
            return this.month;
        }
    }
}
