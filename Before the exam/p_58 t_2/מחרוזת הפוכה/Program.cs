using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace מחרוזת_הפוכה
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abcdefg";
            char temp;
            string newstr = "";
            for (int i = str.Length-1; i>=0 ; i--)
            {
                newstr += str[i];
            }
            Console.WriteLine(newstr);
        }
    }
}
