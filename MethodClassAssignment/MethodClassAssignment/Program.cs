using System;

namespace VoidMethodAssignment
{
    class Program
    {
        static void Main()
        {
            // Create an instance of the MathClass
            MathClass mathObj = new MathClass();

            // Call the method by passing values normally
            mathObj.DoMath(5, 10);

            Console.WriteLine();

            // Call the method using named parameters
            mathObj.DoMath(num1: 7, num2: 20);

            // Keep console open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
