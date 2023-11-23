using System;

namespace IfElseTry;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("what temperature is it outisde ?");

        string temperature = Console.ReadLine();
        int temperatureInt = int.Parse(temperature);

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

