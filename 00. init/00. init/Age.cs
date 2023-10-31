using System;
// See https://aka.ms/new-console-template for more information

namespace Age
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //// Ask for name(s)
            //string nameFirst = AskName(1);
            //string nameSecond = AskName(2);

            //// Ask for age(s)
            //int ageFirst = AskAge(nameFirst);
            //int ageSecond = AskAge(nameSecond);


            //OutputData(nameFirst, ageFirst);
            //OutputData(nameSecond, ageSecond);
            const int ASKING_TIME = 3;

            for (int i = 1; i <= ASKING_TIME; i++)
            {
                string nom = AskName(i);
                int age = AskAge(nom);
                OutputData(nom, age);
                Console.WriteLine("\n" + new String('-', 5));
            }
        }

        static void OutputData(string name, int age, float size = 0) // parametre facultatif 
        {
            Console.WriteLine();
            Console.WriteLine($"Hello, {name} you are {age} year's old.");
            Console.WriteLine($"You'll be soon {(age + 1)} !");

            bool isGrownUpEnough = age > 18;
            if (isGrownUpEnough)
            {
                Console.WriteLine("Big boy, you can drink alcool");
            }
            else if (age == 18)
            {
                Console.WriteLine("Close enough!");
            }
            else
            {
                Console.WriteLine("Oh boy, go back to your mom, don't get into trouble!");
            }

            if (size > 0)
            {
                Console.WriteLine($"You are {size}m tall!");
            }
            Console.WriteLine();
        }

        static int AskAge(string name)
        {
            int age = 0;
            while (age <= 0)
            {
                Console.Write($"{name}, How old are you ? ");
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
