using System;

namespace MultiDimensional;
class Program
{
    static void Main(string[] args)
    {
        // declare 2D arrays
        string[,] matrix;

        // declare 3D arrays
        string[,,] threeD;

        // 2 dimentsonal arrays
        int[,] array2D = new int[,]
        {
            { 1, 2, 3 }, // row 0
            { 4, 5, 6 }, // row 1
            { 7, 8, 9 } // row 2
        };

        Console.WriteLine("central value : '{0}'", array2D[1, 1]); // 5 - > row 1, position 1
        Console.WriteLine("first value of second row : '{0}'", array2D[2, 0]); // 7 - > row 2, position 0

        string[,,] array3D = new string[,,]
        { // depth
            { // high - 0 
                { "000"/* postion - 0 */, "001" /* postion - 1 */ }, // length - 0
                { "010", "011" }, // length - 1
                { "hi there", "wassup" } // length - 2
            },
            { // high - 1
                { "100", "101" }, // length - 0
                { "110", "111" }, // length - 1
                { "we need", "'parralel' dimensions (3x3)" } // length - 2
            }
        };

        Console.WriteLine("the value is '{0}' ", array3D[1, 1, 0]); // second element in second array, at first position
        Console.WriteLine("the value is '{0}' \n", array3D[0, 2, 1]);

        string[,] array2DString = new string[,]
        {
            {"one", "two"},
            {"three", "four"},
            {"five", "six"}
        };

        Console.WriteLine("array2DString[1, 1]  =>  before chiken came in : '{0}'", array2DString[1, 1]);
        array2DString[1, 1] = "chiken";

        Console.WriteLine("array2DString[1, 1]  =>  after chiken came in : '{0}'\n", array2DString[1, 1]);

        int dimensions = array2DString.Rank;
        Console.WriteLine("how much 'dimensions' are in : 'array2DString' : {0}", dimensions);
        Console.WriteLine("how much 'dimensions' are in : 'array3D' : {0}", array3D.Rank);
        Console.WriteLine("it uses :'.Rank' => array3D.Rank\n");

        // can be initialize that way :
        int[,] secondArray2D = { { 1, 2 }, { 3, 4 } };
    }
}
