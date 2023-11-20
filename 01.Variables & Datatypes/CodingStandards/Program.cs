using System;

namespace CodingStandards
{ // Class names like ClientActivity
    class Program
    {
        // method name like CalculateValue
        // method arguments like firstNumber
        static void CalculateValue(int firstNumber)
        {
            Console.WriteLine("firstNumber is : {0}", firstNumber);
        }

        static void Main(string[] args)
        {
            // local variable like itemCount
            int itemCount = 0;

            // use userControl instead of usrCtrl
            bool userControl = true;

            CalculateValue(itemCount);
        }
    }
}