using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p_73_t._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 10;
            int max = 0;
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
            for (int i = 0; i < 10; i++)
            {
                if (Arr[i] > max)
                    max = Arr[i];
                if (Arr[i] < min)
                    min = Arr[i];
            }
            Console.WriteLine("the biggest number is {0} and the smallest is {1}", max, min);
        }
    }
}
