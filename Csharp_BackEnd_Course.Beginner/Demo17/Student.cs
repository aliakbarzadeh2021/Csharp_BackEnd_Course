using System;
using System.Collections.Generic;
using System.Text;

namespace Example4._2._1
{
    public enum StudentLevel
    {
        HighSchool,
        Undergrad,
        Postgrad
    }

    public class Student : Person
    {
        public StudentLevel Level { get; set; }

        public Student(string firstName, string lastName, int age, StudentLevel level) : base(firstName, lastName, age)
        {
            Level = level;
        }
    }
}
