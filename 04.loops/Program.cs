using System;

namespace BasicLoops;
class Program
{
    static void Main(string[] args)
    {
        // - - - - FOR LOOP - - - -

        Console.WriteLine(" - - for loop - - \n");

        for (int counter = 0; counter < 50; counter += 5)
        {
            Console.WriteLine(counter + "is lower than 50");
        }

        // - - - - DO WHILE LOOP - - - -

        Console.WriteLine("\n - - do while loop - - \n");

        int lengthOfText = 0;
        string wholeText = "";

        do
        {
            Console.WriteLine("Please, enter the name of a friend");
            string friendName = Console.ReadLine();

            lengthOfText += friendName!.Length;
            wholeText += friendName;

        } while (lengthOfText < 20);

        Console.WriteLine("Thanks, that was enough {0}.", wholeText);

        // - - - - WHILE LOOP - - - -

        Console.WriteLine("\n - - while loop - - \n");

        int whileCounter = 0;
        string enteredText = "";

        while (enteredText.Equals(""))
        {
            Console.WriteLine("Please press enter to increase by one" + " then type any letter to stop");
            enteredText = Console.ReadLine();

            whileCounter++;
            Console.WriteLine("you typed {0} time enter till now",whileCounter);
        }

        Console.WriteLine("you type = {0} time enter, there is no highscore ...", whileCounter);
    }
}
