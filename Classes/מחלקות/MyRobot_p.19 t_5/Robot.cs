using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyRobot_p._19_t_5
{
    class Robot
    {
        private string color;
        private int squar;
        private bool Is_Playing;

        public Robot(string c, int s, bool p)//פעולה בונה
        {
            this.color = c;
            this.squar = s;
            this.Is_Playing = p;
        }
        
        public Robot()//פעולה בונה
        {
            this.color = null;
            this.squar = 0;
            this.Is_Playing = false;
        }

        public void placeup()
        {
            this.squar++;
        }

        public void placedown()
        {
            this.squar--;
        }

        public void placejumpup(int a)
        {
            this.squar += a;
        }

        public void placejumpdown(int a)
        {
            this.squar += a;
        }

        public void print()
        {
            Console.WriteLine("color: {0}\nsquar: {1}\nIs Playing: {2}", this.color, this.squar,this.Is_Playing);
        }

        public void set_ingame(bool a)
        {
            this.Is_Playing = a;
        }
        public int get_squar()
        {
            return this.squar;
        }
        public bool get_ingame()
        {
            return this.Is_Playing;
        }

    }
}
