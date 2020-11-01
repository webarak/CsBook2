using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFamily
{
    class Family
    {
        private string F_Name;
        private int F_AdultsN;
        private int F_TeenagersN;
        private int F_ChildN;
        private double F_IncomeAvgM;

        public Family(string n)//פעןלה בונה
        {
            this.F_Name = n;
            this.F_AdultsN = 0;
            this.F_TeenagersN = 0;
            this.F_ChildN = 0;
            this.F_IncomeAvgM = 0;
        }
        public Family()//פעולה בונה
        {
            this.F_Name = null;
            this.F_AdultsN = 0;
            this.F_TeenagersN = 0;
            this.F_ChildN = 0;
            this.F_IncomeAvgM = 0;
        }
        public void Set_Name(string n)//Set_Family_Name
        {
            this.F_Name = n;
        }

        public void Set_Adults(int a)//Set_Adults_Number
        {
            this.F_AdultsN = a;
        }

        public void Set_Teenagers(int t)//Set_Teenagers_Number
        {
            this.F_TeenagersN = t;
        }

        public void Set_Children(int c)//Set_Children_Number
        {
            this.F_ChildN = c;
        }

        public void Set_Income(double i)//Set_Income_Avarge_Month
        {
            this.F_IncomeAvgM = i;
        }

        public string Get_Name()//Get_Name
        {
            return this.F_Name;
        }

        public int Get_Adults()//Get_Adults_Number
        {
            return this.F_AdultsN;
        }

        public int Get_Teenagers()//Get_Teenagers_Number
        {
            return this.F_TeenagersN;
        }

        public int Get_Children()//Get_Children_Number
        {
            return this.F_ChildN;
        }

        public double Get_Income()//Ger_Income_Avarage_Month
        {
            return this.F_IncomeAvgM;
        }

        public void print()//print
        {
            Console.WriteLine("Family name: {0}\nAdults number: {1}\nTeenagers number: {2}\nChildren number: {3}\nAvrage Month Income: {4}", this.F_Name, this.F_AdultsN, this.F_TeenagersN, this.F_ChildN,this.F_IncomeAvgM);
        }

        public double pointsback()//זיכוי המשפחה בנקודות
        {
            return (this.F_AdultsN + this.F_TeenagersN * 0.7 + this.F_ChildN * 0.5);
        }

        public string family_comparing_to(double avarage_income)//האם הכנסת המשפחה הינה מעל הממוצע בהכנסתה
        {
            string compare = "";
            if (avarage_income + avarage_income * 0.1 <= this.F_IncomeAvgM)
            {
                compare = "above avarage";
            }
            else if ((this.F_IncomeAvgM < avarage_income + avarage_income * 0.1) && (this.F_IncomeAvgM > avarage_income - avarage_income * 0.1))
            {
                compare = "avarage";
            }
            else
            {
                compare = "below avarage";
            }
            return compare;
        }

        public void child_to_teen()//child_to_teenager
        {
            this.F_ChildN = this.F_ChildN - 1;
            this.F_TeenagersN = this.F_TeenagersN + 1;
        }

        public void teen_to_adult()//teenager_to_adult
        {
            this.F_TeenagersN = this.F_TeenagersN - 1;
            this.F_AdultsN = this.F_AdultsN + 1;
        }
    }
}
