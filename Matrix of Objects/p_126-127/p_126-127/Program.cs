using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p_126_127
{
    class Program
    {
        public static int Number_of_pupils_in_class(CoupleNames[,] a)//פעולה הסוכמת כמה תלמידים יש בכיתה
        {
            int counter = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    counter = counter + a[i, j].Number_Of_Pupiles();
                }
            }
            return counter;
        }
        public static int place_of_pupil(CoupleNames [,] a, string n1)
        {
            int row = -1;
            int colum = -1;
            for (int i = 0; i<a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j].Get_Name1() == n1)
                    {
                        row = i;
                        colum = j;
                    }
                    if (a[i, j].Get_Name2() == n1)
                    {
                        row = i;
                        colum = j;
                    }
                }
            }
            int place = colum * 10 + row;
            return place;
            
            
        }
        static void Main(string[] args)
        {
            CoupleNames[,] tables = new CoupleNames[2,2];
            for (int i = 0; i < tables.GetLength(0); i++)
            {
                for (int j = 0; j < tables.GetLength(1); j++)
                {
                    Console.WriteLine("enter first pupil");
                    string n1 = Console.ReadLine();
                    Console.WriteLine("enter second pupil");
                    string n2 = Console.ReadLine();
                    tables[i, j] = new CoupleNames(n1, n2);
                }
            }
            Console.WriteLine(Number_of_pupils_in_class(tables));
            int place = place_of_pupil(tables,"barak");
            Console.WriteLine("colum: {0}, row:{1}", (place/10), (place%10));
        }
    }
}
