using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p._92_t_34
{
    class Program
    {
        public static void kelet(int[] a)
        {
            //טענת כניסה : קבלת מערך ריק
            //טענת יציאה : קבלת ערכים והכנסתם למערך
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("enter a number");
                a[i] = int.Parse(Console.ReadLine()); ;
            }
        }
        public static void print(int[] a)
        {
            //טענת כניסה : קבלת מערך 
            //טענת יציאה : הדפסת המערך
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + ",");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("etner how many numbers");
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            kelet(arr);
            print(arr);
            int sumneg = 0;
            int sumodd = 0;
            int indexneg = 0;
            int indexodd = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] < 0)
                {
                    sumneg++;
                }
                if ((arr[i] %2)== 0)
                {
                    sumodd++;
                }
            }
            int[] neg = new int[sumneg];
            int[] odd = new int[sumodd];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    neg[indexneg] = arr[i];
                    indexneg++;
                }
                if ((arr[i] % 2) == 0)
                {
                    odd[indexodd] = arr[i];
                    indexodd++;
                }
            }
            print(neg);
            print(odd);
        }
    }
}
