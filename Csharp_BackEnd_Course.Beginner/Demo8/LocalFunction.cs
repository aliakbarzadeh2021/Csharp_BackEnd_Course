namespace Day03Lib
{
    public class LocalFunction
    {
        public static string FindOddEvenBySingleNumber(int number)
        {
            return IsOddNumber(number) ? "Odd" : "Even";
        }

        public string FindOddEvenBySingleNumberUsingLocalFunction(int someInput)
        {
            //Local function, scoped within FindOddEvenBySingleNumberUsingLocalFunction
            bool IsOddNumber(int number)
            {
                return number >= 1 && number % 2 != 0;
            }

            return IsOddNumber(someInput) ? "Odd" : "Even";
        }

        private static bool IsOddNumber(int number)
        {
            return number >= 1 && number % 2 != 0;
        }
    }
}