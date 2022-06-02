using System;

namespace Example4._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = getCar();
            
            Console.WriteLine($"Model: {car.Item1}");
            Console.WriteLine($"Price: {car.Item2}");
            Console.WriteLine($"Currency: {car.Item3}");

            (string model, double price, string currency) = getCar2();

            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Currency: {currency}");
            Console.ReadKey();
        }

        private static (string, double, string) getCar()
        {
            return ("Tesla Model S", 75000, "USD");
        }

        private static (string Model, double Price, string Currency) getCar2()
        {
            return ("Tesla Model S", 75000, "USD");
        }

        
    }
}
