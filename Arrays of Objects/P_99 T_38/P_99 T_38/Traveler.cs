using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P_99_T_38
{
    class Traveler
    {
        private string name;
        private double age;
        private double numberofyears;

        public Traveler(string n, double a, double num)
        {
            this.name = n;
            this.age = a;
            this.numberofyears = num;
        }

        public string Get_Name()
        {
            return this.name;
        }

        public double Get_Age()
        {
            return this.age;
        }

        public double Get_NumberOfYears()
        {
            return this.numberofyears;
        }

        public void print()
        {
            Console.WriteLine(this.name);
            Console.WriteLine(this.age);
            Console.WriteLine(this.numberofyears);
        }

    }
}
