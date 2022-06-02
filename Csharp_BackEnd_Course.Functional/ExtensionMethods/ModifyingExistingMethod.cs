using System;

namespace ModifyingExistingMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            string str = "This is string";
            Console.WriteLine(str.ToString());
        }
    }
}


namespace ModifyingExistingMethod
{
    public static class ExtensionMethods
    {
        public static string ToString(this string str)
        {
            return "ToString() extension method";
        }
    }
}