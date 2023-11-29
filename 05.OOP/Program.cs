using System;

namespace FirstClass;
class Program
{
    static void Main(string[] args)
    {
        Car audi = new Car("Audi A4", 125);
        audi.Drive();
        audi.Details();
        audi.Name = "Audi Q7 - using accessor"; // set name set acessor
        Console.WriteLine("Audi name is " + audi.Name); // get name using get acessor

        Console.WriteLine();

        Car bmw = new Car("BMW M5", 350, "mate pink");
        bmw.Drive();
        bmw.Details();

        Console.WriteLine();

        Car myCar = new Car();
        myCar.Details();
        myCar.SetName("Blablaa car");
        Console.WriteLine("this car name is : " + myCar.GetName());
        myCar.MaxSpeed = 110; // 'auto implemented property'

        Console.WriteLine("\nif you want a car to stop write down'stop'.");

        string userInput = Console.ReadLine();

        if (userInput!.Contains("stop") || userInput.Contains("Stop"))
        {
            if (userInput.Contains("bmw")
                || userInput.Contains("BMW"))
            {
                bmw.Stop();
            }
            else if (userInput.Contains("audi")
                || userInput.Contains("Audi"))
            {
                audi.Stop();
            }
        }
        else
        {
            audi.Drive();
        }
        Console.Read();
    }
}
