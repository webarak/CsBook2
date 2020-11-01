using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p_58_t_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "aabccccaaacddd";
            int count = 1;
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] != str[i + 1])
                {
                    count++;
                }
                
            }
            Console.WriteLine(count);
        }
    }
}
