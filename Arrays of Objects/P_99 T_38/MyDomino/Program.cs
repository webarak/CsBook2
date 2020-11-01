using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDomino
{
    class Program
    {
        public static bool takin(Domino[] a)
        {
            bool takin = true;
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i].Get_LowNumber() != a[i + 1].Get_TopNumber())
                {
                    takin = false;
                }
            }
            return takin;
        }
        static void Main(string[] args)
        {
            Domino[] Stones = new Domino[3];
            Random R = new Random();
            for (int i = 0; i < Stones.Length; i++)
            {
                Stones[i] = new Domino(R.Next(1,7),R.Next(1,7));
            }
            for (int i = 0; i < Stones.Length; i++)
            {
                Stones[i].print();
            }
            Console.WriteLine(takin(Stones));

        }
    }
}
