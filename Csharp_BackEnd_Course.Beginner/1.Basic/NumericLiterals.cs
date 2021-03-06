namespace Csharp_BackEnd_Course.Beginner._1.Basic
{
    internal class NumericLiterals
    {
        public static void Run()
        {
            //numeric literals
            int facesOnADie = 6;        // 6 is a literal
            int lessThanZero = -1;      // -1 is a literal
            int zeroValue = 0;          // 0 is a literal
            double piApprox = 3.142;    // 3.142 is a literal

            // literal data types

            //float unitPrice = 123.45; // This will not compile

            //float unitPrice = 123.45;     // This will not compile
            //float unitPrice = 123.45F;    // This will compile
            //float unitPrice = 123.45f;    // So will this          

            // Using Hexadecimal
            int sixteen = 16;
            int sixteenInHex = 0x10;

            // Boolean literals
            bool grassIsGreen = true;
            bool cowsGoBaa = false;
        }
    }
}
