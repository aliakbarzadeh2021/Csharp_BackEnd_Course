using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using static System.Console;
using static System.Convert;

namespace Day04
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
                        CallStringCalculatorUpdated();
                        PressAnyKey();
                        break;
                    case 2:
                        Clear();
                        ExceptionExample();
                        PressAnyKey();
                        break;
                    case 3:
                        Clear();
                        FileInputOutputOperation();
                        PressAnyKey();
                        break;
                    case 4:
                        Clear();
                        RegularExpressionExample();
                        PressAnyKey();
                        break;
                    case 5:
                        Clear();
                        IndexerExample();
                        PressAnyKey();
                        break;
                }
            } while (userInput != 6);

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
            WriteLine("Example - Day04: Learn C# in 7-days");
            WriteLine();
            WriteLine("1. Call String CalculatorUpdated.");
            WriteLine("2. Exception Example.");
            WriteLine("3. File Input Output Operation.");
            WriteLine("4. Regular Expression Example.");
            WriteLine("5. Indexer Example.");
            WriteLine("6. Exit");
            Write("Enter choice (1-6): ");
            var result = ReadLine();
            return string.IsNullOrEmpty(result) ? 0 : ToInt32(result);
        }


        private static void IndexerExample()
        {
            WriteLine("Indexer example.");
            Write("Enter person name to search from collection:");
            var name = ReadLine();
            var person = new PersonCollection();
            var result = person[name] ? "exists." : "does not exist.";
            WriteLine($"Person name '{name}' {result}");
        }

        private static void RegularExpressionExample()
        {
            WriteLine("Regular expression example.\n");
            Write("Enter input text to match:");
            var inpuText = ReadLine();
            if (string.IsNullOrEmpty(inpuText))
                inpuText = @"The quick brown fox jumps over the lazy dog.";
            WriteLine("Following is the match based on different pattern:\n");
            const string theDot = @"\.";
            WriteLine("The Period sign [.]");
            ValidateInputText(inpuText,theDot,true);
            const string theword = @"\w";
            WriteLine("The Word sign [w]");
            ValidateInputText(inpuText, theword, true);
            const string theSpace = @"\s";
            WriteLine("The Space sign [s]");
            ValidateInputText(inpuText, theSpace, true);
            const string theSquareBracket = @"\[The]";
            WriteLine("The Square-Brackets sign [( )]");
            ValidateInputText(inpuText, theSquareBracket, true);
            const string theHyphen = @"\[a-z0-9]ww";
            WriteLine("The Hyphen sign [-]");
            ValidateInputText(inpuText, theHyphen, true);
            const string theStar = @"\[a*]";
            WriteLine("The Star sign [*] ");
            ValidateInputText(inpuText, theStar, true);
            const string thePlus = @"\[a+]";
            WriteLine("The Plus sign [+] ");
            ValidateInputText(inpuText, thePlus, true);
        }

        private static void ValidateInputText(string inputText, string regExp,bool isCllection=false,RegexOptions option=RegexOptions.IgnoreCase)
        {
            var regularExp = new Regex(regExp,option);
            
            if (isCllection)
            {
                var matches = regularExp.Matches(inputText);
                foreach (var match in matches)
                {
                    WriteLine($"Text '{inputText}' matches '{match}' with pattern '{regExp}'");
                }
            }
            var singleMatch = Regex.Match(inputText, regExp, option);
            WriteLine($"Text '{inputText}' matches '{singleMatch}' with pattern '{regExp}'");
            ReadLine();

        }

        private static void FileInputOutputOperation()
        {
            const string textLine = "This file is created during practice of C#";
            Write("Enter file name (without extension):");
            var fileName = ReadLine();
            var fileNameWithPath = $"D:/{fileName}.txt";
            using (var fileStream = File.Create(fileNameWithPath))
            {
                var iBytes = new UTF8Encoding(true).GetBytes(textLine);
                fileStream.Write(iBytes, 0, iBytes.Length);
            }
            WriteLine("Write operation is completed.");
            ReadLine();
            using (var fileStream = File.OpenRead(fileNameWithPath))
            {
                var bytes = new byte[1024];
                var encoding = new UTF8Encoding(true);
                while (fileStream.Read(bytes, 0, bytes.Length) > 0)
                    WriteLine(encoding.GetString(bytes));
            }
        }

        private static void ExceptionExample()
        {
            WriteLine("Exaception handling example.");
            var example = new ExceptionhandlingExample();
            Write("Enter dividen:");
            var dividend = ReadLine();
            Write("Enter divisor:");
            var divisor = ReadLine();
            var quotient = example.Div(Convert.ToInt32(dividend), Convert.ToInt32(divisor));
            WriteLine($"Quotient of dividend:{dividend}, divisio:{divisor} is {quotient}");
        }

        private static void CallStringCalculatorUpdated()
        {
            WriteLine("Rules for operation:");
            WriteLine("o This operation should only accept input in a string data type\n" +
                      "o Add operation can take 0, 1, or 2 comma - separated numbers, and will return their sum for example \"1\" or \"1, 2\"\n" +
                      "o Add operation should accept empty string but for an empty string it will return 0.\n" +
                      "o Throw an exception if number > 1000\n");
            var calculator = new StringCalculatorUpdated();
            Write("Enter numbers comma separated:");
            var num = ReadLine();

            Write($"Sum of {num} is {calculator.Add(num)}");
        }
    }
}