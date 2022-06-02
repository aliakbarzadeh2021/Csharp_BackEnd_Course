using System;

namespace Csharp_BackEnd_Course.Beginner._1.Basic
{
    internal class FlowControlConditionalProcessing
    {
        public static void Run()
        {
            int toTest = 5;

            // if statement

            if (toTest >= 0) Console.WriteLine("Positive");     // Outputs "Positive"
            if (toTest < 0) Console.WriteLine("Negative");      // Outputs nothing

            // if-else statement

            if (toTest >= 0)
                Console.WriteLine("Positive");      // Outputs "Positive"
            else
                Console.WriteLine("Negative");

            // nested if statements

            if (toTest >= 0)
            {
                if (toTest == 0)
                    Console.WriteLine("Zero");
                else
                    Console.WriteLine("Positive");  // Outputs "Positive"
            }
            else
            {
                Console.WriteLine("Negative");
            }
        }
    }
}
