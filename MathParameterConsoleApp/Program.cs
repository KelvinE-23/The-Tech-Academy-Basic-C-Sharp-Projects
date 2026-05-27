using System;
namespace MathParameterConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            // Instantiates the class so its MathOperation method can be called.
            MathOperation processor = new MathOperation();

            // Calls the method with arguments: 8 is first and 12 is second.
            processor.mathOperation(8, 12);

            // Calls the same method using named parameters to identify each argument clearly.
            processor.mathOperation(firstNumber: 5, secondNumber: 20);

            // Waits for the user to press Enter before the console application closes.
            Console.ReadLine();
        }
    }


}
