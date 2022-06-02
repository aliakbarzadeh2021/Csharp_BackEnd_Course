using System;

namespace Csharp_BackEnd_Course.Beginner._1.Basic
{
    internal class CharacterDataType
    {
        public static void Run()
        {
            // assignment

            char letterA;
            letterA = 'A';                           // Assign a character directly
            char letterAwithCast = (char)65;         // Assign a number cast to a char
            Console.WriteLine(letterA);
            Console.WriteLine(letterAwithCast);
            Console.WriteLine((int)letterA);        // ASCII value of letter A (65)

            // nullable character

            char? c;
            c = 'A';
            Console.WriteLine(c);
            c = null;
            Console.WriteLine(c);
        }
    }
}
