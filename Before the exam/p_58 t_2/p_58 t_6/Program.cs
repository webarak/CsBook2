using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p_58_t_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            bool takin = false;
            int countmun = 0;
            int countlett = 0;
            if (str.Length >= 6)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if ((str[i] >= '0' && str[i] <= '9'))
                    {
                        countmun++;
                    }
                    if ((str[i] >= 'A' && str[i] <= 'Z') || (str[i] >= 'a' && str[i] <= 'z'))
                    {
                        countlett++;
                    }
                }
                if (countlett >= 1 && countmun >= 1)
                {
                    takin = true;
                }
            }
            
            while (takin != true)
            {
                str = Console.ReadLine();
                if (str.Length >= 6)
                {
                    for (int i = 0; i < str.Length; i++)
                    {
                        if ((str[i] >= '0' && str[i] <= '9'))
                        {
                            countmun++;
                        }
                        if ((str[i] >= 'A' && str[i] <= 'Z') || (str[i] >= 'a' && str[i] <= 'z'));
                        {
                            countlett++;
                        }
                    }
                    if (countlett >= 1 && countmun >= 1)
                    {
                        takin = true;
                    }
                }
            }
        }
    }
}
