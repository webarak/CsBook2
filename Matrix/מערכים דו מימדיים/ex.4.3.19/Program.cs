using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex._4._3._19
{
    class Program
    {
        public static void random(int[,] a)
        {
            //טענת כניסה : מקבלת מטריצה
            //טענת יציאה : הכנסת ערכים רנדומלים למטריצה
            Random R = new Random();
            for (int shura = 0; shura < a.GetLength(0); shura++)
            {
                for (int amuda = 0; amuda < a.GetLength(1); amuda++)
                {

                    a[shura, amuda] = R.Next(2);
                }
            }
        }
        public static int[,] biggermatrix(int[,] a)
        {
            //טענת כניסה : קבלת מטריצה 
            //טענת יציאה : הכנסת המערך למערך גדול יותר עם מסגרת אפסים והחזרתו
            int[,] m = new int[a.GetLength(0) + 2, a.GetLength(1) + 2];
            MatrixService.zero(m);
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    m[i+1, j+1] = a[i, j];
                }
            }
            return m;
        }
        public static void lonlycells(int [,] a)
        {
            //טענת כניסה : קבלת מטריצה
            //טענת יציאה : הדפסת מיקומי התאים הבודדים
            for (int i = 1; i < a.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < a.GetLength(1) - 1; j++)
                {
                    if (a[i, j] == 1)
                    {
                        if (a[i - 1, j - 1] + a[i, j - 1] + a[i + 1, j - 1] + a[i + 1, j] + a[i + 1, j + 1] + a[i, j + 1] + a[i - 1, j + 1] + a[i - 1, j] == 0)
                        {
                            Console.WriteLine("{0},{1} is the place of the lonely cell", i-1,j-1);
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[,] lonly = new int[5, 7];
            random(lonly);
            MatrixService.print(lonly);
            Console.WriteLine();
            int[,] biggerlonly = biggermatrix(lonly);
            MatrixService.print(biggerlonly);
            Console.WriteLine();
            lonlycells(biggerlonly);
        }
    }
}
