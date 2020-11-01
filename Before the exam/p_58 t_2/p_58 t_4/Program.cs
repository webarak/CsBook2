using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p_58_t_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abac";
            bool a = false;
            if (str[0] == str[str.Length - 1])
            {
                a = true;
            }
            Console.WriteLine(a);
        }
    }
}
