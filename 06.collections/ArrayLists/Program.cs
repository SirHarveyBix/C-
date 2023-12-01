using System;
using System.Collections;

namespace ArrayLists;
class Program
{
    static void Main(string[] args)
    {
        // Declaring an ArrayList
        ArrayList firstArrayList = new ArrayList(); // undefined amount of object
        ArrayList secondArrayList = new ArrayList(100); // '100' is amount of object whithin the ArrayList

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
    }
}
