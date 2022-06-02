using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendingStaticClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            int i = 60;
            Console.WriteLine(i.Square());
        }
    }
}

namespace ExtendingStaticClass
{
    public static class StaticClassExtensionMethod
    {
        //public static int Square(this Math m, int i)
        //{
        //    return i * i;
        //}

        public static int Square(this int i)
        {
            return i * i;
        }
    }
}