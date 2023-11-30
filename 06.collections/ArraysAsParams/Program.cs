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