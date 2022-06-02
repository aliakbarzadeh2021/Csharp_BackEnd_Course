using System;
using System.Collections.Generic;
using System.Text;

namespace Example4._2._1
{
    public enum EmployeeType
    {
        Salaried,
        Hourly
    }

    public class Employee : Person
    {
        public EmployeeType Type { get; set; }

        public Employee(string firstName, string lastName, int age, EmployeeType type) : base(firstName, lastName, age)
        {
            Type = type;
        }
    }
}
