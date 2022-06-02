using System;
using System.Collections.Generic;
using System.Text;

namespace Example4._7._1
{
    public class SlowRunner : IRun
    {
        public void Run(int distance)
        {
            Console.WriteLine($"Running slow for {distance} kms");
        }
    }
}
