namespace Conversion;

class Program
{
    static void Main(string[] args)
    {
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
    }
}
