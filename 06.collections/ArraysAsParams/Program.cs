using System;

namespace ArraysAsParams;
class Program
{
    static void Main(string[] args)
    {
        int[] sutendsGrades = new int[] { 15, 13, 8, 12, 6, 16 };
        double averageResult = GetAverage(sutendsGrades);

        foreach (int grade in sutendsGrades)
        {
            Console.Write("{0}, ", grade);
        }
        Console.WriteLine("\nAverage is : {0}", averageResult);

        int[] happiness = { 2, 3, 4, 5, 6 };
        SunIsShining(happiness);
        foreach (int y in happiness) { Console.WriteLine(y); }

        Console.WriteLine("\n # # # # # # \n");

        ParamsMethod("this", "is", "a", "long", "string", "blah", "bla", "and", "END!");

        Console.WriteLine("\n # # # # # # \n");

        int price = 50;
        float pi = 3.14f;
        char at = '@';
        string book = "Lord of the ring.";

        // 'params' keyword, with 'object[]' type,
        // allow to pass as many params, and any type we want.

        ParamsMethodStuff(price, pi, at, book);
        ParamsMethodStuff("Hello", 5.3, '£');
    }

    public static void ParamsMethod(params string[] sentence) // 'params': as many params as we want
    {
        for (int i = 0; i < sentence.Length; i++) { Console.Write(sentence[i] + " "); }
    }

    public static void ParamsMethodStuff(params object[] stuff)
    {
        foreach (object thing in stuff) { Console.Write(thing + " "); }
        Console.WriteLine("\n# # # #\n");
    }


    static double GetAverage(int[] gradesArray)
    {
        int size = gradesArray.Length;
        double average;
        int sum = 0;

        for (int i = 0; i < size; i++)
        {
            sum += gradesArray[i];
        }

        average = (double)sum / size;
        return average;
    }

    static void SunIsShining(int[] x) { for (int i = 0; i < x.Length; i++) { x[i] += 2; } }
}