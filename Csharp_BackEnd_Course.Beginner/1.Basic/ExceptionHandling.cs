using System;

namespace Csharp_BackEnd_Course.Beginner._1.Basic
{
    internal class ExceptionHandling
    {
        public static void Run()
        {
            Divide(8, 4);
            Divide(6, 0);
        }

        private static void Divide(int numberOne, int numberTwo)
        {
            var result = TryToDivide(numberOne, numberTwo);
            if (result == -1)
            {
                Console.WriteLine("You cannot divide by zero");
            }
            else
            {
                Console.WriteLine(result);
            }
        }

        private static float TryToDivide(int numberOne, int numberTwo)
        {
            try
            {
                return numberOne / numberTwo;
            }
            catch (DivideByZeroException e)
            {
                return -1;
                throw;
            }
        }
    }
}
