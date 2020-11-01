using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace מיון_בועות
{
    class Program
    {
        static void Main(string[] args)
        {
            int []a = {30,15,23,7,6};
            ArrayService.print(a);
            int temp;
            for (int i = 0; i<a.Length-1;i++)
            {
                for (int j = 0; j < a.Length-i-1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            ArrayService.print(a);
        }
    }
}
