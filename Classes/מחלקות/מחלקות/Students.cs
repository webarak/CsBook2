using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyStudents
{
    class Students
    {
        //public string First_Name;
        //public string Last_Name;
        //public double avg;

        private string First_Name;
        private string Last_Name;
        private double avg;


        public void SetFName(string f)
        {
            this.First_Name = f;
        }
        public void SetLName(string l)
        {
            this.Last_Name = l;
        }
        public void SetAvg(double avg)
        {
            this.avg = avg;
        }


        public string GetFirstName()
        {
            return this.First_Name;
        }
        public string GetLastName()
        {
            return this.Last_Name;
        }
        public double GetAvg()
        {
            return this.avg;
        }

        public void print()
        {
            Console.WriteLine("First Nmae: {0}\nLast Name: {1}\nAvarage: {2}\n", this.First_Name, this.Last_Name, this.avg);
        }
    }
}
