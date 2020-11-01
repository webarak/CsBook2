using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p._74_t_17
{
    class Program
    {
        public static void kelet(int[] a)
        {
            //טענת כניסה : קבלת מערך ריק
            //טענת יציאה : קבלת ערכים והכנסתם למערך
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("enter a number");
                a[i] = int.Parse(Console.ReadLine()); ;
            }
        }
        public static void print(int[] a)
        {
            //טענת כניסה : קבלת מערך 
            //טענת יציאה : הדפסת המערך
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + ",");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] action = new int[6];
            int[] result = new int[action.Length / 3];
            kelet(action);
            print(action);
            int indexresult = 0;
            for (int i = 0; i < action.Length; i = i+3)
            {
                if (action[i] == 1)
                {
                    result[indexresult] = action[i + 1] + action[i + 2];
                    indexresult++;
                }
                if (action[i] == 2)
                {
                    result[indexresult] = action[i + 1] - action[i + 2];
                    indexresult++;
                }
            }
            print(result);
        }
    }
}
