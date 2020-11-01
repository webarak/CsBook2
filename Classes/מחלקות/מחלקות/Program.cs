using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyStudents
{
    class Program
    {
        static void Main(string[] args)
        {

            Students s1 = new Students();
            s1.SetFName("Barak Zvi Meir");
            s1.SetLName("Weisler");
            s1.SetAvg(100);

            Students s2 = new Students();
            s2.SetFName("Gili");
            s2.SetLName("tsarfati");
            s2.SetAvg(98);
            
            if (s1.GetAvg()> s2.GetAvg())
            {
                Console.WriteLine(s1.GetFirstName() + " " + s1.GetLastName());
            }
            if (s1.GetAvg() < s2.GetAvg())
            {
                Console.WriteLine(s2.GetFirstName() + " " + s2.GetLastName());
            }
            Console.WriteLine();
            s1.print();
            Console.WriteLine();
            s2.print();
            Console.WriteLine();
            
            
            
          //Students s1 = new Students();

            //s1.First_Name = "Barak";
            //s1.Last_Name = "Weisler";
            //s1.avg = 100;

            //Students s2 = new Students();
            //s2.First_Name = "Aharon";
            //s2.Last_Name = "Aharon";
            //s2.avg = 86;

            //if (s1.avg > s2.avg)
            //{
            //    Console.WriteLine(s1.First_Name+" " + s1.Last_Name);
            //}
            //if (s1.avg < s2.avg)
            //{
            //    Console.WriteLine(s2.First_Name + " " + s2.Last_Name);
            //}
            
        }
    }
}
