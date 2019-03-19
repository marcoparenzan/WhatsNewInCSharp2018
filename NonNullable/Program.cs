using System;

using static System.Console;

//[module: System.Runtime.CompilerServices.NonNullTypes(true)]

namespace WhatsNewWithCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person x = new Person("Mario", "Rossi");
            int length = GetLengthOfMiddleName(x);

            WriteLine(length);
        }

        private static int GetLengthOfMiddleName(Person x)
        {
            return x.MiddleName.Length;
        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            MiddleName = null;
            LastName = lastName;
        }

        public Person(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        public void Deconstruct(out string firstName, out string middleName, out string lastName)
        {
            firstName = FirstName;
            middleName = MiddleName;
            lastName = LastName;
        }

    }
}
