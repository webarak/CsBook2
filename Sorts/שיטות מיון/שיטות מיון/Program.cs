using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace שיטות_מיון
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {23,15,6,7,30};
            ArrayService.print(a);
            int temp;
            int placemin;
            for (int i = 0; i < a.Length-1; i++)
            {
                placemin = i;
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] < a[placemin])
                    {
                        placemin = j;
                    }

                }
                temp = a[i];
                a[i] = a[placemin];
                a[placemin] = temp;
            }
            ArrayService.print(a);

        }
    }
}
