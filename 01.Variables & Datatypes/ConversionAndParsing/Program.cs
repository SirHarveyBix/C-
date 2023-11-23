using System;

namespace ConversionAndParsing;
class Program
{
    static void Main(string[] args)
    {
        /* - - CONVERSION - - */
        // implicit conversion
        int num = 12390532;
        long bigNum = num;

        float myFloat = 13.37F;
        double myNewDouble = myFloat;

        /* - - - - - - - - - - */

        double myDouble = 13.37;
        int myInt;

        // excplicit conversion
        // cast double to int
        myInt = (int)myDouble;

        bool sunIsShining = false;
        // typeConversion
        string myString = myDouble.ToString(); // => "13.37"
        sunIsShining.ToString();

        Console.WriteLine("myInt : {0},\nmyString : {1},\nsunIsShining : {2},", myInt, myString, sunIsShining);
        //Console.Read();

        /* - - PARSING - - */
        Console.WriteLine("\n # # # # # \n");

        string myNewString = "15";
        string mySecondNewString = "13";
        string result = myNewString + mySecondNewString;

        Console.WriteLine("result : " + result);

        int betterResult = Int32.Parse(myNewString) + Int32.Parse(mySecondNewString);
        // Int32.TryParse() returns a boolean

        float stringForFloat = float.Parse("0.85");

        Console.WriteLine("\nbetterResult : " + betterResult + "\nInt32.Parse(\"0.85\") : " + stringForFloat);
    }
}
