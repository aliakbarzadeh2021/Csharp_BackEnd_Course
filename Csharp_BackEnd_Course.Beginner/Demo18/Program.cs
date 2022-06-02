using System;

namespace Example4._7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person p = new Person("John", "Smith", new SlowRunner());
                p.Run(9);
            }
            catch(ArgumentNullException e)
            {
                Console.WriteLine("Runner cannot be null");
            }
            catch(Exception e)
            {
                Console.WriteLine("Oops something went wrong");
            }
            Console.ReadKey();       
        }
    }
}
