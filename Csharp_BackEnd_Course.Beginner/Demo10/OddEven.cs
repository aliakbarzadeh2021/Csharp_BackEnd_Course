using System;

namespace Day05.Lib
{
    /// <summary>
    ///     Source: https://github.com/garora/TDD-Katas/tree/develop/Src/cs/OddEvenKata
    /// </summary>
    public class OddEven
    {
        public   string PrintOddEven(int startNumber, int lastNumber)
        {
            return GetOddEvenWithinRange(startNumber, lastNumber);
        }

        public   string PrintSingleOddEven(int number)
        {
            return CheckSingleNumberOddEvenPrimeResult(number);
        }


        private   string CheckSingleNumberOddEvenPrimeResult(int number)
        {
            var result = string.Empty;
            result = CheckSingleNumberOddEvenPrimeResult(result, number);
            return result;
        }

        private   string GetOddEvenWithinRange(int startNumber, int lastNumber)
        {
            var result = string.Empty;
            for (var number = startNumber < 0 ? 1 : startNumber; number <= lastNumber; number++)
                result = CheckSingleNumberOddEvenPrimeResult(result, number);

            return result;
        }

        private   string CheckSingleNumberOddEvenPrimeResult(string result, int number)
        {
            var newNumber = string.Empty;

            var oddNumber = IsOddNumber(number) ? "Odd" : Convert.ToString(number);
            var primenumber = IsPrimeNumber(number) ? Convert.ToString(number) : oddNumber;

            if (!string.IsNullOrEmpty(newNumber))
                newNumber += IsEvenNumber(number) ? "Even" : primenumber;
            else
                newNumber = IsEvenNumber(number) ? "Even" : primenumber;

            result += " " + newNumber;
            return result.Trim();
        }

        private   bool IsEvenNumber(int number)
        {
            return number >= 2 && number % 2 == 0;
        }

        private   bool IsOddNumber(int number)
        {
            return number % 2 != 0;
        }

        private   bool IsPrimeNumber(int number)
        {
            if (number < 2) return false;
            if (IsEvenNumber(number)) return false;
            var divisble = 3;
            while (divisble * divisble <= number)
            {
                if (number % divisble == 0) return false;
                divisble += 2;
            }
            return true;
        }
    }
}