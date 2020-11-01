using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace פעולות_מיוחדות_במחרוזות
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abracadabra";
            int index = str.IndexOf('a');//המופע הראשון של התו המבוקש
            int index2 = str.LastIndexOf('a');//המופע האחרון של התו המבוקש
            Console.WriteLine(index);
        }
    }
}
