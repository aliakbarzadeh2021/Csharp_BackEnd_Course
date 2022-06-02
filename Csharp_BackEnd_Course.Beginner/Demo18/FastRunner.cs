using System;
using System.Collections.Generic;
using System.Text;

namespace Example4._7._1
{
    public class FastRunner : IRun
    {
        public void Run(int distance)
        {
            Console.WriteLine($"Running fast for {distance} kms");
        }
    }
}
