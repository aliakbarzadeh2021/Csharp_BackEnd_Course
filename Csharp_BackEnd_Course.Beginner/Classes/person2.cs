using System;
using System.Collections.Generic;
using System.Text;

namespace Example4._6._1
{
    internal class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string FullName => $"{FirstName} {LastName}";

        private int _age;

        public int Age
        {
            get => _age;
            set => _age = value;
        }

        public Person(string firstName, string lastName, int age) => init(firstName, lastName, age);

        private void init(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        ~Person() => Console.WriteLine("Finalizing Person object");

        public override string ToString() => FullName;
    }
}
