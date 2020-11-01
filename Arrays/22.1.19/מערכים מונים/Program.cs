using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace מערכים_מונים
{
    class Program
    {
        public static int[] monim()
        {
            Random R = new Random();
            int[] counters = new int[10];
            ArrayService.zero(counters);
            for (int i = 1; i <= 1000; i++)
            {
                int num = R.Next(1, 10);
                counters[num]++;
            }
            return counters;
        }
    
    
        static void Main(string[] args)
        {
            //Random R = new Random();
            //int[] counters = new int[10];
            //ArrayService.zero(counters);
            //for (int i = 1; i <= 1000; i++)
            //{
            //    int num = R.Next(1, 10);
            //    counters[num]++;
            //}
            //for (int i = 1; i < counters.Length; i++)
            //{
            //    Console.WriteLine(i + "-" + counters[i]);
            //}
            int[] counters = monim();
            for (int i = 1; i < counters.Length; i++)
            {
                Console.WriteLine(i + "-" + counters[i]);
            }
        }
    }
}
