using System;

namespace ArraysAsParams;
class Program
{
    static void Main(string[] args)
    {
        string hash = "\n# # # # # #\n";
        int[] sutendsGrades = new int[] { 15, 13, 8, 12, 6, 16 };
        double averageResult = GetAverage(sutendsGrades);

        foreach (int grade in sutendsGrades) { Console.Write("{0}, ", grade); }
        Console.WriteLine("\nAverage is : {0}\n", averageResult);

        int[] happiness = { 2, 3, 4, 5, 6 };
        SunIsShining(happiness);
        foreach (int y in happiness) { Console.WriteLine(y); }

        Console.WriteLine(hash);
        ParamsMethod("this", "is", "a", "long", "string", "blah", "bla", "and", "END!");
        Console.WriteLine(hash);

        int price = 50;
        float pi = 3.14f;
        string book = "Lord of the ring.";

        // 'params' keyword, with 'object[]' type,
        // allow to pass as many params, and any type we want.
        ParamsMethodStuff(price, pi, '@', book);
        ParamsMethodStuff("Hello", 5.3, '£');
        Console.WriteLine(hash);

        Console.WriteLine("Average: " + Average(1, 2, 87, 1, 666, 12, 54));
    }

    public static double Average(/*int num,*/ params int[] numbers) // using params impact performance
    {
        int total = 0;
        int count = 0;

        foreach (int number in numbers)
        {
            total += number;
            count++;
        }
        return (double)total / count;
    }

    public static void ParamsMethod(params string[] sentence) // 'params': as many params as we want
    {
        for (int i = 0; i < sentence.Length; i++) { Console.Write(sentence[i] + " "); }
    }

    public static void ParamsMethodStuff(params object[] stuff)
    {
        foreach (object thing in stuff) { Console.Write(thing + " "); }
        Console.WriteLine("\n# # # # # #\n");
    }

    static double GetAverage(int[] gradesArray)
    {
        int size = gradesArray.Length;
        int sum = 0;

        for (int i = 0; i < size; i++)
        {
            sum += gradesArray[i];
        }
        return (double)sum / size;
    }

    static void SunIsShining(int[] happiness) { for (int i = 0; i < happiness.Length; i++) { happiness[i] += 2; } }
}