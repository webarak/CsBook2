using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace קליטת_נתונים_למערך
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] Arr = new int[10];
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("enter a number");
                Arr[i] = int.Parse(Console.ReadLine()); ;
            }
            for (int j = 0; j <= 9; j++)
            {
                Console.Write("{0},", Arr[j]);
            }
            for (int a = 0; a<=9;a++)
            {
                sum = sum + Arr[a];
            }
            Console.WriteLine("the sum of this nummbers is : {0}", sum);
        }
    }
}
