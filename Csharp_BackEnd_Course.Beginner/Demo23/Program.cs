using System;
using System.Collections.Generic;
using GenericExtensions;

namespace Example7._4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            testExtensions();
            Console.ReadKey();
        }

        private static void testExtensions()
        {
            List<string> colors = new List<string>()
            {
                "blue",
                "red",
                "orange",
                "green"
            };
            var stack = colors.ToStack();
            Console.Write("Colors - List: ");
            foreach(var color in colors)
            {
                Console.Write($"{color} ");
            }
            Console.WriteLine();

            Console.Write("Colors - Stack: ");
            while(stack.Count > 0)
            {
                Console.Write($"{stack.Pop()} ");
            }
            Console.WriteLine();

        }
    }
}
