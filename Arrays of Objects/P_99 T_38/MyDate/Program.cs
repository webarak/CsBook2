using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDate
{
    class Program
    {
        public static void mostmonth(Date[] a)//פעולה המדפיסה את החודש בו יש הכי הרבה ימי הולדת
        {
            int[] months = new int[13];
            ArrayService.zero(months);
            for (int i = 0; i < a.Length; i++)
            {
                months[a[i].Get_Month()]++;
            }
            Console.WriteLine(ArrayService.bigestplace(months));

        }
        static void Main(string[] args)
        {
            Date[] Dates = new Date[5];
            
            for (int i = 0; i < Dates.Length; i++)
            {
                Console.WriteLine("enter day");
                int d = int.Parse(Console.ReadLine());
                Console.WriteLine("enter month");
                int m = int.Parse(Console.ReadLine());
                Console.WriteLine("enter year");
                int y = int.Parse(Console.ReadLine());
                Dates[i] = new Date(d, m, y);
                
            }
            mostmonth(Dates);
        }
    }
}
