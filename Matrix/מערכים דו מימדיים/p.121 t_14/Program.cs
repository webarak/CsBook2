using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p._121_t_14
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
        static void Main(string[] args)
        {
            int[,] discs = new int[5, 6];
            random(discs);
            MatrixService.print(discs);
            int[] bestseller = MatrixService.allsumsamuda(discs);
            int bestseller1 = ArrayService.bigestplace(bestseller);
            Console.WriteLine("the bestseller disc is {0} disc", bestseller1+1);
            int[] alldiscs = MatrixService.allsumsahura(discs);
            int sumalldiscs = ArrayService.numberofappearence(alldiscs, 6);
            Console.WriteLine("{0} teenagers have all the discs", sumalldiscs);
            Console.WriteLine("the avarage discs that every  teenager has is {0}", ArrayService.avg(alldiscs));
            

        }
    }
}
