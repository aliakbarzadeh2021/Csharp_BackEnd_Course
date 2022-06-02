using System;

namespace Csharp_BackEnd_Course.Beginner._1.Basic
{
    internal class StringTestingFunctions
    {
        public static void Run()
        {
            string animal = "Dog";

            /**
             * Retrieving a String's Length
             */

            Console.WriteLine(animal.Length);
            Console.WriteLine("Elephant".Length);

            /**
             * Locating Text Within a String
             */

            string phrase = "The quick brown fox jumps over the lazy dog.";

            Console.WriteLine(phrase.IndexOf("brown"));           // result is 10
            Console.WriteLine(phrase.LastIndexOf("dog"));         // result is 40
            Console.WriteLine(phrase.IndexOf("green"));           // result is -1
            Console.WriteLine(phrase.LastIndexOf("blue"));        // result is -1

            /**
             * Specifying a limited search
             */

            Console.WriteLine(phrase.IndexOf("he"));                // result is 1
            Console.WriteLine(phrase.IndexOf("he", 1));             // result is 1
            Console.WriteLine(phrase.IndexOf("he", 2));             // result is 32
            Console.WriteLine(phrase.LastIndexOf("he"));            // result is 32
            Console.WriteLine(phrase.LastIndexOf("he", 33));        // result is 32
            Console.WriteLine(phrase.LastIndexOf("he", 32));        // result is 1

            /**
             * Simple container tests - StartsWith and EndsWith
             */

            Console.WriteLine(phrase.StartsWith("The quick"));      // true
            Console.WriteLine(phrase.StartsWith("lazy dog."));      // false
            Console.WriteLine(phrase.EndsWith("lazy dog."));        // true
            Console.WriteLine(phrase.EndsWith("The quick"));        // false

            /**
             * Simple container tests - .NET 2.0. Contains Method
             */

            Console.WriteLine(phrase.Contains("brown fox"));        // true
            Console.WriteLine(phrase.Contains("lazy fox."));        // false
        }
    }
}
