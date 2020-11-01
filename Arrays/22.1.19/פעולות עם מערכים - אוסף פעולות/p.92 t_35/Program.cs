using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p._92_t_35
{
    class Program
    {
        public static bool appear(int[] a, int num)
        {
            // טענת כניסה : קבלת מערך ומספר
            // טענת יציאה : האם המספר נמצא במערך (true/false)
            bool appear = false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == num)
                {
                    appear = true;
                }
            }
            return appear;
        }
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
            int[] arr = { 1, 4, 3, 7, -8 };
            int[] brr = { 4, 1, 6, 2, 5, 7, -1, -49 };
            int[] crr = new int[Math.Min(arr.Length,brr.Length)];
            int indexcrr = 0;
            for (int i = 0; i < crr.Length; i++)
            {
                bool yes = appear(brr, arr[i]);
                if (yes == true)
                {
                    crr[indexcrr] = arr[i];
                    indexcrr++;
                }
            }
            print(crr);
        }
    }
}
