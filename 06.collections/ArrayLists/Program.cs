using System;
using System.Collections;

namespace ArrayLists;
class Program
{
    static List<int> numberList = new List<int>();

    static void Main(string[] args)
    {
        // Declaring an ArrayList
        ArrayList firstArrayList = new ArrayList(); // undefined amount of object

        firstArrayList.AddRange(new[] { 23, 25.89, 15 }); // [test:{ adding many values
        firstArrayList.Add("Kevain");
        firstArrayList.Add('Ù');
        firstArrayList.Add('Ù');
        firstArrayList.Add(-89);
        firstArrayList.Add('£');

        Console.WriteLine("before deletion - Count: {0}", firstArrayList.Count);
        firstArrayList.Remove('Ù'); // delete value
        firstArrayList.RemoveAt(2); // delete using index
        Console.WriteLine("after deletion - Count: {0}\n", firstArrayList.Count);

        double sum = 0;
        foreach (object item in firstArrayList) // object is the higher type, useful if you get many differents types
        {
            if (item is int) sum += Convert.ToDouble(item);
            else if (item is double) sum += (double)item;
            else if (item is string || item is char) Console.Write(item + ", ");
        }
        Console.WriteLine("\nsum : {0}\n", sum);

        // Declaring a List - type casting is mandatory: <string>
        List<string> firstList = new List<string>();
        List<int> secondtList = new List<int>(5) { 1, 2, 3, 4, 5 }; // <type>, (amount) of values, {value}

        Solution();
    }

    // Write a method that returns a list of even integer numbers between 100 and 170 (inclusive).
    public static List<int> Solution()
    {
        for (int i = 100; i <= 170; i++)
        {
            if (i % 2 == 0) numberList.Add(i);
        }
        Console.WriteLine("Last: " + numberList.Last());
        Console.WriteLine("First: " + numberList.First());
        return numberList;
    }
}
