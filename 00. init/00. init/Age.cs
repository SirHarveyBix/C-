using System;
// See https://aka.ms/new-console-template for more information

namespace Age
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string name = AskName();
            int age = AskAge();

            Console.WriteLine("Hello, " + name + " you are " + age + " year's old.");
        }

        static int AskAge()
        {
            int age = 0;
            while (age <= 0)
            {
                Console.Write("How old are you ? ");
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

        static string AskName()
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
