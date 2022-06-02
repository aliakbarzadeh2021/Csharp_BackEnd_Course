using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_BackEnd_Course.Wrongs
{
    internal class Ref
    {

        /// <summary>
        /// Warning: This method is not supposed to work
        /// It is a demo of ref local bad usage
        /// </summary>
        private static ref double getDoubleRef()
        {
            double value = 3.14;
            return ref value;
        }

        /// <summary>
        /// Warning: This method is not supposed to work
        /// It's a demonstration of bad usage of ref locals & returns
        /// </summary>
        static void Main(string[] args)
        {
            ref int result = ref sum(1, 2);
            Console.ReadKey();
        }

        private static int sum(int a, int b)
        {
            return a + b;
        }
    }
}
