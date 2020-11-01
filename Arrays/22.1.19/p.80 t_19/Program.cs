using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p._80_t_19
{
    class Program
    {
        public static int sum(int[] a)
        {
            //טענת כניסה : קבלת מערך 
            //טענת יציאה : חישוב סכום איברי המערך
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }
            return sum;
        }
        public static double avg(int[] a)
        {
            //טענת כניסה : קבלת מערך
            //טענת יציאה : חישוב ממוצע איברי המערך
            int suma = sum(a);
            double avarage = (double)suma / a.Length;
            return avarage;
        }
        public static bool maarch_meozan(int[] a)
        {
            // טענת כניסה : קבלת מערך
            // טענת יציאה : האם המערך הינו מערך מאוזן
            int counterabove = 0;
            int counterunder = 0;
            double avarage = avg(a);
            bool meozan = true;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > avarage)
                {
                    counterabove++;
                }
                if (a[i] < avarage)
                {
                    counterunder++;
                }
            }
            if (counterabove != counterunder)
            {
                meozan = false;
            }
            return meozan;
        }
        static void Main(string[] args)
        {
            int[] a = new int[8];
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("enter a number");
                int num = int.Parse(Console.ReadLine());
                a[i] = num;
            }
            Console.WriteLine(maarch_meozan(a));
        }
    }
}
