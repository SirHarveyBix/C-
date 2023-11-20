namespace StringManipulation;

class Program
{
    static void Main(string[] args)
    {
        int age = 35;
        string name = "Alfonso";
        string job = "Developer";

        /* String Concatenation */
        Console.WriteLine("String Concatenation");
        Console.WriteLine("hello my name is " + name + ", I am " + age + " years old.");

        /* String Formating - it uses index */
        Console.WriteLine("\nString Formating");
        Console.WriteLine("hello my name is {0}, I am {1} years old. I'm a {2}.", name, age, job);

        /* String Interpolation - it uses $, allowing to use variable */
        Console.WriteLine("\nString Interpolation");
        Console.WriteLine($"hello my name is {name}, I am {age} years old. I'm a {job}.");

        /* Verbatim strings - it uses @, tells the compiler to take string literally and ignore space & escape character */
        Console.WriteLine("\nVerbatim String");
        Console.WriteLine(@"hello my name is {name},\nI am {age} years old.");
        // used for path fo exemple :
        Console.WriteLine(@"C:\User\Admin\Dog");

        /* - - Special Characters - - */

        string newString = "this is a \"string\" with \na backslash \\ and a colon :";

        Console.WriteLine("\n" + newString);
    }
}