using System;

namespace FirstClass
{
    internal class Car
    {
        public Car(string brand) // Constructor
        {
            Console.WriteLine(brand + " has been created.");

        }

        public void Drive()
        {
            Console.WriteLine("Car is Driving.");
        }

        public void Stop()
        {
            Console.WriteLine("Car Stopped.");
        }
    }
}
