using System;

namespace VoidMethodAssignment
{
    // This class contains a void method that performs a math operation
    public class MathClass
    {
        // Void method that takes two integers as parameters
        public void DoMath(int num1, int num2)
        {
            // Perform a math operation on the first number
            int result = num1 * 2;

            // Display the result of the math operation
            Console.WriteLine("First number multiplied by 2: " + result);

            // Display the second number
            Console.WriteLine("Second number is: " + num2);
        }
    }
}
