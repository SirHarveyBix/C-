using System;

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
        /*  Visual representation : 
                index            0   1   2   3  
        normal array type int : [15, 21, 23, 13]
        jagged array type int :
        [
            [ 2, 3, 5, 7, 11 ],
            [ 1, 2, 3 ]
        ]; */

        // decalre normal array
        int[] regularArray = new int[4] { 15, 21, 23, 13 }; // [4] indicate the maxlength of the array

        Console.WriteLine("\n\nregularArray[0] : '{0}'", regularArray[0]);

        // decalre and initialize a jagged array
        // use jagged array when complex data structure, with elements with differrents sizes
        int[][] triangle = new int[][]
        {
            new int[] { 1 },
            new int[] { 2, 3 },
            new int[] { 4, 5, 6 },
            new int[] { 7, 8, 9, 10 }
        };
        Console.WriteLine("\njagged array - for each loop: ");

        //'foreach' loops, print each row:
        foreach (int[] row in triangle)
        {
            Console.WriteLine();
            foreach (int number in row)
            {
                Console.Write(" " + number);
            }
        }

        // decalre and initialize a 2D array
        // use multi dimensional array for mathematical operation on the grid of number of same sizes
        int[,] grid = new int[,]
        {
            { 1 ,2 },
            { 2, 4 },
            { 5, 6 },
            { 7, 8 },
            { 9, 10 }
        };
        Console.WriteLine("\n\n2D array - for loop:");

        //'for' loops, print each number in the grid:
        for (int i = 0; i < grid.GetLength(0); i++)
        {
            Console.WriteLine();
            for (int j = 0; j < grid.GetLength(1); j++)
            {
                Console.Write(" " + grid[i, j]);
            }
        }
    }
}