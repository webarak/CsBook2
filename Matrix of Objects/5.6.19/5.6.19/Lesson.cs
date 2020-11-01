using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._6._19
{
    class Lesson
    {
        private string LessonName;
        private string LessonTeacher;
        private int LessonRoom;

        public Lesson(string n1, string n2, int n3)
        {
            this.LessonName = n1;
            this.LessonTeacher = n2;
            this.LessonRoom = n3;
        }
        public void Print()
        {
            Console.Write("{0,7} {1,7} {2,7}",this.LessonName, this.LessonTeacher, this.LessonRoom);
            Console.WriteLine();
        }
        public string Get_LessonTeacher()
        {
            return this.LessonTeacher;
        }
        public void Set_LessonTeacher(string n1)
        {
            this.LessonTeacher = n1;
        }
            
    }
}
