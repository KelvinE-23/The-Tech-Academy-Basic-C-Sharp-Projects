using System;
namespace MathParameterConsoleApp
{
    // Defines a class whose method performs work with two integer inputs.
    public class MathOperation
    {
        // Accepts two integers, performs a math operation on the first integer,
        // and displays the second integer as required by the assignment.
        public void mathOperation(int firstNumber, int secondNumber)
        {
            // Multiplies the first integer by two and stores the result.
            // This demonstrates a math operation on the first parameter.
            int doubledFirstNumber = firstNumber * 2;

            // Displays the math result so the operation is visible when the app runs.
            Console.WriteLine($"The first number doubled is: {doubledFirstNumber}");

            // Displays the value of the second integer parameter on the screen.
            Console.WriteLine($"The second number is: {secondNumber}");
        }
    }
}
