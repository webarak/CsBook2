using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p._87_t_30
{
    class Program
    {
        public static int bigestplace(int[] a)
        {
            // טענת כניסה : קבלת מערך
            // טענת יציאה : מיקום האיבר הגדול מאיברי המערך
            int place = 0;
            int max = int.MinValue;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                    place = i;
                }
            }
            return place;
        }
        static void Main(string[] args)
        {
            int numworker = 0;
            int[] counters = new int[6];
            ArrayService.zero(counters);
            while (numworker != -999)
            {
                Console.WriteLine("enter number of worker");
                numworker = int.Parse(Console.ReadLine());
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine("enter your vote");
                    int vote = int.Parse(Console.ReadLine());
                    if (vote == 1)
                    {
                        counters[i]++;
                    }
                    if (vote == 0)
                    {
                        counters[i] += 0;
                    }
                }
            }
            Console.WriteLine("the canidate that earn the most pf the point in the {0} canidate", bigestplace(counters));

        }
    }
}
