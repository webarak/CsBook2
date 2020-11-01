using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p_58_t_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "$5cd#nm$uvw";
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i].CompareTo(str[i + 1]) == -1)
                {
                    Console.WriteLine(str[i]+","+str[i+1]);
                }
            }
        }
    }
}
