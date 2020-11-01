using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace מחרוזות
{
    class Program
    {
        public static string upsidedown(string str)
        {
            //טענת כניסה : קבלת מחרוזת
            //טענת יציאה : מחרוזת הפוכה
            string str2 = "";
            for (int i = str.Length-1; i >=0; i--)
            {
                str2 = str2+str[i];
            }
            return str2;

        }
        public static bool polindrom(string str)
        {
            //טענת כניסה : קבלת מחרוזת
            //טענת יציאה : האם המחרוזת פולינדרום?
            bool pol = true;
            {
                for (int i = 0; i < str.Length/2; i++)
                {
                    if (str[i]!=str[str.Length-i-1])
                    {
                        pol = false;
                    }
                }
            }
            return pol;

        }
        public static string longest(string[]a)
        {
            //טענת כניסה : מערך מחרוזות
            //טענת יציאה : המחרוזת הארוכה ביותר
            string bigest = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Length > bigest.Length)
                {
                    bigest = a[i];
                }
            }
            return bigest;
        }
        public static string sentence(string[] a)
        {
            //טענת כניסה : מערך מחרוזות
            //טענת יציאה : משפט שלם מכל איברי המערך
            string sentence = "";
            for (int i = 0; i < a.Length; i++)
            {
                sentence =sentence + a[i] + " ";
            }
            return sentence; 
        }
        static void Main(string[] args)
        {
            //string st = "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z";
            //Console.WriteLine(upsidedown(st));

            //string st1 = "acba";
            //Console.WriteLine(polindrom(st1));

            string[] srr = { "happy", "holiday", "to", "the", "world" };
            Console.WriteLine(longest(srr));
            Console.WriteLine(sentence(srr));
        }

    }
}
