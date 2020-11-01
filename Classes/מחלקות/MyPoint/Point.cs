using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPoint
{
    class Point
    {
        private double x;
        private double y;
        public Point(double x, double y)//פעולה בונה
        {
            this.x = x;
            this.y = y;
        }
        public Point()//פעולה בונה
        {
            this.x = 0;
            this.y = 0;
        }
        public void SetX(double x)//set
        {
            this.x = x;
        }
        public void SetY(double y)//set
        {
            this.y = y;
        }
        public double GetX()//get
        {
            return this.x;
        }
        public double GetY()//get
        {
            return this.y;
        }
        public void print()//print
        {
            Console.WriteLine("X={0} Y={1}", this.x, this.y);
        }
    }
}
