using System;

namespace Csharp_BackEnd_Course.Beginner._1.Basic
{
    internal class FlowControlWhileLoop
    {
        public static void Run()
        {
            int current = 1;
            string output = String.Empty;

            // Loop while the value being checked is 1000 or less 
            while (current <= 1000)
            {
                output += current.ToString() + " ";
                current *= 3;
            }

            Console.WriteLine(output); // Outputs "1 3 9 27 81 243 729 "

            // do-while loop

            int value = 1;
            int factorial = 10;

            do
            {
                value *= factorial;
                factorial--;
            } while (factorial > 1);

            Console.WriteLine(value); // Outputs "3628800"
        }
    }
}
