namespace DataType;

class Program
{
    static void Main(string[] args)
    {
        int num;
        num = 13;

        int anotherNum = 23;
        int sum = num + anotherNum;

        Console.WriteLine("num : " + num + " + anotherNum : " + anotherNum + " is " + sum);

        // multiple variables at once !
        int num1, num2, num3;

        double double1 = 3.1415;
        double double2 = 5.1;
        double doubleDivided = double1 / double2;

        Console.WriteLine("\ndouble1 / double2 is " + doubleDivided);

        float float1 = 3.1415f;  // add "f" to cast this variable as float, 
        float float2 = 5.1f;     // otherwise it is considered as double.
        float floatDivided = float1 / float2;

        Console.WriteLine("\nfloat1 / float2 is " + floatDivided + ", float is less precise than double.");

        double doubleIntDivided = double1 / num;
        // int doubleIntDividedInt = double1 / num; // it breaks = type double to int without casting

        Console.WriteLine("\ndouble1 / num is " + doubleIntDivided);

        Console.Read();
    }
}