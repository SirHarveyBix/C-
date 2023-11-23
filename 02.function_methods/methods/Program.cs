using System;

namespace methods;

class Program
{
    static void Main(string[] args)
    {
        WriteSomething();

        WriteSomethidSpecific("lol\n");

        Console.WriteLine(Add(1, 2));
        Console.WriteLine(Add(Add(1, 2), Add(1, 2)));

        Console.WriteLine(Multiply(4, 2));
        Console.WriteLine(Divide(4, 2));

        string friend1 = "Franck";
        string friend2 = "Michael";
        string friend3 = "Wlad";

        GreetFriend(friend1);
        GreetFriend(friend2);
        GreetFriend(friend3);

        string inputChallenge = "lol";
        Console.WriteLine(LowUpper(inputChallenge));
        Count(inputChallenge);

        Console.WriteLine("\n # # # # # #\n");

        Console.WriteLine("Result: " + Calculate());
    }

    // access modifier [static], return type [void], method name, parameter (type name).
    public static void WriteSomething()
    {
        Console.WriteLine("Inside a method.\n");
    }

    public static void GreetFriend(string friendName)
    {
        Console.WriteLine("Hi " + friendName + ", my friend !");
    }

    public static void WriteSomethidSpecific(string text)
    {
        Console.WriteLine("arg : " + text);
    }

    public static int Add(int number1, int number2)
    {
        return number1 + number2;
    }

    public static int Multiply(int number1, int number2)
    {
        return number1 * number2;
    }

    public static double Divide(double number1, double number2)
    {
        return number1 / number2;
    }

    /*"lol" string will produse "lolLOL".*/
    public static string LowUpper(string input)
    {
        return input.ToLower() + input.ToUpper();
    }

    /*"lol" string will print "The amount of characters is 3.".*/
    public static void Count(string input)
    {
        Console.WriteLine("The amount of characters is {0}.", input.Length);
    }

    public static int Calculate()
    {
        Console.WriteLine("Please enter a first number");
        string firstNumber = Console.ReadLine();

        Console.WriteLine("Please enter a second number");
        string secondNumber = Console.ReadLine();

        int number1 = int.Parse(firstNumber);
        int number2 = int.Parse(secondNumber);

        int result = number1 + number2;
        return result;
    }

}
