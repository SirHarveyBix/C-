using System;
// See https://aka.ms/new-console-template for more information

Console.OutputEncoding = System.Text.Encoding.UTF8;

// ask name in prompt
Console.Write("what's your name ? ");
string name = Console.ReadLine();

Console.Write("How old are you ? ");
// ask age in prompte throw error if string
try
{ 
    int age = Int32.Parse(Console.ReadLine());

    Console.WriteLine("Hello, " + name + " you are " + age + " year's old.");
}
catch (FormatException)
{
    Console.Write("your age is not a valid number..");
}
