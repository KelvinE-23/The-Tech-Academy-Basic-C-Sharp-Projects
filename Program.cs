using System;

namespace ConsoleApp_Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a title so the user knows what this program demonstrates.
            Console.WriteLine("Boolean Comparison Demo");

            // Write a blank line to make the console output easier to read.
            Console.WriteLine();

            // Create and assign the starting value for the while loop counter.
            int whileCounter = 1;

            // Explain the first section of the program to the user.
            Console.WriteLine("While loop using a boolean comparison:");

            // Keep looping while the boolean comparison 'whileCounter <= 3' is true.
            while (whileCounter <= 3)
            {
                // Display the current counter value during each pass through the loop.
                Console.WriteLine("The while loop is running because " + whileCounter + " <= 3 is true.");

                // Increase the counter so the loop can eventually become false and stop.
                whileCounter++;
            }

            // Write a blank line to separate the two demonstrations.
            Console.WriteLine();

            // Create and assign the starting value for the do-while loop counter.
            int doWhileCounter = 1;

            // Explain the second section of the program to the user.
            Console.WriteLine("Do while loop using a boolean comparison:");

            // Start the do-while loop, which runs the code block once before checking the condition.
            do
            {
                // Display the current counter value during each pass through the loop.
                Console.WriteLine("The do while loop is running because " + doWhileCounter + " < 4 is true.");

                // Increase the counter so the condition will eventually become false.
                doWhileCounter++;
            }
            // Continue looping while the boolean comparison 'doWhileCounter < 4' is true.
            while (doWhileCounter < 4);

            // Write a blank line before the ending message.
            Console.WriteLine();

            // Tell the user the program has finished both loop demonstrations.
            Console.WriteLine("Press any key to exit.");

            // Wait for a key press so the console window stays open long enough to read the output.
            Console.ReadKey();
        }
    }
}
