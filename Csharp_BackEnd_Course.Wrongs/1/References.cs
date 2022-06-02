using System;

namespace References
{
    class Program
    {
        static void Main(string[] args)
        {
            //Goal is to add Greetings to each element of the array.
            var ninjas = new[] { "Itachi", "Kisame", "Naruto" };
            foreach (var ninja in ninjas)
            {
                AddGreeting(ninja);
            }
            foreach (var ninja in ninjas)
            {
                Console.WriteLine(ninja);
            }
        }

        static void AddGreeting(string ninja)
            => ninja = "Greetings " + ninja;

        static void MainRef(string[] args)
        {
            var ninjas = new[] { "Itachi", "Kisame", "Naruto" };
            for (var i = 0; i < 3; i++)
            {
                AddGreeting(ref ninjas[i]);
            }
            foreach (var ninja in ninjas)
            {
                Console.WriteLine(ninja);
            }
        }
        static void AddGreeting(ref string ninja)
            => ninja = "Greetings " + ninja;
    }
}
