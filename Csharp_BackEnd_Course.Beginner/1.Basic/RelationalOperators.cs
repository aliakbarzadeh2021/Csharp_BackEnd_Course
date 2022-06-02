namespace Csharp_BackEnd_Course.Beginner._1.Basic
{
    internal class RelationalOperators
    {
        public static void Run()
        {
            // relational operators

            // equal to operator

            int a = 55;
            int b = 65;
            int c = 65;
            bool result;

            result = a == b;        // result = false
            result = b == c;        // result = true

            // not equal to operator

            a = 55;
            b = 65;
            c = 65;

            result = a != b;        // result = true
            result = b != c;        // result = false

            // comparison operators

            a = 55;
            b = 65;
            c = 65;

            result = a > b;         // result = false
            result = a < b;         // result = true
            result = a >= b;        // result = false
            result = a <= b;        // result = true
            result = b > c;         // result = false
            result = b < c;         // result = false
            result = b >= c;        // result = true
            result = b <= c;        // result = true
        }
    }
}
