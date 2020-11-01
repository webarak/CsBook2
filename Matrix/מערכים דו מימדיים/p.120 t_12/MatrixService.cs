using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p._120_t_12
{
    class MatrixService
    {
        public static void zero(int[,] a)
        {
            //טענת כניסה : מקבלת מטריצה
            //טענת יציאה : איפוס איברי המטריצה
            for (int shura = 0; shura < a.GetLength(0); shura++)
            {
                for (int amuda = 0; amuda < a.GetLength(1); amuda++)
                {
                    a[shura, amuda] = 0;
                }
            }
        }
        public static void kelet(int[,] a)
        {
            //טענת כניסה : מקבלת מטריצה
            //טענת יציאה : הכנסת ערכים למטריצה
            for (int shura = 0; shura < a.GetLength(0); shura++)
            {
                for (int amuda = 0; amuda < a.GetLength(1); amuda++)
                {
                    Console.WriteLine("enter a number to {0},{1}", shura, amuda);
                    a[shura, amuda] = int.Parse(Console.ReadLine());
                }
            }
        }
        public static void random(int[,] a)
        {
            //טענת כניסה : מקבלת מטריצה
            //טענת יציאה : הכנסת ערכים רנדומלים למטריצה
            Random R = new Random();
            for (int shura = 0; shura < a.GetLength(0); shura++)
            {
                for (int amuda = 0; amuda < a.GetLength(1); amuda++)
                {

                    a[shura, amuda] = R.Next(1, 10);
                }
            }
        }
        public static void print(int[,] a)
        {
            //טענת כניסה : מקבלת מטריצה
            //טענת יציאה : הדפסת המטריצה
            for (int shura = 0; shura < a.GetLength(0); shura++)
            {
                for (int amuda = 0; amuda < a.GetLength(1); amuda++)
                {
                    Console.Write(a[shura, amuda] + " ");
                }
                Console.WriteLine();
            }
        }
        public static int sum(int[,] a)
        {
            //טענת כניסה : מקבלת מטריצה
            //טענת יציאה : סכום איברי המטריצה
            int sum = 0;
            for (int shura = 0; shura < a.GetLength(0); shura++)
            {
                for (int amuda = 0; amuda < a.GetLength(1); amuda++)
                {
                    sum = sum + a[shura, amuda];
                }
            }
            return sum;
        }
        public static double avg(int[,] a)
        {
            //טענת כניסה : מקבלת מטריצה
            //טענת יציאה : ממוצע איברי המטריצה
            double avg = 0;
            double sumarr = sum(a);
            avg = sumarr / (a.GetLength(0) * a.GetLength(1));
            return avg;
        }
        public static int sumalacsonR(int[,] a)
        {
            //טענת כניסה : מקבלת מטריצה
            //טענת יציאה : סכום איברי האלכסון הראשי
            int sum = 0;

            for (int shura = 0; shura < a.GetLength(0); shura++)
            {

                sum = sum + a[shura, shura];

            }
            return sum;
        }
        public static void printalacsonR(int[,] a)
        {
            //טענת כניסה : מקבלת מטריצה
            //טענת יציאה : הדפסת איברי האלסון הראשי
            for (int shura = 0; shura < a.GetLength(0); shura++)
            {

                Console.Write(a[shura, shura] + " ");
            }
            Console.WriteLine();

        }
        public static int sumalacsonM(int[,] a)
        {
            //טענת כניסה : מקבלת מטריצה
            //טענת יציאה : סכום איברי האלכסון המשני
            int sum = 0;
            int amuda = a.GetLength(1) - 1;
            for (int shura = 0; shura < a.GetLength(0); shura++)
            {
                sum = sum + a[shura, amuda];
                amuda--;
            }
            return sum;
        }
        public static void printalacsonM(int[,] a)
        {
            //טענת כניסה : מקבלת מטריצה
            //טענת יציאה : הדפסת איברי האלכסון המשני

            int amuda = a.GetLength(1) - 1;
            for (int shura = 0; shura < a.GetLength(0); shura++)
            {
                Console.Write(a[shura, amuda] + " ");
                amuda--;
            }
            Console.WriteLine();

        }
        public static void follownumber(int[,] a)
        {
            //טענת כניסה : קבלת מטריצה
            //טענת יציאה : הכנסת מספרים עוקבים לפי שורה
            for (int shura = 0; shura < a.GetLength(0); shura++)
            {
                for (int amuda = 0; amuda < a.GetLength(1); amuda++)
                {
                    a[shura, amuda] = shura + 1;
                }
            }
        }
        public static int sumabovealacsonR(int[,] a)
        {
            //טענת כניסה : קבלת מטריצה
            //טענת יציאה : סכום האיברים שמעל האלכסון הראשי
            int sum = 0;
            for (int shura = 0; shura < a.GetLength(0) - 1; shura++)
            {
                for (int amuda = shura + 1; amuda < a.GetLength(1); amuda++)
                {
                    sum = sum + a[shura, amuda];
                }
            }
            return sum;
        }
        public static int sumnderalacsonR(int[,] a)
        {
            //טענת כניסה : קבלת מטריצה
            //טענת יציאה : סכום האיברים שמתחת האלכסון הראשי
            int sum = 0;
            for (int shura = 1; shura < a.GetLength(0); shura++)
            {
                for (int amuda = 0; amuda < shura; amuda++)
                {
                    sum = sum + a[shura, amuda];
                }
            }
            return sum;
        }
        public static void printnderalacsonR(int[,] a)
        {
            //טענת כניסה : קבלת מטריצה
            //טענת יציאה : הדפסת האיברים שמתחת האלכסון הראשי

            for (int shura = 1; shura < a.GetLength(0); shura++)
            {
                for (int amuda = 0; amuda < shura; amuda++)
                {
                    Console.Write(a[shura, amuda] + " ");
                }
                Console.WriteLine();
            }

        }
        public static void printabovealacsonR(int[,] a)
        {
            //טענת כניסה : קבלת מטריצה
            //טענת יציאה : הדפסת האיברים שמעל האלכסון הראשי
            int times = 1;
            for (int shura = 0; shura < a.GetLength(0) - 1; shura++)
            {
                for (int i = 1; i <= times; i++)
                {
                    Console.Write(" ");
                }
                for (int amuda = shura + 1; amuda < a.GetLength(1); amuda++)
                {

                    Console.Write(a[shura, amuda] + " ");

                }
                times += 2;
                Console.WriteLine();
            }
        }
        public static bool isexist(int[,] a, int num)
        {
            //טענת כניסה : קבלת מטריצה ומספר
            //טענת יציאה : האם המספר נמצא במטריצה?
            bool appear = false;
            for (int shura = 0; shura < a.GetLength(0); shura++)
            {
                for (int amuda = 0; amuda < a.GetLength(1); amuda++)
                {
                    if (a[shura, amuda] == num)
                    {
                        appear = true;
                    }
                }
            }
            return appear;
        }
        public static void printappear(int[,] a, int num)
        {
            //טענת כניסה : קבלת מטריצה ומספר
            //טענת יציאה : מיקום המספר במטריצה (בהנחה שהמספר מופיע פעם אחת)
            for (int shura = 0; shura < a.GetLength(0); shura++)
            {
                for (int amuda = 0; amuda < a.GetLength(1); amuda++)
                {
                    if (a[shura, amuda] == num)
                    {
                        Console.WriteLine(shura + " ," + amuda);
                    }
                }
            }
        }
        public static void printappearsssssss(int[,] a, int num)
        {
            //טענת כניסה : קבלת מטריצה ומספר
            //טענת יציאה : מיקום המספר במטריצה (בהנחה שהמספר מופיע כמה פעמים)
            for (int shura = 0; shura < a.GetLength(0); shura++)
            {
                for (int amuda = 0; amuda < a.GetLength(1); amuda++)
                {
                    if (a[shura, amuda] == num)
                    {
                        Console.WriteLine(shura + " ," + amuda);
                    }
                }
            }
        }
        public static int sumappears(int[,] a, int num)
        {
            //טענת כניסה : קבלת מטריצה ומספר
            //טענת יציאה : מספר הפעמים שהמספר מופיע במטריצה
            int sum = 0;
            for (int shura = 0; shura < a.GetLength(0); shura++)
            {
                for (int amuda = 0; amuda < a.GetLength(1); amuda++)
                {
                    if (a[shura, amuda] == num)
                    {
                        sum++;
                    }
                }
            }
            return sum;
        }
        public static void printshura(int[,] a, int shura)
        {
            //טענת כניסה : קבלת מטריצה ומספר שורה
            //טענת יציאה : הדפסת איברי השורה הנבחרת במטריצה
            for (int amuda = 0; amuda < a.GetLength(1); amuda++)
            {
                Console.Write(a[shura, amuda] + " ");
            }
            Console.WriteLine();
        }
        public static int sumshura(int[,] a, int shura)
        {
            //טענת כניסה : קבלת מטריצה ומספר שורה
            //טענת יציאה : סכום איברי השורה הנבחרת במטריצה
            int sum = 0;
            for (int amuda = 0; amuda < a.GetLength(1); amuda++)
            {
                sum = sum + a[shura, amuda];
            }
            return sum;
        }
        public static void printamuda(int[,] a, int amuda)
        {
            //טענת כניסה : קבלת מטריצה ומספר שורה
            //טענת יציאה : הדפסת איברי העמודה הנבחרת במטריצה
            for (int shura = 0; shura < a.GetLength(0); shura++)
            {
                Console.WriteLine(a[shura, amuda] + " ");
            }
        }
        public static int sumamuda(int[,] a, int amuda)
        {
            //טענת כניסה : קבלת מטריצה ומספר שורה
            //טענת יציאה : סכום איברי העמודה הנבחרת במטריצה
            int sum = 0;
            for (int shura = 0; shura < a.GetLength(0); shura++)
            {
                sum = sum + a[shura, amuda];
            }
            return sum;
        }
        public static void printbigappear(int[,] a)
        {
            //טענת כניסה: קבלת מטריצה
            //טענת יציאה : הדפסת מיקום המספר הגדול במטריצה
            int max = int.MinValue;
            int Pshura = 0;
            int Pamuda = 0;
            for (int shura = 0; shura < a.GetLength(0); shura++)
            {
                for (int amuda = 0; amuda < a.GetLength(1); amuda++)
                {
                    if (a[shura, amuda] > max)
                    {
                        max = a[shura, amuda];
                        Pshura = shura;
                        Pamuda = amuda;
                    }
                }
            }
            Console.WriteLine("the place of the biggest number in the matriza is {0},{1}", Pshura, Pamuda);
        }
        public static void printsmallappear(int[,] a)
        {
            //טענת כניסה: קבלת מטריצה
            //טענת יציאה : הדפסת מיקום המספר הקטן במטריצה
            int min = int.MaxValue;
            int Pshura = 0;
            int Pamuda = 0;
            for (int shura = 0; shura < a.GetLength(0); shura++)
            {
                for (int amuda = 0; amuda < a.GetLength(1); amuda++)
                {
                    if (a[shura, amuda] < min)
                    {
                        min = a[shura, amuda];
                        Pshura = shura;
                        Pamuda = amuda;
                    }
                }
            }
            Console.WriteLine("the place of the smallest number in the matriza is {0},{1}", Pshura, Pamuda);
        }
        public static int big(int[,] a)
        {
            //טענת כניסה: קבלת מטריצה
            //טענת יציאה : החזרת המספר הגדול במטריצה
            int max = int.MinValue;
            for (int shura = 0; shura < a.GetLength(0); shura++)
            {
                for (int amuda = 0; amuda < a.GetLength(1); amuda++)
                {
                    if (a[shura, amuda] > max)
                    {
                        max = a[shura, amuda];
                    }
                }
            }
            return max;
        }
        public static int small(int[,] a)
        {
            //טענת כניסה: קבלת מטריצה
            //טענת יציאה : החזרת המספר הקטן במטריצה
            int min = int.MaxValue;
            for (int shura = 0; shura < a.GetLength(0); shura++)
            {
                for (int amuda = 0; amuda < a.GetLength(1); amuda++)
                {
                    if (a[shura, amuda] < min)
                    {
                        min = a[shura, amuda];
                    }
                }
            }
            return min;
        }
        public static int[] allsumsahura(int[,] a)
        {
            //טענת כניסה : קבלת מטריצה
            //טענת יציאה : מחזירה מערך חד ממדי שבו סכומי שורות המטריצה
            int[] arr = new int[a.GetLength(0)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                arr[i] = sumshura(a, i);
            }
            return arr;
        }
        public static int[] allsumsamuda(int[,] a)
        {
            //טענת כניסה : קבלת מטריצה
            //טענת יציאה : מחזירה מערך חד ממדי שבו סכומי עמודות המטריצה
            int[] arr = new int[a.GetLength(1)];
            for (int i = 0; i < a.GetLength(1); i++)
            {
                arr[i] = sumamuda(a, i);
            }
            return arr;
        }
    }
}
