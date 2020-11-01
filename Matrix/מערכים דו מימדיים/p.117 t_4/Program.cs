using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p._117_t_4
{
    class Program
    {
        public static bool kesemcube(int[,] a)
        {
            bool kesem = false;
            int[] arr = MatrixService.allsumsahura(a);
            int[] brr = MatrixService.allsumsamuda(a);
            bool appeararr = ArrayService.samenum(arr);
            bool appearbrr = ArrayService.samenum(brr);
            int alacsonR = MatrixService.sumalacsonR(a);
            int alacsonM = MatrixService.sumalacsonM(a);
            if (appeararr == true && true == appearbrr)
            {
                if (alacsonR == arr[0]  && alacsonM == arr[0] && arr[0]==brr[0])
                {
                    kesem = true;
                }
            }
            return kesem;
        }
        static void Main(string[] args)
        {
            
            int[,] m = new int[3, 3];
            MatrixService.kelet(m);
            MatrixService.print(m);

            Console.WriteLine(kesemcube(m));
        }
    }
}
