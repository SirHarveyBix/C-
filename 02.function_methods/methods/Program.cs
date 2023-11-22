namespace methods;

class Program
{
    static void Main(string[] args)
    {
        WriteSomething();

        WriteSomethidSpecific("lol\n");

        Console.WriteLine(Add(1, 2));
        Console.WriteLine(Add(Add(1, 2), Add(1, 2)));

        Console.WriteLine(Multiply(4, 2));
        Console.WriteLine(Divide(4, 2));
    }

    // access modifier [static], return type [void], method name, parameter (type name).
    public static void WriteSomething()
    {
        Console.WriteLine("Inside a method.\n");
    }

    public static void WriteSomethidSpecific(string text)
    {
        Console.WriteLine("arg : " + text);
    }

    public static int Add(int number1, int number2)
    {
        return number1 + number2;
    }

    public static int Multiply(int number1, int number2)
    {
        return number1 * number2;
    }

    public static double Divide(int number1, int number2)
    {
        return number1 / number2;
    }
}
