using System.Collections.Generic;
using System.Linq;

namespace Day04
{
    public class PersonCollection
    {
        private readonly string[] _persons = Persons();

        public bool this[string name] => IsValidPerson(name);

        private bool IsValidPerson(string name) => _persons.Any(person => person == name);

        private static string[] Persons() => new[] {"Shivprasad","Denim","Vikas","Merint","Gaurav"};
    }
}