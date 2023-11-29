using System;

namespace FirstClass
{
    internal class Car
    {
        // Member variables :
        // access modifier private
        // private field - stores data
        private string _name; // '_' naming convention for private
        private int _hp;
        private string _color;

        // Default Constructor
        public Car()
        {
            _name = "Car";
            _hp = 0;
            _color = "yellow pee";

            _Resitration();
        }

        // Partial specification Constructor
        public Car(string name, int hp = 0 /*default value*/)
        {
            _name = name;
            _hp = hp;
            _color = "random black";

            Console.WriteLine(name + " has been created.");
            _Resitration();
        }

        // Full Specification Constructor
        public Car(string name, int hp, string color)
        {
            _name = name;
            _hp = hp;
            _color = color;

            Console.WriteLine(name + " has been created.");
            _Resitration();
        }

        // public propery - Accessor
        public int MaxSpeed { get; set; }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value == "") _name = " Accessor Default Name";
                else _name = value;
            }
        }

        // setter
        public void SetName(string name)
        {
            if (name == "") _name = "Setter Default Name";
            else _name = name;
        }

        // getter
        public string GetName()
        {
            return _name;
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

        private void _Resitration()
        {
            Console.WriteLine(_name + " is registered !");
        }
    }
}
