using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p_58_t_5
{
    class Program
    {
        public static char haimappear(string a, int b)
        {
            char ch;
            if (b < a.Length || b == a.Length)
            {
                ch = a[b];
            }
            else
            {
                ch = 'X';
            }
            return ch;
        }
        static void Main(string[] args)
        {
            string str = "vbbbbbbbbbbbbbbbbbbbbbbb";
            Console.WriteLine(haimappear(str,8));
        }
    }
}
