using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_BackEnd_Course.Beginner.Classes
{
    internal class program
    {
        static void Main(string[] args)
        {
            Person person = new Person("John", "Smith", 44);
            person.Age = 28;
            Console.WriteLine("{0} {1} - age: {2}", person.FirstName, person.LastName, person.Age);

            if (person.Age < Person.MinAge)
            {
                Console.WriteLine("Too young");
            }

            Student std = new Student("John", "Smith", 21);
            std.University = "Harvard University";
            std.AvgGrade = 8;

            Console.WriteLine(std);


            Console.ReadKey();
        }

        static void Main2(string[] args)
        {
            Person p = new Person("John", "Smith", 32);
            if (p is Person)
            {
                Console.WriteLine("p is a Person");
            }
            else
            {
                Console.WriteLine("p is not a Person");
            }

            Student s = new Student("Ann", "Smith", 21, "MIT", 9);
            if (s is Student)
            {
                Console.WriteLine("s is a Student");
            }
            else
            {
                Console.WriteLine("s is not a Student");
            }

            if (s is Person)
            {
                Console.WriteLine("s is a Person");
            }
            else
            {
                Console.WriteLine("s is not a Person");
            }

            if (p is Student)
            {
                Console.WriteLine("p is a Student");
            }
            else
            {
                Console.WriteLine("p is not a Student");
            }

            Console.ReadKey();
        }

        static void Main3(string[] args)
        {
            object obj = new Person("John", "Smith", 32);
            doSomething(obj);

            List<int> list = new List<int>();
            doSomething(list);

            Console.ReadKey();
        }

        private static void doSomething(object o)
        {
            Person p = o as Person;
            if (p == null)
            {
                throw new ArgumentException("Argument is not a person");
            }
            Console.WriteLine(p.FirstName + " " + p.LastName);
        }
    }

    public class Person
    {
        public static int MinAge = 18;
        public static int MaxAge = 70;

        private readonly string _firstName;
        private readonly string _lastName;

        public string FirstName
        {
            get
            {
                return _firstName;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
        }

        public int Age { get; set; }


        private decimal _salary;


        public Person(string firstName, string lastName, int age, decimal salary = 45000)
        {
            _firstName = firstName;
            _lastName = lastName;
            Age = age;

            //default value
            _salary = salary;
        }

        public virtual void SayHello()
        {
            Console.WriteLine("Hello I'm a Person");
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + " - age: " + Age;
        }
    }

    public class Student : Person
    {
        public string University { get; set; }
        public double AvgGrade { get; set; }
        public double Grade { get; set; }

        public Student(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {

        }

        public Student(string firstName, string lastName, int age, string university, double grade) : base(firstName, lastName, age)
        {
            University = university;
            Grade = grade;
        }

        public override void SayHello()
        {
            Console.WriteLine("Hello I'm a student");
        }
    }
}
