using System;

namespace ReturnByReference
{
    static class Program
    {
        static void Main()
        {
            PassValueTypesByReference.Run();
            //PassReferenceTypesByReference.Run();
            //ReferenceReturnValues.Run();
        }
    }

    /// <summary>
    /// Reference return values are values that a method returns by reference
    /// back to the caller. That is, the caller can modify the value returned
    /// by a method, and that change is reflected in the state of the object
    /// that contains the method.
    /// </summary>
    public static class ReferenceReturnValues
    {
        public static void Run()
        {
            var ec = new EngineerCollection();
            ec.ListEngineers();
            Console.WriteLine();

            ref var engineer = ref ec.FindBySurname("Holmes");
            if (engineer != null)
                engineer = new Engineer("Simon", "Hughes");
            ec.ListEngineers();
        }
    }

    /// <summary>
    /// Using the ref keyword to pass value types by reference, not by value.
    /// This enables the called method to replace the value to which
    /// the reference parameter refers in the caller.
    /// </summary>
    public static class PassValueTypesByReference
    {
        public static void Run()
        {
            var number = 0;

            Calculate(ref number);
            Console.WriteLine(number);

            Calculate(ref number);
            Console.WriteLine(number);

            number = 100;
            Calculate(ref number);
            Console.WriteLine(number);
        }

        // An argument that is passed as a ref or in parameter must be initialized
        // before it is passed.
        // Out parameters however do not have to be initialized before they are passed.
        private static void Calculate(ref int number)
        {
            number += 11;
        }
    }

    /// <summary>
    /// Using the ref keyword to pass reference types by reference.
    /// This enables the called method to replace the object to which
    /// the reference parameter refers in the caller.
    /// </summary>
    public static class PassReferenceTypesByReference
    {
        public static void Run()
        {
            var engineers = GetEngineers();
            Console.WriteLine("Original values");
            ListEngineers(engineers);

            Console.WriteLine();
            Console.WriteLine("Alter engineer by reference");
            ModifyEngineerNameByReference(ref engineers[1]);
            ListEngineers(engineers);

            Console.WriteLine();
            Console.WriteLine("Indirect, but uses same engineer object");
            var joe = engineers[0];
            ModifyEngineerNameByReference(ref joe);
            ListEngineers(engineers);

            Console.WriteLine();
            Console.WriteLine("Create a new engineer using the joe variable above");
            CreateNewEngineer(ref joe);
            ListEngineers(engineers);
            Console.WriteLine($"joe variable = {joe}");

            Console.WriteLine();
            Console.WriteLine("Create a new engineer using the array reference");
            CreateNewEngineer(ref engineers[2]);
            ListEngineers(engineers);
        }

        private static void ListEngineers(Engineer[] engineers)
        {
            var n = 0;
            foreach (var engineer in engineers)
            {
                Console.WriteLine($"{n++}: {engineer}");
            }
        }

        private static void ModifyEngineerNameByReference(ref Engineer engineer)
        {
            engineer.Forename = engineer.Forename.ToLowerInvariant();
            engineer.Surname = engineer.Surname.ToLowerInvariant();
        }

        private static void CreateNewEngineer(ref Engineer engineer)
        {
            engineer.Forename = "XXXXXX";
            // Think of a reference as a pointer to some memory
            // Here, we are changing the pointer to point at a new engineer
            engineer = new Engineer("Simon", "Hughes");
        }

        private static Engineer[] GetEngineers()
        {
            return new[]
            {
                new Engineer("Joe", "Bloggs"),
                new Engineer("Fred", "Ginger"),
                new Engineer("Sherlock", "Holmes")
            };
        }
    }

    public class EngineerCollection
    {
        //todo: Make collection redonly
        private Engineer[] _engineers =
        {
            new Engineer("Joe", "Bloggs"),
            new Engineer("Fred", "Ginger"),
            new Engineer("Sherlock", "Holmes")
        };

        private Engineer _noEngineer;

        public ref Engineer FindBySurname(string surname)
        {
            for (var n = 0; n < _engineers.Length; ++n)
            {
                if (_engineers[n].Surname == surname)
                    return ref _engineers[n];
            }
            return ref _noEngineer;
        }

        public void ListEngineers()
        {
            var n = 0;
            foreach (var engineer in _engineers)
            {
                Console.WriteLine($"{n++}: {engineer}");
            }
        }
    }

    public class Engineer
    {
        public string Forename { get; set; }
        public string Surname { get; set; }

        public Engineer(string forename, string surname)
        {
            Forename = forename;
            Surname = surname;
        }

        public override string ToString()
        {
            return $"{Forename} {Surname}";
        }
    }
}
