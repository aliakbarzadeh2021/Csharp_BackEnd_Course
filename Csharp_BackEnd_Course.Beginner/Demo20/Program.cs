using System;
using System.IO;

namespace Example7._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Machine machine = new Machine();
            machine.RegisterTempWatcher( (double prev, double current) =>
            {
                Console.WriteLine($"Temperature changed from {prev} to {current}");
            });
            machine.RegisterTempWatcher( async (double prev, double current) =>
            {
                using (StreamWriter writer = new StreamWriter("temps.txt", true))
                {
                    await writer.WriteLineAsync($"Machine temperature changed from {prev} to {current}");
                }
            });
            machine.TurnOn();
            Console.ReadKey();
        }
    }
}
