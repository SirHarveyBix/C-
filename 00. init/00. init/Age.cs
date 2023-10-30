using System;
// See https://aka.ms/new-console-template for more information

namespace Age
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Ask for name(s)
            string nameFirst = AskName(1);
            string nameSecond = AskName(2);

            // Ask for age(s)
            int ageFirst = AskAge(nameFirst);
            int ageSecond = AskAge(nameSecond);


            Console.WriteLine("Hello, " + nameFirst + " you are " + ageFirst + " year's old.");
            Console.WriteLine("You'll be soon " + (ageFirst + 1) + " !");

            Console.WriteLine();

            Console.WriteLine("Hello, " + nameSecond + " you are " + ageSecond + " year's old.");
            Console.WriteLine("You'll be soon " + (ageSecond + 1) + " !");
        }

        static int AskAge(string name)
        {
            int age = 0;
            while (age <= 0)
            {
                Console.Write(name + ", How old are you ? ");
                try
                {
                    string age_str = Console.ReadLine();
                    age = int.Parse(age_str);

                    if (age <= 0)
                    {
                        Console.WriteLine("your age is not a valid number.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("your age is not a valid number..");
                }
            }
            return age;
        }

        static string AskName(int number)
        {
            string name = "";

            while (name.Trim() == "")
            {
                // ask name in prompt
                Console.Write("what's your name ? ");
                name = Console.ReadLine().Trim();

                if (name == "")
                {
                    System.Console.WriteLine("Your name cannot be empty!");
                }
            }
            return name;
        }
    }
}
