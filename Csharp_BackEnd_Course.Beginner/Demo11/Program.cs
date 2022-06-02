using System;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using static System.Console;
using static System.Convert;

namespace Day06
{
    internal class Program
    {
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
                        PersonList();
                        PressAnyKey();
                        break;
                    case 2:
                        Clear();
                        NonGenericListWithAuthorNameAndAge();
                        PressAnyKey();
                        break;
                    case 3:
                        Clear();
                        ImplementValueTypeGenericClass();
                        PressAnyKey();
                        break;
                    case 4:
                        Clear();
                        ImplementReferenceTypeGenericClass();
                        PressAnyKey();
                        break;
                    case 5:
                        Clear();
                        ImplementDefaultConstructorGenericClass();
                        PressAnyKey();
                        break;
                    case 6:
                        Clear();
                        ImplementInterfaceConstraint();
                        PressAnyKey();
                        break;
                    case 7:
                        Clear();
                        TestCustomAttribute();
                        PressAnyKey();
                        break;
                    case 8:
                        Clear();
                        TestPreprocessorDirective();
                        PressAnyKey();
                        break;
                    case 9:
                        Clear();
                        TestLinq();
                        PressAnyKey();
                        break;
                    case 10:
                        Clear();
                        TestUnsafeSwap();
                        PressAnyKey();
                        break;
                    case 11:
                        Clear();
                        BitArrayBoolArrayPerformance();
                        PressAnyKey();
                        break;

                }
            } while (userInput != 12);
        }

        private static void BitArrayBoolArrayPerformance()
        {
            //This is a simple test
            //Not testing bitwiseshift  etc.
            WriteLine("BitArray vs. Bool Array performance test.\n");
            WriteLine($"Total elements of bit array: {int.MaxValue}");
            PressAnyKey();
            WriteLine("Starting BitArray Test:");
            var bitArrayTestResult = BitArrayTest(int.MaxValue);
            WriteLine("Ending BitArray Test:");
            WriteLine("Time time elapsed: {0:hh\\:mm\\:ss} ",  TimeSpan.FromMilliseconds(bitArrayTestResult));

            WriteLine("\nStarting BoolArray Test:");
            WriteLine($"Total elements of bit array: {int.MaxValue}");
            PressAnyKey();
            var boolArrayTestResult = BoolArrayTest(int.MaxValue);
            WriteLine("Ending BitArray Test:");
            WriteLine("Time time elapsed: {0:hh\\:mm\\:ss} ", TimeSpan.FromMilliseconds(boolArrayTestResult));
        }

        private static long BitArrayTest(int max)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            var bitarray = new BitArray(max);
            for (int index = 0; index < bitarray.Length; index++)
            {
                bitarray[index] = !bitarray[index];
                WriteLine($"'bitarray[{index}]' = {bitarray[index]}");
            }
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }
        private static long BoolArrayTest(int max)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            var boolArray = new bool[max];
            for (int index = 0; index < boolArray.Length; index++)
            {
                boolArray[index] = !boolArray[index];
                WriteLine($"'boolArray[{index}]' = {boolArray[index]}");
            }
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
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
            WriteLine("Example - Day06: Learn C# in 7-days");
            WriteLine();
            WriteLine("1. Person List.");
            WriteLine("2. NonGeneric List With Author Name and Age.");
            WriteLine("3. Implement Value TypeGeneric Class.");
            WriteLine("4. Implement Reference Type GenericClass.");
            WriteLine("5. Implement Default Constructor Generic Class.");
            WriteLine("6. Implement Interface Constraint.");
            WriteLine("7. Test Custom Attribute.");
            WriteLine("8. Test Preprocessor Directive.");
            WriteLine("9. Test Linq.");
            WriteLine("10. Test Unsafe Swap.");
            WriteLine("11. BitArray vs. Bool Array performance test.");
            WriteLine("12. Exit");
            Write("Enter choice (1-12): ");
            var result = ReadLine();
            return string.IsNullOrEmpty(result) ? 0 : ToInt32(result);
        }


        private static unsafe void TestUnsafeSwap()
        {
            Write("Enter first number:");
            var num1 = Convert.ToInt32(ReadLine());
            Write("Enter second number:");
            var num2 = Convert.ToInt32(ReadLine());
            WriteLine("Before calling swap function:");
            WriteLine($"Number1:{num1}, Number2:{num2}");
            //call swap
            new UnsafeSwap().SwapNumbers(&num1, &num2);
            WriteLine("After calling swap function:");
            WriteLine($"Number1:{num1}, Number2:{num2}");
        }

        private static void TestLinq()
        {
            var person = from p in Person.GetPersonList()
                         where p.Id == 1
                         select p;
            foreach (var per in person)
            {
                WriteLine($"Person Id:{per.Id}");
                WriteLine($"Name:{per.FirstName} {per.LastName}");
                WriteLine($"Age:{per.Age}");
            }

        }

        private static void TestPreprocessorDirective()
        {
            var precessor = new PreprocessorDirective();
            precessor.ConditionalProcessor();
            precessor.LinePreprocessor();
            precessor.WarningPreProcessor();
        }

        private static void TestCustomAttribute()
        {
            Write("Enter number 1:");
            var num1 = ReadLine();
            Write("Enter number 2:");
            var num2 = ReadLine();

            WriteLine(new MathClass().Add(Convert.ToInt32(num1), Convert.ToInt32(num2)));
        }

        private static void NonGenericListWithAuthorNameAndAge()
        {
            //No exception at compile-time or run-time
            var authorArrayList = new ArrayList { "Gaurav Aroraa", "43" };
            foreach (string author in authorArrayList)
                WriteLine($"{author}");

            //No exception at compile-time but will throw exception at run-time
            var editorArrayList = new ArrayList { "Vikas Tiwari", 25 }; //throws exception at run-time
            foreach (int editor in editorArrayList)
                WriteLine($"{editor}");

            //No exception at compile-time or run-time
            var authorEditorArrayList = new ArrayList { "Gaurav Arora", 43, "Vikas Tiwari", 25 };
            foreach (var authorEditor in authorEditorArrayList)
                WriteLine($"{authorEditor}");
        }

        private static void PersonList()
        {
            WriteLine("Person list:");
            foreach (var person in Person.GetPersonList())
            {
                WriteLine($"Name:{person.FirstName} {person.LastName}");
                WriteLine($"Age:{person.Age}");
            }
        }

        private static void ImplementReferenceTypeGenericClass()
        {
            const string thisIsAuthorName = "Gaurav Aroraa";
            var referenceTypeConstraint = new ReferenceTypeConstraint<string>();
            WriteLine($"Name:{referenceTypeConstraint.ImplementIt(thisIsAuthorName)}");

            var referenceTypePersonConstraint = new ReferenceTypeConstraint<Person>();


            var person = referenceTypePersonConstraint.ImplementIt(new Person
            {
                FirstName = "Gaurav",
                LastName = "Aroraa",
                Age = 43
            });
            WriteLine($"Name:{person.FirstName}{person.LastName}");
            WriteLine($"Age:{person.Age}");
        }

        private static void ImplementValueTypeGenericClass()
        {
            const int age = 43;
            var valueTypeConstraint = new ValueTypeConstraint<int>();
            WriteLine($"Age:{valueTypeConstraint.ImplementIt(age)}");
        }

        private static void ImplementDefaultConstructorGenericClass()
        {
            var constructorConstraint = new DefaultConstructorConstraint<ClassWithDefautConstructor>();
            var result = constructorConstraint.ImplementIt(new ClassWithDefautConstructor { Name = "Gaurav Aroraa" });
            WriteLine($"Name:{result.Name}");
        }

        private static void ImplementBaseClassConstraint()
        {
            var baseClassConstraint = new BaseClassConstraint<Author>();
            var result = baseClassConstraint.ImplementIt(new Author
            {
                FirstName = "Shivprasad",
                LastName = "Koirala",
                Age = 40
            });

            WriteLine($"Name:{result.FirstName} {result.LastName}");
            WriteLine($"Age:{result.Age}");
        }

        private static void ImplementInterfaceConstraint()
        {
            var entityConstraint = new InterfaceConstraint<EntityClass>();
            var result = entityConstraint.ImplementIt(new EntityClass { Name = "Gaurav Aroraa" });
            WriteLine($"Name:{result.Name}");
        }

        [PeerInformation("Level1 is completed.")]
        private void PeerOperation()
        {
            //other stuffs
        }
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class PeerInformationAttribute : Attribute
    {
        public PeerInformationAttribute(string information)
        {
            WriteLine(information);
        }
    }
}