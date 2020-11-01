using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p._87_t_30
{
    class ArrayService
    {
        public static void random(int[] a)
        {
            //טענת כניסה : קבלת מערך ריק
            //טענת יציאה : הכנסת ערכים רנדומלים חד ספרתיים
            Random R = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = R.Next(1, 10);
            }

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
        public static void zero(int[] a)
        {
            // טענת כניסה : מערך ריק
            // טענת יציאה : איפוס איברי המערך
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = 0;
            }

        }
        public static int bigest(int[] a)
        {
            // טענת כניסה : קבלת מערך
            // טענת יציאה : האיבר הגדול מאיברי המערך
            int max = int.MinValue;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }
        public static int tiniest(int[] a)
        {
            // טענת כניסה : קבלת מערך
            // טענת יציאה : האיבר הקטן מאיברי המערך
            int min = int.MaxValue;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            return min;
        }
        public static int bigestplace(int[] a)
        {
            // טענת כניסה : קבלת מערך
            // טענת יציאה : מיקום האיבר הגדול מאיברי המערך
            int place = 0;
            int max = int.MinValue;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                    place = i;
                }
            }
            return place;
        }
        public static int tiniestplace(int[] a)
        {
            // טענת כניסה : קבלת מערך
            // טענת יציאה : מיקום האיבר הקטן מאיברי המערך
            int place = 0;
            int min = int.MaxValue;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];

                    place = i;
                }
            }
            return place;
        }
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
        public static int placenappearence(int[] a, int num)
        {
            // טענת כניסה : קבלת מערך ומספר
            // טענת יציאה : מיקום המספר במערך
            int place = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == num)
                {
                    place = i;
                }
            }
            return place;
        }
        public static bool uporder(int[] a)
        {
            // טענת כניסה : קבלת מערך
            // טענת יציאה : האם המערך מסודר בסדר עולה
            bool yes = true;
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] >= a[i + 1])
                {
                    yes = false;
                }
            }
            return yes;
        }
        public static bool samenum(int[] a)
        {
            // טענת כניסה : קבלת מערך
            // טענת יציאה : האם המערך מורכב מאיברים זהים
            bool yes = true;
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] != a[i + 1])
                {
                    yes = false;
                }
            }
            return yes;
        }
        public static int numberofappearence(int[] a, int num)
        {
            // טענת כניסה : קבלת מערך
            // טענת יציאה : מספר הפעמים שהמספר מופיע במערך
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == num)
                {
                    count = count + 1;
                }
            }
            return count;
        }
        public static bool differentnum(int[] a)
        {
            // טענת כניסה : קבלת מערך
            // טענת יציאה : האם המערך מורכב מאיברים שונים אחד מהשני
            bool appear = true;
            int numoftimes = 0;
            for (int i = 0; i < a.Length; i++)
            {
                numoftimes = numberofappearence(a, a[i]);
                if (numoftimes > 1)
                {
                    appear = false;
                }
            }
            return appear;
        }
    }
}
