using System;
// See https://aka.ms/new-console-template for more information

Console.OutputEncoding = System.Text.Encoding.UTF8;

// ask name in prompt
Console.Write("what's your name ? ");
string name = Console.ReadLine();

bool isValidAge = false;

while (!isValidAge)
{
Console.Write("How old are you ? ");
// ask age in prompte throw error if string
int age = 0;

    try
    {
        age = int.Parse(Console.ReadLine());
        isValidAge = true;
        Console.WriteLine("Hello, " + name + " you are " + age + " year's old.");
    }
    catch (FormatException)
    {
        Console.WriteLine("your age is not a valid number..");
    }
}
