using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Random R = new Random();
            Point p1 = new Point(R.Next(-10, 11), R.Next(-10, 11));
            Point p2 = new Point(R.Next(-10, 11), R.Next(-10, 11));
            Point p3 = new Point(((p1.GetX() + p2.GetX()) / 2), ((p1.GetY() + p2.GetY()) / 2));
            p1.print();
            p2.print();
            p3.print();
            double distance = Math.Sqrt((Math.Pow((p1.GetX() - p2.GetX()),2) + Math.Pow((p1.GetY() - p2.GetY()),2)));
            Console.WriteLine(distance);
        }
    }
}
