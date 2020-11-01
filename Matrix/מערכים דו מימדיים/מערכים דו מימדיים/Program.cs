using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace מערכים_דו_מימדיים
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] M = new int[3, 4];
            for (int shura = 0; shura < 3; shura++)
            {
                for (int amuda = 0; amuda < 4; amuda++)
                {
                    M[shura, amuda] = 0;
                }
            }
            for (int shura = 0; shura < 3; shura++)
            {
                for (int amuda = 0; amuda < 4; amuda++)
                {
                    Console.Write(M[shura, amuda]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
