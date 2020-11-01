using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P._74_T_18
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
            int[] a = new int[10];
            kelet(a);
            print(a);
            int[] b = new int[a.Length];
            int indexb = 0;
            for (int i = 0; i < a.Length; i++)
            {
                
                if (a[i] < 0)
                {
                    b[indexb] = a[i];
                    indexb++;
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0)
                {
                    b[indexb] = a[i];
                    indexb++;
                }
            }

            print(b);

        }
    }
}
