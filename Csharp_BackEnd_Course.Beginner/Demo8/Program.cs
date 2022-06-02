using System;
using System.Linq;
using Day03Lib;
using static System.Console;

namespace Day03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ValueTypeMenu();
        }

        private static void ValueTypeMenu()
        {
            int userInput;
            do
            {
                userInput = DisplayMenu();
                switch (userInput)
                {
                    case 1:
                        Clear();
                        Write("Enter number: ");
                        var number = ReadLine();
                        var result = OddEven.FindOddEvenBySingleNumber(Convert.ToInt32(number));
                        WriteLine($"Number:{result.Item1} is {result.Item2}");
                        PressAnyKey();
                        break;
                    case 2:
                        Clear();
                        Write("Enter start number: ");
                        var startNumber = ReadLine();
                        Write("Enter last number: ");
                        var lastNumber = ReadLine();
                        var results = OddEven.FindOddEvenWithinRange(Convert.ToInt32(startNumber),
                            Convert.ToInt32(lastNumber));
                        foreach (var tuple in results)
                            WriteLine($"Number:{tuple.Item1} is {tuple.Item2}");

                        PressAnyKey();
                        break;
                    case 3:
                        Clear();
                        Write("Enter series of number (comma separated): ");
                        var numberSeries = ReadLine();

                        if (numberSeries != null)
                        {
                            var resultSeries =
                                OddEven.FindOddEvenBySeries(numberSeries.Split(',').Select(int.Parse).ToList());
                            foreach (var tuple in resultSeries)
                                WriteLine($"Number:{tuple.Item1} is {tuple.Item2}");
                        }
                        PressAnyKey();
                        break;
                    case 4:
                        Clear();
                        Write("Enter first number: ");
                        var userInputFirst = ReadLine();
                        Write("Enter second number: ");
                        var userInputSecond = ReadLine();
                        var noNamed = OddEven.FindOddEvenBySingleNumber(Convert.ToInt32(userInputFirst));
                        var named = OddEven.FindOddEvenBySingleNumberNamedElement(Convert.ToInt32(userInputSecond));
                        WriteLine($"First Number:{noNamed.Item1} is {noNamed.Item2} using noNamed tuple.");
                        WriteLine($"Second Number:{named.number} is {named.oddOrEven} using Named tuple.");

                        WriteLine("Assigning 'Named' to 'NoNamed'");
                        noNamed = named;
                        WriteLine($"Number:{noNamed.Item1} is {named.Item2} after assignment.");
                        Write("Enter third number: ");
                        var userInputThird = ReadLine();
                        var noNamed2 = OddEven.FindOddEvenBySingleNumber(Convert.ToInt32(userInputThird));
                        WriteLine(
                            $"Third Number:{noNamed2.Item1} is {noNamed2.Item2} using second noNamed tuple.");
                        WriteLine("Assigning 'second NoNamed' to 'Named'");
                        named = noNamed2;
                        WriteLine($"Second Number:{named.number} is {named.oddOrEven} after assignment.");
                        PressAnyKey();
                        break;
                    case 5:
                        Clear();
                        Write("Enter number: ");
                        var numberInt = ReadLine();
                        var resultBefore = OddEven.FindOddEvenBySingleNumberNamedElement(Convert.ToInt32(numberInt));
                        WriteLine(
                            $"Number:{resultBefore.number} is {resultBefore.oddOrEven} is before conversion.");
                        PressAnyKey();
                        break;
                    case 6:
                        Clear();
                        Write("Enter number: ");
                        var num = ReadLine();
                        var resultNum = OddEven.FindOddEvenBySingleNumberNamedElement(Convert.ToInt32(num));
                        WriteLine($"Number:{resultNum.number} is {resultNum.oddOrEven}.");
                        WriteLine();
                        var comp = OddEven.CompareToTuple(Convert.ToInt32(num));
                        WriteLine($"Comparison of two Tuple objects having different value is:{comp}");
                        var comp1 = OddEven.CompareToTuple1(Convert.ToInt32(num));
                        WriteLine($"Comparison of two Tuple objects having same value is:{comp1}");
                        PressAnyKey();
                        break;
                    case 7:
                        Clear();
                        Write("Enter number: ");
                        var num1 = ReadLine();
                        var namedElement = OddEven.FindOddEvenBySingleNumberNamedElement(Convert.ToInt32(num1));
                        WriteLine($"Number:{namedElement.number} is {namedElement.oddOrEven}.");
                        WriteLine();
                        var equalToTuple = OddEven.EqualToTuple(Convert.ToInt32(num1));
                        WriteLine($"Equality of two Tuple objects is:{equalToTuple}");
                        var equalToObject = OddEven.EqualToObject(Convert.ToInt32(num1));
                        WriteLine(
                            $"Equality of one Tuple object with other non tuple object is:{equalToObject}");
                        PressAnyKey();
                        break;
                    case 8:
                        Clear();
                        WriteLine("C# 7.1 feature: default expression");
                        int thisIsANewDefault = default;
                        int thisIsAnOlderDefault = default;
                        var thisIsAnOlderDefaultAndValid = default(int);
                        //var thisIsNotValid = default; //Not valid, as we cannot assign default to implicit-typed variable
                        const int thisIsANewDefaultConst = default; //valid
                        const int thisIsAnOlderDefaultCont = default; //valid
                        //const int? thisIsInvalid = default; //Invalid, as nullable cannot be declared const

                        WriteLine($"New default:{thisIsANewDefault}. Old default:{thisIsAnOlderDefault}");

                        PressAnyKey();
                        break;
                    case 9:
                        Clear();
                        WriteLine("C# 7.1 feature: Infer tuple names");
                        Write("Enter first number:");
                        var number1 = ReadLine();
                        Write("Enter second number:");
                        var number2 = ReadLine();
                        OddEven.InferTupleNames(Convert.ToInt32(number1), Convert.ToInt32(number2));
                        PressAnyKey();
                        break;
                }
            } while (userInput != 10);
        }

        private static void PressAnyKey()
        {
            Write("Press any key...");
            ReadLine();
            Clear();
        }

        private static int DisplayMenu()
        {
            return Convert.ToInt32(SelectedMenu());
        }


        private static int SelectedMenu()
        {
            WriteLine("Example - Day03");
            WriteLine();
            WriteLine("1. Odd Even from a Single Number");
            WriteLine("2. Odd Even within a Range");
            WriteLine("3. Odd Even from a Series");
            WriteLine("4. Assignment");
            WriteLine("5. Implicit Cast");
            WriteLine("6. Comparison");
            WriteLine("7. Equals");
            WriteLine("8. Default Expression (C# 7.1)");
            WriteLine("9. Infer tuple names (C# 7.1)");
            WriteLine("10. Exit");
            Write("Enter choice (1-10): ");
            var result = ReadLine();
            return string.IsNullOrEmpty(result) ? 0 : Convert.ToInt32(result);
        }
    }
}