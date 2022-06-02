using System;
using System.Globalization;
using System.Linq;

namespace Day05.Lib
{
    /// <summary>
    ///     Implementatipn of
    ///     <see href="https://github.com/garora/TDD-Katas/blob/develop/Src/cs/FizzBuzzKata/FizzBuzz.cs">FizzBuzz</see>
    /// </summary>
    public class FizzBuzz
    {
        public static string PrintFizzBuzz()
        {
            var resultFizzBuzz = string.Empty;
            resultFizzBuzz = GetNumbers(resultFizzBuzz);
            return resultFizzBuzz;
        }

        public static string PrintFizzBuzz(int number)
        {
            CanThrowArgumentExceptionWhenNumberNotInRule(number);

            var result = GetFizzBuzzResult(number);

            if (string.IsNullOrEmpty(result))
                result = GetFizzResult(number);
            if (string.IsNullOrEmpty(result))
                result = GetBuzzResult(number);

            return string.IsNullOrEmpty(result) ? number.ToString(CultureInfo.InvariantCulture) : result;
        }

        private static string GetFizzBuzzResult(int number)
        {
            string result = null;
            if (IsFizz(number) && IsBuzz(number)) result = "FizzBuzz";
            return result;
        }

        private static string GetBuzzResult(int number)
        {
            string result = null;
            if (IsBuzz(number)) result = "Buzz";
            return result;
        }

        private static string GetFizzResult(int number)
        {
            string result = null;
            if (IsFizz(number)) result = "Fizz";
            return result;
        }

        private static void CanThrowArgumentExceptionWhenNumberNotInRule(int number)
        {
            if (number > 100 || number < 1)
                throw new ArgumentException(
                    string.Format(
                        "entered number is [{0}], which does not meet rule, entered number should be between 1 to 100.",
                        number));
        }

        private static string GetNumbers(string resultFizzBuzz)
        {
            for (var count = 1; count <= 100; count++)
            {
                var printNumber = string.Empty;
                if (IsFizz(count)) printNumber += "Fizz";
                if (IsBuzz(count)) printNumber += "Buzz";
                if (IsNumber(printNumber))
                    printNumber = count.ToString(CultureInfo.InvariantCulture);
                resultFizzBuzz += " " + printNumber;
            }
            return resultFizzBuzz.Trim();
        }

        private static string GetNumbersUsingLinq(string resultFizzBuzz)
        {
            Enumerable.Range(1, 100)
                .Select(fb => string.Format("{0}{1}", fb % 3 == 0 ? "Fizz" : "", fb % 5 == 0 ? "Buzz" : ""))
                .Select(fb => fb != null ? (string.IsNullOrEmpty(fb) ? fb.ToString() : fb) : null)
                .ToList()
                .ForEach(x => resultFizzBuzz = x);
            return resultFizzBuzz.Trim();
        }

        private static bool IsNumber(string printNumber)
        {
            return string.IsNullOrEmpty(printNumber);
        }

        private static bool IsBuzz(int i)
        {
            return i % 5 == 0;
        }

        private static bool IsFizz(int i)
        {
            return i % 3 == 0;
        }
    }

    public delegate string FizzBuzzDelegate(int num);

    public class FizzBuzzImpl
    {
        public FizzBuzzImpl()
        {
            FizzBuzzEvent += PrintFizzBuzz;
        }

        public event FizzBuzzDelegate FizzBuzzEvent;

        private string PrintFizzBuzz(int num)
        {
            return FizzBuzz.PrintFizzBuzz(num);
        }

        public string EventImplementation(int num)
        {
            var fizzBuzImpl = new FizzBuzzImpl();
            return fizzBuzImpl.FizzBuzzEvent(num);
        }
    }
}