using System;

namespace Csharp_BackEnd_Course.Beginner._1.Basic
{
    internal class StringDataType
    {
        public static void Run()
        {
            // string data type
            string helloString = "hello string";
            Console.WriteLine(helloString);
            string nullString = null;
            string emptyString;
            emptyString = "";                       // emptyString is empty
            emptyString = String.Empty;             // emptyString is still empty
            Console.WriteLine(emptyString);
            helloString = "hello my string";        // string is immutable type - here object helloString is deleted and created once again
            Console.WriteLine(helloString);
            string repeating = new string('.', 15);
            Console.WriteLine(repeating);           // string constructor - repeating = "..............."
        }
    }
}
