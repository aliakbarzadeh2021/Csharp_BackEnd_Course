using System;
using static System.Console;

namespace Day06
{
    public class ErrorLogger : Attribute
    {
        public ErrorLogger(string exception)
        {
            switch (Env)
            {
                case Env.Debug:
                case Env.Dev:
                    WriteLine($"{exception}");
                    throw new Exception(exception);
                case Env.Prod:
                    WriteLine($"{exception}");
                    break;
                default:
                    WriteLine($"{exception}");
                    throw new Exception(exception);
            }
        }


        public Env Env { get; set; }
    }

    public enum Env
    {
        Debug,
        Dev,
        Prod
    }


    public class MathClass
    {
        [ErrorLogger("Add Math opetaion in development", Env = Env.Debug)]
        public string Add(int num1, int num2)
        {
            return $"Sum of {num1} and {num2} = {num1 + num2}";
        }

        [ErrorLogger("Substract Math opetaion in development", Env = Env.Dev)]
        public string Substract(int num1, int num2)
        {
            return $"Substracrion of {num1} and {num2} = {num1 - num2}";
        }

        [ErrorLogger("Multiply Math opetaion in development", Env = Env.Prod)]
        public string Multiply(int num1, int num2)
        {
            return $"Multiplication of {num1} and {num2} = {num1 - num2}";
        }
    }

    public class FilePolling
    {
        public void PoleAFile(string fileName)
        {
            Console.Write($"This is polling file: {fileName}");
            //file polling stuff goes here
        }
        public async void PoleAFileAsync(string fileName)
        {
            Console.Write($"This is polling file: {fileName}");
            //file polling async stuff goes here
        }
    }
}