using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day03Lib
{
    public class PatternMatching
    {
        private static IEnumerable<char> Vowels => new[] {'a', 'e', 'i', 'o', 'u'};

        public static string MatchingPatterUsingIs(object character)
        {
            if (character is null)
                return $"{nameof(character)} is null. ";
            if (character is char)
                return $"{character} is char and {VowelOrConsonent((char) character)}.";
            if (character is string str)
            {
                var chars = str.ToArray();
                var stringBuilder = new StringBuilder();
                foreach (var c in chars)
                    if (!char.IsWhiteSpace(c))
                    {
                        var isVowel = VowelOrConsonent(c);
                        stringBuilder.AppendLine($"{c} is char of string '{character}' and {isVowel}.");
                    }

                return stringBuilder.ToString();
            }

            if (character is int number)
                return $"{nameof(character)} is int {number}.";
            throw new ArgumentException(
                "character is not a recognized data type.",
                nameof(character));
        }

        public static string ConstantPatternUsingSwitch(params char[] inputChar)
        {
            switch (inputChar.Length)
            {
                case 0:
                    return $"{nameof(inputChar)} contains no elements.";
                case 1:
                    return $"'{inputChar[0]}' and {VowelOrConsonent(inputChar[0])}.";
                case 2:
                    var sb = new StringBuilder().AppendLine($"'{inputChar[0]}' and {VowelOrConsonent(inputChar[0])}.");
                    sb.AppendLine($"'{inputChar[1]}' and {VowelOrConsonent(inputChar[1])}.");
                    return sb.ToString();
                case 3:
                    var sb1 = new StringBuilder().AppendLine($"'{inputChar[0]}' and {VowelOrConsonent(inputChar[0])}.");
                    sb1.AppendLine($"'{inputChar[1]}' and {VowelOrConsonent(inputChar[1])}.");
                    sb1.AppendLine($"'{inputChar[2]}' and {VowelOrConsonent(inputChar[2])}.");
                    return sb1.ToString();
                case 4:
                    var sb2 = new StringBuilder().AppendLine($"'{inputChar[0]}' and {VowelOrConsonent(inputChar[0])}.");
                    sb2.AppendLine($"'{inputChar[1]}' and {VowelOrConsonent(inputChar[1])}.");
                    sb2.AppendLine($"'{inputChar[2]}' and {VowelOrConsonent(inputChar[2])}.");
                    sb2.AppendLine($"'{inputChar[3]}' and {VowelOrConsonent(inputChar[3])}.");
                    return sb2.ToString();
                case 5:
                    var sb3 = new StringBuilder().AppendLine($"'{inputChar[0]}' and {VowelOrConsonent(inputChar[0])}.");
                    sb3.AppendLine($"'{inputChar[1]}' and {VowelOrConsonent(inputChar[1])}.");
                    sb3.AppendLine($"'{inputChar[2]}' and {VowelOrConsonent(inputChar[2])}.");
                    sb3.AppendLine($"'{inputChar[3]}' and {VowelOrConsonent(inputChar[3])}.");
                    sb3.AppendLine($"'{inputChar[4]}' and {VowelOrConsonent(inputChar[4])}.");
                    return sb3.ToString();
                default:
                    return $"{inputChar.Length} exceeds from maximum input length.";
            }
        }

        public static string TypePatternUsingSwitch(IEnumerable<object> inputObjects)
        {
            var message = new StringBuilder();
            foreach (var inputObject in inputObjects)
                switch (inputObject)
                {
                    case char c:
                        message.AppendLine($"{c} is char and {VowelOrConsonent(c)}.");
                        break;
                    case IEnumerable<object> listObjects:
                        foreach (var listObject in listObjects)
                            message.AppendLine(MatchingPatterUsingIs(listObject));
                        break;
                    case null:
                        break;
                }
            return message.ToString();
        }

        public static string TypePatternWhenInCaseUsingSwitch(IEnumerable<object> inputObjects)
        {
            var message = new StringBuilder();
            foreach (var inputObject in inputObjects)
                switch (inputObject)
                {
                    case char c:
                        message.AppendLine($"{c} is char and {VowelOrConsonent(c)}.");
                        break;
                    case IEnumerable<object> listObjects when listObjects.Any():
                        foreach (var listObject in listObjects)
                            message.AppendLine(MatchingPatterUsingIs(listObject));
                        break;
                    case IEnumerable<object> listInlist:
                        break;
                    case null:
                        break;
                }
            return message.ToString();
        }

        private static string VowelOrConsonent(char c)
        {
            return IsVowel(c) ? "is a vowel" : "is a consonent";
        }

        private static bool IsVowel(char character)
        {
            return Vowels.Contains(char.ToLower(character));
        }
    }
}