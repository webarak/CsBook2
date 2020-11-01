using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p._120_t_12
{
    class Program
    {
        public static int[] theonlyone(int[,] m)
        {
            //טענת כניסה : קבלת מטריצה
            //טענת יציאה : מערך חד ממדי בו כל המספרים במטריצה המופיעים בה פעם אחת
            int indexarr = 0;
            int[] arr = new int[m.GetLength(0) * m.GetLength(1)];
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if (MatrixService.sumappears(m,m[i,j]) == 1)
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
            int[] Arr = theonlyone(m);
            ArrayService.print(Arr);
        }
    }
}
