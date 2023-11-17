
namespace DataTypesAndLimits
{
    public class DataTypesAndLimits
    {
        // Primitive data types
        // Integral
        sbyte sb = 1; // -128 to 127
        short s = 1; // -32,768 to 32,767
        int i = 1; // -2,147,483,648 to 2,147,483,647
        long l = 1; // –9,223,372,036,854,775,808 to 9,223,372,036,854,775,807

        // Floating point
        float f = 0.5f; //  1.5 × 10^−45 to 3.4 × 10^38, 7-digit precision
        double d = 0.5; //  5.0 × 10^−324 to 1.7 × 10^308, 15-digit precision
        decimal dec = 0.5m; //  –7.9 × 10^−28 to 7.9 × 10^28, 28-digit precision

        // Use float for 3D graphics
        // double for everything (except money calculations use decimal instead)

        // Boolean
        bool switcher = true;

        // Unicode characters and strings
        char letter = 'A';
        string name = "John Doe";

        public static void Main(string[] args)
        {

        }
    }
}

