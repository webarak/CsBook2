using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDomino
{
    class Domino
    {
        private int topnumber;
        private int lownumber;
        
      //  Random R = new Random();
        //public Domino()
        //{
        //    this.topnumber = R.Next(1, 7);
        //    this.lownumber = R.Next(1, 7);
        //}
        public Domino(int n1,int n2)
        {
            this.topnumber = n1;
            this.lownumber = n2;
        }

        public int Get_TopNumber()
        {
            return this.topnumber;
        }

        public int Get_LowNumber()
        {
            return this.lownumber;
        }

        public void print()
        {
            Console.WriteLine(this.topnumber);
            Console.WriteLine(this.lownumber);
        }
    }
}
