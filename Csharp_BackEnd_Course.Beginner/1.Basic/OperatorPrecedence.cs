using System;

namespace Csharp_BackEnd_Course.Beginner._1.Basic
{
    internal class OperatorPrecedence
    {
        public static void Run()
        {
            /*
                Operator precedence overview:
              
                Parentheses Operator
                ()
                Member Access Operator
                .
                Increment / Decrement Operators
                ++(postfix) --(postfix) ++(prefix) --(prefix)
                Complement Operators
                ! ~
                Basic Arithmetic Operators
                * / % + -
                Bitwise Shift Operators
                << >>
                Comparison Operators
                < > <= >=
                Equivalence Operators
                == !=
                Logic / Bitwise Operators
                & ^ | && ||
                Conditional Operator
                ?
                Assignment Operator
                =
                Compound Assignment Operators
                *= /= %= += -= >>= <<= &= ^= |=
                Null Coalescing Operator
                ??
             */

            int a = 3;
            int b = a++ + ++a;      // simple example of checking operators precedence
            Console.WriteLine(b);   // result: 8
        }

        static void Main(string[] args)
        {
            int a = 8;
            int b = 2;
            int sum, diff, prod;
            doEverything(a, b, out sum, out diff, out prod);
            Console.WriteLine("Sum: {0}", sum);
            Console.WriteLine("Diff: {0}", diff);
            Console.WriteLine("Product: {0}", prod);
            Console.ReadKey();
        }

        static void doEverything(int a, int b, out int sum, out int diff, out int prod)
        {
            sum = a + b;
            diff = a - b;
            prod = a * b;
        }
    }
}
