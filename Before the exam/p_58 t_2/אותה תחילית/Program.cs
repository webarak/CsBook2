using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace אותה_תחילית
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = { "shalom", "shlomi", "shlomit", "shlomo", "baral" };
            string str = "shl";
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                string ps = a[i].Substring(0, str.Length);
                if (ps == str)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
