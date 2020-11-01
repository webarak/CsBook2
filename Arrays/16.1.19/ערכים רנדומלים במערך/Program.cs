using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ערכים_רנדומלים_במערך
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Ran = new int[10];
            Random R = new Random();
            for (int i= 0; i <= 9; i++)
            {
                Ran[i] = R.Next(1, 10);
            }
            for (int j = 0; j <=9; j++)
            {
                Console.Write("{0} ", Ran[j]);
            }
        }
    }
}
