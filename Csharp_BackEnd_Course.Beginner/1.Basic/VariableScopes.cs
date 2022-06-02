using System;

namespace Csharp_BackEnd_Course.Beginner._1.Basic
{
    internal class VariableScopes
    {
        static void Run(string[] args)
        {
            /**
             * Method-level scope
             */

            int score;                                          // Declared at method-level
            score = 100;                                        // Used at method-level

            if (score >= 50)
                Console.WriteLine("Good score : {0}", score);   // Used in nested scope
            else
                Console.WriteLine("Poor score : {0}", score);   // Used in nested scope

            /**
             * Nested scope
             */

            if (score >= 50)
            {
                string message = "Good score"; // Declared in if statement
            }
            else
            {
                string message = "Poor score"; // Declared in if statement
            }

            //Console.WriteLine(message);     // Variable unavailable
        }
    }
}
