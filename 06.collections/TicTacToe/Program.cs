using System;

namespace TicTacToe;
class Program
{
    static char[,] playField =
    {
         { '1','2','3' }, // row 0
         { '4','5','6' }, // row 1
         { '7','8','9' }  // row 2
    };

    static void Main(string[] args)
    {
        int player = 2;
        int input = 0;
        bool inputCorrect = true;

        SetField();
    }

    public static void SetField()
    {

        Console.Clear();
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", playField[0, 0], playField[0, 1], playField[0, 2]);
        Console.WriteLine("_____|_____|_____");
        Console.WriteLine("     |     |     ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", playField[1, 0], playField[1, 1], playField[1, 2]);
        Console.WriteLine("_____|_____|_____");
        Console.WriteLine("     |     |     ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", playField[2, 0], playField[2, 1], playField[2, 2]);
        Console.WriteLine("     |     |     ");
        //turns++;

    }
}
