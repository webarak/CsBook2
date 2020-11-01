using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            File f1 = new File("aharon", "doc", 520.3, "04.03.2003", true, "happy birthday to you");
            f1.print();
            File f2 = new File("gasgas", "doc", 33.7, "04.11.2003", false, "badampam");
            f2.print();
            bool b = f1.SameType(f2);
            File f3 = new File();
            if (b == true)
            {
                f1.open();
                f2.open();
                Console.WriteLine("enter name : ");
                string name = Console.ReadLine();
                f3 = new File(name, f1.Get_Type(), f1.Get_Size() + f2.Get_Size(), "05.08.2003", true, f1.Get_Content() + f2.Get_Content());
            }
            else
            {
                Console.WriteLine("the type of the files is differente");
            }
            f1.close();
            f2.close();
            f3.close();
            f1.print();
            f2.print();
            f3.print();


        }
    }
}
