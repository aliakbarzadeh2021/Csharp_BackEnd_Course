using System;

namespace Example4._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("John", "Smith", 23);
            int age = p.GetAge();
            ref int ageRef = ref p.GetAge();
            ageRef++;
            Console.WriteLine(p);
            Console.ReadKey();
        }

        static void Main2(string[] args)
        {
            calculate(8, 2, out var sum, out var diff);
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Diff: {diff}");
            Console.ReadKey();
        }

        private static void calculate(int a, int b, out int sum, out int diff)
        {
            sum = a + b;
            diff = a - b;
        }

    }

    public class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        private int _age;

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            _age = age;
        }

        public ref int GetAge()
        {
            return ref _age;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} / {_age}";
        }
    }
}
