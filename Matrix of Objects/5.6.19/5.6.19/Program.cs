using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._6._19
{
    class Program
    {
        public static void LessonsInDay(Lesson[,] a, int day)//פעולה המקבלת מערך שיעורים ומספר יום ומדפיסה את פרטי כל השיעורים שבאותו היום
        {
            for (int i = 1; i < a.GetLength(0); i++)
            {
                a[i, day].Print();
            }
        }
        public static void all_lessons_of_teacher(Lesson[,] a, string name)//פעולה המקבלת מערך שיעורים ושם מורה ומדפיסה את מיקומי השיעורים שלו
        {
            for (int i = 1; i < a.GetLength(0); i++)
            {
                for (int j = 1; j < a.GetLength(1); j++)
                {
                    if (name == a[i, j].Get_LessonTeacher())
                    {
                        Console.WriteLine(i+","+j);
                    }
                }
            }
        }
        public static void change_teacher(Lesson[,] a, string n1, string n2)
        {

        }
        static void Main(string[] args)
        {
            Lesson[,] Maarecet = new Lesson[5, 7];
            Maarecet[1, 1] = new Lesson("math", "hanit", 121);
            Maarecet[2, 1] = new Lesson("math", "hanit", 121);
            Maarecet[3, 1] = new Lesson("history", "iris", 125);
            Maarecet[4, 1] = new Lesson("bible", "orit", 126);

            Maarecet[1, 2] = new Lesson("heb", "raheli", 131);
            Maarecet[2, 2] = new Lesson("english", "lena", 124);
            Maarecet[3, 2] = new Lesson("english", "lena", 131);
            Maarecet[4, 2] = new Lesson("history", "iris", 121);

            Maarecet[1, 3] = new Lesson("math", "hanit", 119);
            Maarecet[2, 3] = new Lesson("bible", "orit", 125);
            Maarecet[3, 3] = new Lesson("sport", "elad", 11);
            Maarecet[4, 3] = new Lesson("geo", "neta", 198);

            Maarecet[1, 4] = new Lesson("english", "lena", 131);
            Maarecet[2, 4] = new Lesson("math", "hanit", 123);
            Maarecet[3, 4] = new Lesson("sport", "elad", 11);
            Maarecet[4, 4] = new Lesson("psy", "marzok", 109);

            Maarecet[1, 5] = new Lesson("psy", "marzok", 109);
            Maarecet[2, 5] = new Lesson("math", "hanit", 121);
            Maarecet[3, 5] = new Lesson("madmach", "amira", 103);
            Maarecet[4, 5] = new Lesson("madmach", "amira", 105);

            Maarecet[1, 6] = new Lesson("english", "lena", 121);
            Maarecet[2, 6] = new Lesson("bible", "orit", 125);
            Maarecet[3, 6] = new Lesson("heb", "raheli", 131);
            Maarecet[4, 6] = new Lesson("heb", "raheli", 131);


            //for (int i = 1; i < Maarecet.GetLength(0); i++)
            //{
            //    for (int j = 1; j < Maarecet.GetLength(1); j++)
            //    {
            //        Console.WriteLine(i+" "+j);
            //        Console.WriteLine("enter lesson name:");
            //        string n1 = Console.ReadLine();
            //        Console.WriteLine("enter teacher name:");
            //        string n2 = Console.ReadLine();
            //        Console.WriteLine("enter number room's lesson:");
            //        int n3 = int.Parse(Console.ReadLine());
            //        Maarecet[i, j] = new Lesson(n1, n2, n3);
            //    }
            //}
            //for (int i = 1; i < Maarecet.GetLength(1); i++)
            //{
            //    for (int j = 1; j < Maarecet.GetLength(0); j++)
            //    {
            //        Maarecet[j, i].Print();
                    
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}
            LessonsInDay(Maarecet, 1);
            all_lessons_of_teacher(Maarecet, "raheli");
        }
    }
}
