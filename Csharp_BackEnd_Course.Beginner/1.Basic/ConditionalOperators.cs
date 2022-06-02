using System;

namespace Csharp_BackEnd_Course.Beginner._1.Basic
{
    internal class ConditionalOperators
    {
        public static void Run()
        {
            int minimumValue = 5;
            int userEntered = Convert.ToInt32(Console.ReadLine());

            // Ensure that the user-provided value is at least the minimum permitted
            int valueToUse = userEntered >= minimumValue ? userEntered : minimumValue;
            Console.WriteLine(valueToUse);

            // Return the absolute value
            int value = -5;
            int absoluteValue = value >= 0 ? value : -value;
            Console.WriteLine(absoluteValue);
        }
    }
}
