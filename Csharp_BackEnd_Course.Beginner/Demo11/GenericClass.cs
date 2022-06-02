using System;
using System.Collections.Generic;

namespace Day06
{
    public class Person
    {
        private static readonly IEnumerable<Person> PersonList = CreatePersonList();
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public static IEnumerable<Person> GetPersonList()
        {
            return PersonList;
        }

        private static IEnumerable<Person> CreatePersonList()
        {
            IList<Person> persons = new List<Person>
            {
                new Person
                {
                    Id = 1,
                    FirstName = "Denim",
                    LastName = "Pinto",
                    Age = 31
                },
                new Person
                {
                    FirstName = "Vikas",
                    LastName = "Tiwari",
                    Age = 25
                },
                new Person
                {
                    Id = 2,
                    FirstName = "Shivprasad",
                    LastName = "Koirala",
                    Age = 40
                },
                new Person
                {
                    Id = 3,
                    FirstName = "Gaurav",
                    LastName = "Aroraa",
                    Age = 43
                }
            };

            return persons;
        }

        private IEnumerable<T> CreateGenericList<T>()
        {
            IList<T> persons = new List<T>();

            //other stuffs

            return persons;
        }
    }

    [Obsolete("Do not use this class use 'Person' instead.")]
    public class Author : Person
    {
        //other stuff goes here
    }

    public class ClassWithDefautConstructor
    {
        public string Name { get; set; }
    }

    public class EntityClass : IDisposable
    {
        public string Name { get; set; }

        public void Dispose()
        {
            //dispose code goes here
        }
    }
}