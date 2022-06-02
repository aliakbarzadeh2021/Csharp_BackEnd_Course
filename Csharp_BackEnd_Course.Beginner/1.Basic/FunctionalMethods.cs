using System;

namespace Csharp_BackEnd_Course.Beginner._1.Basic
{
    internal class FunctionalMethods
    {
        public static void Run(string[] args)
        {
            FunctionalMethods program = new FunctionalMethods();
            Console.WriteLine(program.GetFormattedDate());
            Console.WriteLine(program.GetArea(2, 4));
            Console.WriteLine(Program.GetAreaStatic(2, 4));
        }



        /**
         * method that returns value
         */
        private string GetFormattedDate()
        {
            DateTime theDate = DateTime.Now;
            return theDate.ToString("dd/MM/yyyy");
        }

        /**
         * mehtod with parameters
         */
        private int GetArea(int rectHeight, int rectWidth)
        {
            return rectHeight * rectWidth;
        }

        /**
         * static method
         */
        static int GetAreaStatic(int rectHeight, int rectWidth)
        {
            return rectHeight * rectWidth;
        }
    }
}
