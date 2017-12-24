using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLessonHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] car = new Car[5];
            car[0] = new Car("Toyota Camry", 2014, "White", 2.4 , "Japan");
            car[1] = new Car("Kia", 2015, "Blue", 1.4, "KOREA");
            car[2] = new Car("Mercedes", 2017, "Black", 2.6, "Germany");
            car[3] = new Car("BMW", 2015, "Grey", 4.4, "Germany");
            car[4] = new Car("Lexus", 2012, "White", 3, "Japan");

            for (int i = 0; i < car.Length; i++)
            {
                Console.WriteLine("Car["+i+"] : "+ car[i].Mark+" " +car[i].Year+" "+car[i].Color+" "+car[i].Volume+" "+car[i].Country);
            }

            Console.ReadLine();
        }
    }
}
