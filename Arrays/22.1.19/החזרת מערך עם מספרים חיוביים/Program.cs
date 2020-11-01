using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace החזרת_מערך_עם_מספרים_חיוביים
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
                Console.Write(a[i] +",");
            }
            Console.WriteLine();
        }
        public static int[] positive(int[] a)
        {
            // טענת כניסה : קבלת מערך
            // טענת יציאה : החזרת מערך חדש בעל המספרים החיוביים במערך הראשון 
            int counter = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0)
                {
                    counter++;
                }
            }
            int[] b = new int[counter];
            int indexb = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0)
                {
                    indexb++;
                    b[indexb] = a[i];
                }
            }
            return b;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            kelet(arr);
            int[] b = positive(arr);
            print(b);

        }
    }
}
