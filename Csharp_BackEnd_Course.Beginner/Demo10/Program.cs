using System;
using Day05.Lib;
using static System.Console;
using static System.Convert;


namespace Day05
{
    internal class Program
    {
        private static PrintFizzBuzz _printFizzBuzz;

        private static void Main(string[] args)
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
                        var objectOddEven = new OddEven();
                        var result = objectOddEven.PrintSingleOddEven(ToInt32(number));
                        WriteLine($"Number:{number} is {result}");
                        PressAnyKey();
                        break;
                    case 2:
                        Clear();
                        Write("Enter number: ");
                        var num = ReadLine();
                        var objInstance = Activator.CreateInstance(typeof(OddEven));
                        var method = typeof(OddEven).GetMethod("PrintSingleOddEven");
                        var res = method.Invoke(objInstance, new object[] {ToInt32(num)});
                        WriteLine($"Number:{num} is {res}");

                        PressAnyKey();
                        break;
                    case 3:
                        Clear();
                        WriteLine("Getting information using 'typeof' operator for class 'Day05.Program'");
                        var typeInfo = typeof(Program);
                        typeInfo.GetConstructor(new[] {typeof(Program)});
                        WriteLine();
                        WriteLine("Analysis result(s):");
                        WriteLine("=========================");
                        WriteLine($"Assembly:{typeInfo.AssemblyQualifiedName}");
                        WriteLine($"Name:{typeInfo.Name}");
                        WriteLine($"Full Name:{typeInfo.FullName}");
                        WriteLine($"Namespace:{typeInfo.Namespace}");
                        WriteLine("=========================");
                        PressAnyKey();
                        break;
                    case 4:
                        Clear();
                        WriteLine("Getting information using 'GetType()' method for class 'Day05.Program'");
                        var info = Type.GetType("Day05.Program");
                        WriteLine();
                        WriteLine("Analysis result(s):");
                        WriteLine("=========================");
                        WriteLine($"Assembly:{info.AssemblyQualifiedName}");
                        WriteLine($"Name:{info.Name}");
                        WriteLine($"Full Name:{info.FullName}");
                        WriteLine($"Namespace:{info.Namespace}");
                        WriteLine("=========================");
                        PressAnyKey();
                        break;
                    case 5:
                        Clear();
                        WriteLine("Getting information using System.Reflection.Extensins class");
                        var information = typeof(OddEven);
                        var cons = information.GetConstructor(new[] {information});
                        WriteLine();
                        WriteLine("Analysis result(s):");
                        WriteLine("=========================");
                        WriteLine($"Assembly:{information.AssemblyQualifiedName}");
                        WriteLine($"Name:{information.Name}");
                        WriteLine($"Full Name:{information.FullName}");
                        WriteLine($"Namespace:{information.Namespace}");
                        WriteLine($"Namespace:{information.GetConstructor(new[] {information})}");
                        WriteLine("=========================");
                        PressAnyKey();
                        break;
                    case 6:
                        Clear();
                        Write("Enter number: ");
                        var inputNum = ReadLine();
                        _printFizzBuzz = FizzBuzz.PrintFizzBuzz;
                        var fizzBuzImpl = new FizzBuzzImpl();
                        WriteLine("using delegate:");
                        WriteLine($"Entered number:{inputNum} is {_printFizzBuzz(ToInt32(inputNum))}");
                        WriteLine();
                        WriteLine("using event:");
                        WriteLine($"Entered number:{inputNum} is {fizzBuzImpl.EventImplementation(ToInt32(inputNum))}");
                        PressAnyKey();

                        break;
                    case 7:
                        Clear();
                        Write("Enter arrayList size: ");
                        var inputSize = ReadLine();
                        var arrayListExample = new CollectionGeneric();
                        arrayListExample.ArrayListExample(ToInt32(inputSize));
                        PressAnyKey();
                        break;
                    case 8:
                        Clear();
                        new CollectionGeneric().HashTableExample();
                        PressAnyKey();
                        break;
                    case 9:
                        Clear();
                        new CollectionGeneric().SortedListExample();
                        PressAnyKey();
                        break;
                    case 10:
                        Clear();
                        new CollectionGeneric().StackExample();
                        PressAnyKey();
                        break;
                    case 11:
                        Clear();
                        new CollectionGeneric().QueueExample();
                        PressAnyKey();
                        break;
                }
            } while (userInput != 12);
        }

        private static void PressAnyKey()
        {
            Write("Press any key...");
            ReadLine();
            Clear();
        }

        private static int DisplayMenu()
        {
            return ToInt32(SelectedMenu());
        }

        private static int SelectedMenu()
        {
            WriteLine("Example - Day05: Learn C# in 7-days");
            WriteLine();
            WriteLine("1. Find Odd Even without reflection.");
            WriteLine("2. Find Odd Even using reflection.");
            WriteLine("3. Showing power of System.Type class - use typeof.");
            WriteLine("4. Showing power of System.Type class - use GetType().");
            WriteLine("5. Complete information using System.Reflection.Extensins class.");
            WriteLine("6. Delegates, Events Example");
            WriteLine("7. ArrayList Example");
            WriteLine("8. HashTable Example");
            WriteLine("9. SortedList Example");
            WriteLine("10. Stack Example");
            WriteLine("11. Queue Example");
            WriteLine("12. Exit");
            Write("Enter choice (1-11): ");
            var result = ReadLine();
            return string.IsNullOrEmpty(result) ? 0 : ToInt32(result);
        }

        private delegate string PrintFizzBuzz(int number);
    }
}