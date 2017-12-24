using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLessonHW
{
    public class Car
    {
        private string mark;
        private int year;
        private string color;
        private double volume;
        private string country;

        private static int count;

        public Car()
        {
            mark = " ";
            year = 0;
            color = " ";
            volume = 0;
            country = " ";
        }

        public Car(string mark, int year, string color, double volume,string country)
        {
            this.mark = mark;
            this.year = year;
            this.color = color;
            this.volume = volume;
            this.country = country;
        }

        static Car()
        {
            count = 0;
        }

        public string Mark
        {
            get { return mark; }
            set { mark = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public double Volume
        {
            get { return volume; }
            set { volume = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

       
    }
}
