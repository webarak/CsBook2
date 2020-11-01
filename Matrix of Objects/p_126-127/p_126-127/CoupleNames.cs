using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p_126_127
{
    class CoupleNames
    {
        private string name1;
        private string name2;
        public CoupleNames(string n1, string n2)
        {
            this.name1 = n1;
            this.name2 = n2;
        }
        public void Print()
        {
            Console.WriteLine("name 1: {0}, name 2:{1}", this.name1, this.name2);
        }
        public void Set_Name1(string n1)
        {
            this.name1 = n1;
        }
        public void Set_Name2(string n2)
        {
            this.name2 = n2;
        }
        public string Get_Name1()
        {
            return this.name1;
        }
        public string Get_Name2()
        {
            return this.name2;
        }

        public int Number_Of_Pupiles()
        {
            int count = 0;
            if (this.name1 != "")
            {
                count++;
            }
            if (this.name2 != "")
            {
                count++;
            }
            return count;
        }

    }
}
