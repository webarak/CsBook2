using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyRobot_p._19_t_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random R = new Random();
            Robot blue = new Robot("blue", 10, true);
            Robot red = new Robot("red", 10, true);
            int blueturn;
            int redturn;
            while (blue.get_ingame()==true && red.get_ingame()==true)
            {
                blueturn = R.Next(1, 5);
                if (blueturn == 1)
                {
                    blue.placejumpup(R.Next(1, 7));
                }
                if (blueturn == 2)
                {
                    blue.placejumpdown(R.Next(1, 7));
                }
                if (blueturn == 3)
                {
                    blue.placedown();
                }
                if (blueturn == 4)
                {
                    blue.placeup();
                }
                if (blue.get_squar() == 100)
                {
                    red.set_ingame(false);
                    Console.WriteLine("blue won");
                    blue.print();
                    Console.WriteLine();
                }
                if (blue.get_squar() > 100 || blue.get_squar() < 1)
                {
                    blue.set_ingame(false);
                    Console.WriteLine("red won");
                    red.print();
                    Console.WriteLine();
                }
                if (blue.get_squar() == red.get_squar())
                {
                    red.set_ingame(false);
                    Console.WriteLine("blue won");
                    blue.print();
                    Console.WriteLine();
                }
                if (blue.get_ingame() == true && red.get_ingame() == true)
                {
                    Console.WriteLine();
                    blue.print();
                    Console.WriteLine();
                    red.print();
                    Console.WriteLine("******************************");
                }
                if (red.get_ingame() != false)
                {
                    redturn = R.Next(1, 5);
                    if (redturn == 1)
                    {
                        red.placejumpup(R.Next(1, 7));
                    }
                    if (redturn == 2)
                    {
                        red.placejumpdown(R.Next(1, 7));
                    }
                    if (redturn == 3)
                    {
                        red.placedown();
                    }
                    if (redturn == 4)
                    {
                        red.placeup();
                    }
                    if (red.get_squar() == 100)
                    {
                        blue.set_ingame(false);
                        Console.WriteLine("red won");
                        red.print();
                        Console.WriteLine();
                    }
                    if (red.get_squar() > 100 || red.get_squar() < 1)
                    {
                        red.set_ingame(false);
                        Console.WriteLine("blue won");
                        blue.print();
                        Console.WriteLine();
                    }
                    if (red.get_squar() == blue.get_squar())
                    {
                        blue.set_ingame(false);
                        Console.WriteLine("red won");
                        red.print();
                        Console.WriteLine();
                    }
                    if (blue.get_ingame() == true && red.get_ingame() == true)
                    {
                        Console.WriteLine();
                        blue.print();
                        Console.WriteLine();
                        red.print();
                        Console.WriteLine("*******************");
                    }
                }
            }
        }
    }
}
