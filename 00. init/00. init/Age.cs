using System;
// See https://aka.ms/new-console-template for more information

namespace Age
{
    class Program
    {
        static int AskAge()
        {
            int age = 0;
            while (age <= 0)
            {
                Console.Write("How old are you ? ");
                try
                {
                    string ag_str = Console.ReadLine();
                    age = int.Parse(ag_str);

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

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string name = "";

            while (name.Trim() == "")
            {
                // ask name in prompt
                Console.Write("what's your name ? ");
                name = Console.ReadLine().Trim();
                name = name.Trim();

                if (name.Trim() == "")
                {
                    System.Console.WriteLine("Your name cannot be empty!");
                }
            }
            int age = AskAge();

            Console.WriteLine("Hello, " + name + " you are " + age + " year's old.");
        }
    }
}
