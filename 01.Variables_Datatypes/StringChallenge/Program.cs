using System;

namespace StringChallenge;
class Program
{
    static void Main(string[] args)
    {
        /* - - - - - First Execrice - - - - - */

        string myName;

        Console.WriteLine("Please enter your name, and press enter: ");

        myName = Console.ReadLine();
        string myNameUpperCase = String.Format("Upper case : {0}", myName.ToUpper());
        string myNameLowerCase = String.Format("Lower case : {0}", myName.ToLower());
        string myNameTrimmed = String.Format("Trimmed value : {0}", myName.Trim()); // get rid of spaces around
        string myNameSubstring = String.Format("Substring value : {0}", myName.Substring(0, myName.Length < 5 ? myName.Length : 5)); // if string length is under 5 it uses the full size of the string, otherwise, it uses 5

        Console.WriteLine(myNameUpperCase);
        Console.WriteLine(myNameLowerCase);
        Console.WriteLine(myNameTrimmed);
        Console.WriteLine(myNameSubstring);

        /* - - - - - Second Execrice - - - - - */

        Console.WriteLine("\nEnter a string here: ");
        string input = Console.ReadLine();


        Console.WriteLine("\nEnter a charcter to search: ");
        char searchInput = Console.ReadLine()[0];

        int searchIndex = input.IndexOf(searchInput);

        Console.WriteLine("Index of Charchter {0} in string is {1}", searchInput, searchIndex);

        /* - - - - - Third Execrice - - - - - */

        Console.WriteLine("\nEnter first name: ");
        string firstName = Console.ReadLine().Trim();

        Console.WriteLine("\nEnter last name: ");
        string lastName = Console.ReadLine().Trim();

        string fullname = string.Concat(firstName, " ", lastName);
        Console.WriteLine($"\nYour full name is {fullname}");
    }
}

