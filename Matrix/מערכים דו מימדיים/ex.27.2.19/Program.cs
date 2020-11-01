using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex._27._2._19
{
    class Program
    {
    public static int[] appearones(int[,] m)
        {
            //טענת כניסה : קבלת מטריצה
            //טענת יציאה : מערך חד ממדי בו המספרים של המטריצה עם מופע אחד בלבד
            int indexarr = 0;
            int[] arr = new int[m.GetLength(0) * m.GetLength(1)];
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if (ArrayService.appear(arr, m[i, j]) == false)
                    {
                        arr[indexarr] = m[i, j];
                        indexarr++;
                    }
                }
            }
            return arr;
        }
        static void Main(string[] args)
        {
            int[,] m = new int[3, 3];
            MatrixService.kelet(m);
            int[] Arr = appearones (m);
            ArrayService.print(Arr);
        }
    }
}
