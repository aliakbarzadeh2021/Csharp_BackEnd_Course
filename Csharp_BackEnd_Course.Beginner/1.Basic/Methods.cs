using System;

namespace Csharp_BackEnd_Course.Beginner._1.Basic
{
    internal class Methods
    {
        public static void Run(string[] args)
        {
            // example of calling a method
            new Methods().OutputFormattedDate();
        }

        void OutputFormattedDate()
        {
            DateTime theDate = DateTime.Now;
            Console.WriteLine(theDate.ToString("dd/MM/yyyy"));
        }
    }
}
