using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    class Car
    {
        public readonly int maxSpeed;
        private int currSpeed;

        public Car(int max)
        {
            this.maxSpeed = max;
        }
        public Car()
        {
            maxSpeed = 55;
        }
        public int Speed
        {
            get { return currSpeed; }
            set
            {
                currSpeed = value;
                if (currSpeed > maxSpeed)
                {
                    currSpeed = maxSpeed;
                }
            }
        }
    }

    class MiniVan : Car
    {
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***** Basic Inheritance *****\n");
            //Car myCar = new Car(80);

            //myCar.Speed = 50;
            //Console.WriteLine($"My car is going {myCar.Speed} MPH");

            MiniVan myVan = new MiniVan();
            myVan.Speed = 110;
            Console.WriteLine($"My van is going {myVan.Speed} MPH");
            Console.ReadLine();
    }
    }
}
