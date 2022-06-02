using System;

namespace Day03Lib
{
    public class Employee
    {
        public Guid EmplId { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public char Sex { get; set; }
        public string DepartmentId { get; set; }
        public string Designation { get; set; }
    }

    public class UserDefinedModel
    {
        public UserDefinedModel(int number, string oddEven)
        {
            Number = number;
            OddEven = oddEven;
        }

        public UserDefinedModel()
        {
        }

        public int Number { get; set; }
        public string OddEven { get; set; }

        public void Deconstruct(out int number, out string oddEven)
        {
            number = Number;
            oddEven = OddEven;
        }
    }
}