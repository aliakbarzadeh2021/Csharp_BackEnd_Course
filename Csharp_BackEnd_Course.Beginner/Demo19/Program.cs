using System;
using System.IO;

namespace Example7._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Machine machine = new Machine();
            machine.RegisterTempWatcher(LogTempToConsole);
            machine.RegisterTempWatcher(LogTempToFile);
            machine.TurnOn();
            Console.ReadKey();
        }

        private static void LogTempToConsole(double prev, double current)
        {
            Console.WriteLine($"Temperature changed from {prev} to {current}");
        }

        private static async void LogTempToFile(double prev, double current)
        {
            using (StreamWriter writer = new StreamWriter("temps.txt", true))
            {
                await writer.WriteLineAsync($"Machine temperature changed from {prev} to {current}");
            }
        }
    }
}
