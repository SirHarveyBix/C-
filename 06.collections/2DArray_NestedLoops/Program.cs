using System;

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

    static string[,] board =
    {
        { "Tic", "Tac", "Toe" },
        { "Tic", "Tac", "Toe" },
        { "Tic", "Tac", "Toe" },
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

        // outter for loop :
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            // inner for loop :
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + ", ");
                // thanks to the nested for loop, adding logic is now possible
            }
        }

        Console.WriteLine("\n\n'matrix.GetLength(0)' - matrix[,] has '{0}' rows", matrix.GetLength(0));
        Console.WriteLine("'matrix.GetLength(1)' - each matrix[,] rows has '{0}' key\n", matrix.GetLength(1));

        evenNumbers();
        diagonalNumbers();
        reverseDiagonalNumbers();

        Console.WriteLine("\ncoding exercise : Tic Tac Toe winner identifier\n");
        Checker(board);
    }

    static void evenNumbers()
    {
        Console.WriteLine("\nEven numbers :");

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] % 2 == 0)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                else
                {
                    Console.Write("■ ");
                }
            }
            Console.WriteLine();
        }
    }

    static void diagonalNumbers()
    {
        Console.WriteLine("\nDiagonal numbers :");

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (i < matrix.GetLength(1)) // check if 'i' stays in limit positions
            {
                Console.WriteLine(matrix[i, i]);
            }
        }
    }

    static void reverseDiagonalNumbers()
    {
        Console.WriteLine("\nReverse Diagonal numbers :");

        for (int i = 0, j = 2; i < matrix.GetLength(0) & j >= 0; i++, j--)
        {
            Console.WriteLine(matrix[i, j]);
        }
    }

    static bool Checker(string[,] board)
    {
        // here we perform horizontal and vertical checks
        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
            {
                return true;
            }
            if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
            {
                return true;
            }
        }

        // here diagonal checks 
        if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
        {
            return true;
        }
        if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
        {
            return true;
        }
        return false;
    }
}
