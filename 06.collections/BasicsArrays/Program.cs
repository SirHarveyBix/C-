using System;

namespace BasicsArrays;
class Program
{
    static void Main(string[] args)
    {
        int[] grades = new int[5];

        grades[0] = 20;
        grades[1] = 50;

        Console.WriteLine("grade at index 0 '[0]' : {0}\n", grades[0]);

        Console.WriteLine("write a number");
        string input = Console.ReadLine();

        grades[1] = int.Parse(input);
        Console.WriteLine("grade at index 1 '[1]' : {0}\n", grades[1]);

        int[] gradeStudentA = { 20, 13, 18, 19, 2 };
        int[] gradeStudentB = new int[] { 15, 6, 8, 19, 20 };

        Console.WriteLine("gradeStudentB.Length" + gradeStudentB.Length);
    }
}
