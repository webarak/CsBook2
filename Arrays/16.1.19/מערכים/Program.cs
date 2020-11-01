using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace מערכים
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = new int[10];
            for (int i = 0; i <= 9; i++)
            {
                Arr[i] = 0;
            }
            for (int j = 0; j <= 9; j++)
            {
                Console.Write("{0} ", Arr[j]);
            }

            

        }
    }
}
