using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace מחרוזות
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter string");
                str = Console.ReadLine();
                if (str.Length % 2 == 0)
                {
                    Console.WriteLine(str);
                }
            }
        }
    }
}
