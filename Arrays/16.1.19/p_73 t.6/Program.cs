using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p_73_t._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random R = new Random();
            int[] Arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Arr[i] = R.Next(1, 10);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0} ", Arr[i]);
            }
            Console.WriteLine();
            int[] Brr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Brr[i] = (Arr[i])*2;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0} ", Brr[i]);
            }
        }
    }
}
