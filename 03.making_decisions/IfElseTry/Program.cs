using System;

namespace IfElseTry;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("what temperature is it outisde ?");
        string temperature = Console.ReadLine();

        int temperatureInt;
        int number;

        bool isNumberInput = int.TryParse(temperature, out number);

        if (isNumberInput)
        {
            temperatureInt = number;
        }
        else
        {
            temperatureInt = 0;
            Console.WriteLine("Entered value is not a number, 0 set as temperature");
        }

        if (temperatureInt < 20)
        {
            Console.WriteLine("Take the coat");
        }
        else if (temperatureInt == 20)
        {
            Console.WriteLine("Pants and Pull Over are fine");
        }
        else if (temperatureInt > 30)
        {
            Console.WriteLine("Supa dupa hot!");
        }
        else
        {
            Console.WriteLine("you'll be a better judge than a stupid program");
        }
    }
}
