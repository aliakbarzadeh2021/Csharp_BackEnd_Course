using System;
using System.Collections.Generic;
using System.Linq;

namespace Day03Lib
{
    /// <summary>
    ///     Nuget package required:https://www.nuget.org/packages/System.ValueTuple/
    /// </summary>
    public class OddEven
    {
        public static (int, string) FindOddEvenBySingleNumber(int number)
        {
            var oddOrEven = IsOddNumber(number) ? "Odd" : "Even";

            return (number, oddOrEven); //tuple literal
        }

        public static (int number, string oddOrEven) FindOddEvenBySingleNumberNamedElement(int number)
        {
            var result = IsOddNumber(number) ? "Odd" : "Even";

            return (number: number, oddOrEven: result); //returning named tuple element in tuple literal
        }

        public static IEnumerable<ValueTuple<int, string>> FindOddEvenBySeries(IEnumerable<int> numbers)
        {
            return numbers.Select(FindOddEvenBySingleNumber).ToList();
        }

        public static IEnumerable<ValueTuple<int, string>> FindOddEvenWithinRange(int startNumber, int lastNumber)
        {
            IList<ValueTuple<int, string>> resulTuples = new List<ValueTuple<int, string>>();

            for (var number = startNumber < 0 ? 1 : startNumber; number <= lastNumber; number++)
                resulTuples.Add(FindOddEvenBySingleNumber(number));
            return resulTuples;
        }

        public static string ExplicitlyTypedDeconstruction(int num)
        {
            (int number, string evenOdd) = FindOddEvenBySingleNumber(num);
            return $"Entered number:{number} is {evenOdd}.";
        }

        public static string ImplicitlyTypedDeconstruction(int num)
        {
            var (number, evenOdd) = FindOddEvenBySingleNumber(num);
            //Following deconstruct is also valid
            //(int number, var evenOdd) = FindOddEvenBySingleNumber(num);
            return $"Entered number:{number} is {evenOdd}.";
        }

        public static string UserDefinedTypeDeconstruction(int num)
        {
            var customModel = new UserDefinedModel(num, IsOddNumber(num) ? "Odd" : "Even");
            var (number, oddEven) = customModel;
            return $"Entered number:{number} is {oddEven}.";
        }

        /// <summary>
        ///     Implementation of CompareTo(ValueTuple) public method
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool CompareToTuple(int number)
        {
            var oddEvenValueTuple = FindOddEvenBySingleNumber(number);
            var differentTupleValue = FindOddEvenBySingleNumberNamedElement(number + 1);
            var res = oddEvenValueTuple.CompareTo(differentTupleValue);
            return res == 0; // 0 if other is a ValueTuple instance and 1 if other is null
        }

        /// <summary>
        ///     /// Implementation of CompareTo(ValueTuple) public method
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool CompareToTuple1(int number)
        {
            var oddEvenValueTuple = FindOddEvenBySingleNumber(number);
            var sameTupleValue = FindOddEvenBySingleNumberNamedElement(number);
            var res = oddEvenValueTuple.CompareTo(sameTupleValue);
            return res == 0; // 0 if other is a ValueTuple instance and 1 if other is null
        }

        /// <summary>
        ///     Implementation of Equals(Object) public method
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool EqualToTuple(int number)
        {
            var oddEvenValueTuple = FindOddEvenBySingleNumber(number);
            var sameTupleValue = FindOddEvenBySingleNumberNamedElement(number);
            var res = oddEvenValueTuple.Equals(sameTupleValue);
            return res; //true if obj is a ValueTuple instance; otherwise, false. 
        }

        /// <summary>
        ///     Implementation of Equals(Object) public method
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool EqualToObject(int number)
        {
            var oddEvenValueTuple = FindOddEvenBySingleNumber(number);
            var modelObject = new UserDefinedModel {Number = number, OddEven = IsOddNumber(number) ? "Odd" : "Even"};
            var res = oddEvenValueTuple.Equals(modelObject);
            return res; //true if obj is a ValueTuple instance; otherwise, false. 
        }

        private static ValueTuple<int, int, int, int, int, int, int, ValueTuple<int>> OctupleUsingCreate()
        {
            return ValueTuple.Create(1, 2, 3, 4, 5, 6, 7, 8);
        }

        private static ValueTuple<int, int, int, int, int, int, int, ValueTuple<int>> CreateOctuple()
        {
            return new ValueTuple<int, int, int, int, int, int, int, ValueTuple<int>>(1, 2, 3, 4, 5, 6, 7,
                new ValueTuple<int>(8));
        }

        public static ValueTuple CreateValueTuple()
        {
            return ValueTuple.Create();
        }

        public static ValueTuple<int> CreateValueTupleSingleton(int number)
        {
            return ValueTuple.Create(number);
        }

        private static bool IsEvenNumber(int number)
        {
            return number % 2 == 0;
        }

        private static bool IsOddNumber(int number)
        {
            return number % 2 != 0;
        }

        /// <summary>
        ///     C#7.1 features - Inferred tuple names
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        public static void InferTupleNames(int num1, int num2)
        {
            (int, int) noNamed = (num1, num2);
            Console.WriteLine($"NoNamed:{noNamed.Item1},{noNamed.Item2}");
            (int, int) ignoredName = (A:num1, B:num2);
            Console.WriteLine($"IgnoredName:{ignoredName.Item1},{ignoredName.Item2}");
            (int a, int b) typeNamed = (num1, num2);
            Console.WriteLine($"typeNamed using default member-names:{typeNamed.Item1},{typeNamed.Item2}");
            Console.WriteLine($"typeNamed:{typeNamed.a},{typeNamed.b}");
            var named = (num1, num2);
            Console.WriteLine($"named using default member-names:{named.Item1},{named.Item2}");
            Console.WriteLine($"named:{named.num1},{named.num2}");
            var noNamedVariation = (num1, num1);
            Console.WriteLine($"noNamedVariation:{noNamedVariation.Item1},{noNamedVariation.Item2}");
            var explicitNaming = (n: num1, num1);
            Console.WriteLine($"explicitNaming:{explicitNaming.n},{explicitNaming.num1}");
            var partialnamed = (num1, 5);
            Console.WriteLine($"partialnamed:{partialnamed.num1},{partialnamed.Item2}");

        }
    }
}