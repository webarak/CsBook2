using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFamily
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter family name: ");
            string familyname = Console.ReadLine();
            Family F1 = new Family(familyname);
            Console.WriteLine("enter age: ");
            int age = int.Parse(Console.ReadLine());
            double income = 0;
            double sumincome = 0;
            while (age!= 0)
            {
               
                income = 0;
                if (age < 12)
                {
                    F1.Set_Children(F1.Get_Children() + 1); 
                }
                if (age >= 12 && age <= 18)
                {
                    F1.Set_Teenagers(F1.Get_Teenagers() + 1);
                }
                if (age > 18)
                {
                    F1.Set_Adults(F1.Get_Adults() + 1);
                    Console.WriteLine("enter avarge income: ");
                    income = int.Parse(Console.ReadLine());
                    sumincome = sumincome + income;
                }
                Console.WriteLine("enter age: ");
                age = int.Parse(Console.ReadLine());
            }
            F1.Set_Income(sumincome / F1.Get_Adults());
            F1.print();
            Console.WriteLine("enter avarage income for family in Israel: ");
            int avarageincomeisrael = int.Parse(Console.ReadLine());
            Console.WriteLine(F1.family_comparing_to(avarageincomeisrael));
            Console.WriteLine("the family got {0} points: ", F1.pointsback());
           
        }
    }
}
