namespace _2DArray_NestedLoops;

class Program
{
    static int[,] matrix =
    {
        { 1, 2, 3 },
        { 4, 5, 6 },
        { 7, 8, 9 },
        { 10, 11, 12 }
    };

    static void Main(string[] args)
    {
        Console.WriteLine("2D array: matrix - using foreach loop:");
        // foreach loop
        foreach (int key in matrix)
        {
            Console.Write(key + ", ");
        }

        Console.WriteLine("\n\n2D array: matrix - using nested for loop:");
        // Nested for loop

        // outer for loop :
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            // inner for loop :
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + ", ");
                // thnaks to th nested fo loop, adding logic is possible :
               // matrix[i, j] = 0;
            }
        }

        Console.WriteLine("\n\n'matrix.GetLength(0)' - matrix[,] has '{0}' rows ", matrix.GetLength(0));
        Console.WriteLine("'matrix.GetLength(1)' - each matrix[,] rows has '{0}' key ", matrix.GetLength(1));
    }
}
