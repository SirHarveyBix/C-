using System;
using System.Reflection;

namespace JaggedArrays;
class Program
{
    static void Main(string[] args)
    {
        // decalre Jagged Array
        int[][] jaggedArray = new int[3][];

        jaggedArray[0] = new int[5];
        jaggedArray[1] = new int[3];
        jaggedArray[2] = new int[2];

        jaggedArray[0] = new int[] { 2, 3, 5, 7, 11 };
        jaggedArray[1] = new int[] { 1, 2, 3 };
        jaggedArray[2] = new int[] { 13, 21 };

        // Alternative way
        int[][] jaggedArray2 = new int[][]
        {
            new int[] { 2, 3, 5, 7, 11 },
            new int[] { 1, 2, 3 }
        };

        Console.WriteLine("Value of the middle of the first entry is '{0}'\n# # # # #", jaggedArray2[0][2]);

        for (int i = 0; i < jaggedArray2.Length; i++)
        {
            Console.WriteLine("\nElement at index '{0}' :\n", i);

            for (int j = 0; j < jaggedArray2[i].Length; j++)
            {
                Console.Write("{0}, ", jaggedArray2[i][j]);
            }
        }

        //      index               0   1   2   3  
        // normal array type int : [15, 21, 23, 13]
        // jagged array type int :
        // [
        //   [ 2, 3, 5, 7, 11 ],
        //   [ 1, 2, 3 ]
        // ];

        // decalre normal array
        int[] regularArray = new int[4] { 15, 21, 23, 13 }; // [4] indicate the maxlength of the array

        Console.WriteLine("\n\nregularArray[0] : '{0}'", regularArray[0]);
    }
}