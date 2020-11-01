using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFile
{
    class File
    {
        private string F_Name;
        private string F_Type;
        private double F_Size;
        private string F_Date_Born;
        private bool F_Open;
        private string F_Content;

        public File(string n, string t, double s, string d, bool o, string c)//פעולה בונה
        {
            this.F_Name = n;
            this.F_Type = t;
            this.F_Size = s;
            this.F_Date_Born = d;
            this.F_Open = o;
            this.F_Content = c;
        }
        
        public File()//פעולה בונה
        {
            this.F_Name = null;
            this.F_Type = null;
            this.F_Size = 0;
            this.F_Date_Born = null;
            this.F_Open = false;
            this.F_Content = null;
        }
        public void open()//לפתוח
        {
            this.F_Open = true;
        }

        public void close()//לסגור
        {
            this.F_Open = false;
        }

        public void Set_Name(string n)//set_name
        {
            this.F_Name = n;
        }

        public void Set_Type(string t)//set_type
        {
            this.F_Type = t;
        }

        public void Set_Size(double s)//set_size
        {
            this.F_Size = s;
        }

        public void Set_Date_Born(string d)//set_date_born
        {
            this.F_Date_Born = d;
        }

        public void Set_Open(bool o)//set_open
        {
            this.F_Open = o;
        }

        public void Set_Content(string c)//set_content
        {
            this.F_Content = c;
        }

        public string Get_Name()//get_name
        {
            return this.F_Name;
        }

        public string Get_Type()//get_type
        {
            return this.F_Type;
        }

        public double Get_Size()//gey_size
        {
            return this.F_Size;
        }

        public string Get_Date_Born()//get_date_born
        {
            return this.F_Date_Born;
        }

        public bool Get_Open()//get_open
        {
            return this.F_Open;
        }

        public string Get_Content()//get_content
        {
            return this.F_Content;
        }

        public bool SameType(File f)
        {
            return this.F_Type == f.F_Type;
        }

        public void print()
        {
            Console.WriteLine("Name: {0}\nType: {1}\nSize: {2}\nDate Born: {3}\nOpen?: {4}\nContent: {5}\n", this.F_Name, this.F_Type, this.F_Size, this.F_Date_Born, this.F_Open, this.F_Content);
        }
    }
}
