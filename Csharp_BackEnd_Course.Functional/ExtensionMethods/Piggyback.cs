using System;

namespace PiggybackNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 60;
            Console.WriteLine(i.Square());
        }
    }

    class Program2
    {
        static void Main(string[] args)
        {
            int i = 0;
            string strData = "Piggybacking";
            byte[] byteData = strData.ConvertToHex();
            foreach (char c in strData)
            {
                Console.WriteLine("{0} = 0x{1:X2} ({2})",
                    c.ToString(),
                    byteData[i],
                    byteData[i++]);
            }
        }
    }
}

namespace System
{
    public static class ExtensionMethod
    {
        public static int Square(this int i)
        {
            return i * i;
        }
    }
}

namespace System
{
    public static class ExtensionMethodsClass
    {
        public static byte[] ConvertToHex(this string str)
        {
            int i = 0;
            byte[] HexArray = new byte[str.Length];

            foreach (char ch in str)
            {
                HexArray[i++] = Convert.ToByte(ch);
            }

            return HexArray;
        }
    }
}

namespace ReferencingNamespaceLib
{
    public static class ExtensionMethodsClass
    {
        public static byte[] ConvertToHex(this string str)
        {
            int i = 0;
            byte[] HexArray = new byte[str.Length];

            foreach (char ch in str)
            {
                HexArray[i++] = Convert.ToByte(ch);
            }

            return HexArray;
        }
    }
}



namespace ReferencingNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            string strData = "Functional in C#";
            byte[] byteData = strData.ConvertToHex();
            foreach (char c in strData)
            {
                Console.WriteLine("{0} = 0x{1:X2} ({2})",
                    c.ToString(),
                    byteData[i],
                    byteData[i++]);
            }
        }
    }
}



