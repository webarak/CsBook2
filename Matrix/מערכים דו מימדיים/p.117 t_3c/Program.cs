using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p._117_t_3c
{
    class Program
    {
        public static int sumaround(int[,] a)
        {
            //טענת כניסה : קבלת מטריצה+
            //טענת יציאה : סכום האיברים במסגרת של המטריצה
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i == 0 && j != 0 && j != a.GetLength(1) - 1)
                    {
                        sum += a[i, j];
                    }
                    if (i == 0 && i != 0 && i != a.GetLength(0) - 1)
                    {
                        sum += a[i, j];
                    }
                    if (i == a.GetLength(0)-1 && j != 0 && j != a.GetLength(1) - 1)
                    {
                        sum += a[i, j];
                    }
                    if (j == a.GetLength(1)-1 && i != 0 && i != a.GetLength(0) - 1)
                    {
                        sum += a[i, j];
                    }
                }
            }
            sum += a[0,a.GetLength(1)-1];
            sum += a[0,0];
            sum += a[a.GetLength(0)-1,0];
            sum += a[a.GetLength(0)-1,a.GetLength(1)-1];
            return sum;
        }
        static void Main(string[] args)
        {
            int[,] m = new int[3, 3];
            MatrixService.kelet(m);
            MatrixService.print(m);
            Console.WriteLine(sumaround(m));


        }
    }
}
