using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace version1
{
    public class Task4
    {
        abstract class Vehicle
        {
            public abstract string StartEngine();
        }

        class Car : Vehicle
        {
            public override string StartEngine()
            {
                return "Car engine started";
            }
        }

        class Bicycle : Vehicle
        {
            public override string StartEngine()
            {
                return "Pedaling the bicycle";
            }
        }
        public void task4()
        {
            Vehicle car = new Car();
            Vehicle bicycle = new Bicycle();

            Console.WriteLine("Car: " + car.StartEngine());
            Console.WriteLine("Bicycle: " + bicycle.StartEngine());


        }



    }
}
