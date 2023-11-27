using System;

namespace Switches;
class Program
{
    static void Main(string[] args)
    {
        int age = 24;

        switch (age)
        {
            case 15:
                Console.WriteLine("Too Young to party in clubs");
                break;

            case 25:
                Console.WriteLine("Good to go !");
                break;

            default:
                Console.WriteLine("default case in common switch");
                break;
        };

        if (age == 15)
        {
            Console.WriteLine("Too Young to party in clubs");

        }
        else if (age == 25)
        {
            Console.WriteLine("Good to go !");
        }
        else
        {
            Console.WriteLine("default case in common if else statement");

        }

        string username = "Denis";

        switch (username)
        {
            case "Denis":
                Console.WriteLine("username is Denis.");
                break;
            case "root":
                Console.WriteLine("Hello root user !");
                break;
            default:
                Console.WriteLine("unknown, wtf are you ?");
                break;
        }
    }
}
