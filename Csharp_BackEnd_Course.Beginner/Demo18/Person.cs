using System;
using System.Collections.Generic;
using System.Text;

namespace Example4._7._1
{
    public class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        private IRun _runner;

        public Person(string firstName, string lastName, IRun runner)
        {
            FirstName = firstName;
            LastName = lastName;
            _runner = runner ?? throw new ArgumentNullException("runner");
        }

        public void Run(int distance)
        {
            _runner.Run(distance);
        }
    }
}
