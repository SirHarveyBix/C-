using System;
// See https://aka.ms/new-console-template for more information

System.Console.WriteLine("TEST");

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("what's your name ?");

string name = Console.ReadLine();

Console.WriteLine("Hello, I am " + name);
Console.WriteLine(name + " is my name !");
