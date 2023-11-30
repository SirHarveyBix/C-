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

        do
        {
            if (player == 2)
            {
                player = 1;
                EnterXorO(player, input);
            }
            else if (player == 1)
            {
                player = 2;
                EnterXorO(player, input);
            }

            do
            {
                Console.WriteLine("\nPlayer {0}: choose your field!", player);
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                }
                catch { Console.WriteLine("Plese enter a number!"); }

            } while (!inputCorrect);

        } while (true);

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

    public static void EnterXorO(int player, int input)
    {
        char playerSign = ' ';

        if (player == 1) playerSign = 'X';
        else if (player == 2) playerSign = 'O';

        switch (input)
        {
            case 1: playField[0, 0] = playerSign; break;
            case 2: playField[0, 1] = playerSign; break;
            case 3: playField[0, 2] = playerSign; break;
            case 4: playField[1, 0] = playerSign; break;
            case 5: playField[1, 1] = playerSign; break;
            case 6: playField[1, 2] = playerSign; break;
            case 7: playField[2, 0] = playerSign; break;
            case 8: playField[2, 1] = playerSign; break;
            case 9: playField[2, 2] = playerSign; break;
        }
    }
}
