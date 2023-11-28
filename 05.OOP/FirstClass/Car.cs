using System;

namespace FirstClass
{
    internal class Car
    {
        // Member variables : private field - stores data
        private string _name; // '_' naming convention for private
        private int _hp;
        private string _color;

        // Default Constructor
        public Car()
        {
            _name = "Car";
            _hp = 0;
            _color = "yellow pee";
        }

        // Partial specification Constructor
        public Car(string name, int hp = 0 /*default value*/)
        {
            _name = name;
            _hp = hp;
            _color = "random black";

            Console.WriteLine(name + " has been created.");
        }

        // Full Specification Constructor
        public Car(string name, int hp, string color)
        {
            _name = name;
            _hp = hp;
            _color = color;

            Console.WriteLine(name + " has been created.");
        }

        // Member methods :
        public void Drive()
        {
            Console.WriteLine(_name + " is Driving.");
        }

        public void Stop()
        {
            Console.WriteLine(_name + " Stopped.");
        }

        public void Details()
        {
            Console.WriteLine(
                "Car name is " + _name
                + " is " + _color
                + ", and has : " + _hp
                + " horse power."
            );
        }
    }
}
