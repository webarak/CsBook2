using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p._74_t_16
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
            int[] a = new int[4];
            kelet(a);
            print(a);
            double indexb1 = a.Length * 1.5;
            int indexb2 = 0;
            int[] b = new int[(int)indexb1];
            for (int i = 0; i < a.Length; i = i+2)
            {
                b[indexb2] = a[i];
                b[indexb2+1] = a[i+1];
                if ((a[i] + a[i + 1]) % 3 == 0)
                {
                    b[indexb2 + 2] = a[i] + a[i + 1];
                }
                else
                {
                    b[indexb2 + 2] = 0;
                }
                indexb2 = indexb2 + 3;
            }
            print(b);
        }
    }
}
