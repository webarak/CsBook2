using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p_58_t_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abbaasd";
            bool appear = true;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '0' || str[i] == '1'|| str[i] == '2'||str[i] == '3'||str[i] == '4'||str[i] == '5'||str[i] == '6'||str[i] == '7'||str[i] == '8'||str[i] == '9')
                {
                    appear = false;
                }
            }
            if (appear == true)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
