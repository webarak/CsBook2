using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P_99_T_38
{
    class Program
    {
        static void Main(string[] args)
        {
            Traveler[] Arr = new Traveler[5];
            Arr[0] = new Traveler("Barak Weisler", 16, 5);
            Arr[1] = new Traveler("Shahar Vaalani", 5, 0.5);
            Arr[2] = new Traveler("Arad Hadad", 14, 1);
            Arr[3] = new Traveler("Gilai Zefania", 21, 1.5);
            Arr[4] = new Traveler("Roei Shohat", 94.5, 83);
            int place = -1;
            double age = double.MaxValue;
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i].Get_Age() < age)
                {
                    place = i;
                    age = Arr[i].Get_Age();
                }
            }
            Console.WriteLine(Arr[place].Get_Name()+"\n"+ Arr[place].Get_Age());
            
            int count = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i].Get_NumberOfYears() >= Arr[i].Get_Age() / 2)
                {
                    count++;
                }
            }
            Console.WriteLine(count);

            int counter = 0;
            double avarage = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i].Get_NumberOfYears() < 3)
                {
                    counter++;
                    avarage += Arr[i].Get_Age();
                }
            }
            Console.WriteLine(avarage/counter);
        }
    }
}
