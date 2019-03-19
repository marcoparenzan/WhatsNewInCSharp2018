using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;

namespace WhatsNewWithCSharp
{
    static class Program
    {
        static void Main(string[] args)
        {
            WriteLine(ToText(new Student {
                Name = "Mario", @Class = 1
            }));
            ReadLine();
        }

        static string ToText(object o)
        {
            //if (o is String s)
            //{

            //}

            //switch (o)
            //{
            //    case String s:
            //        break;
            //    case Person s when s.Type == nameof(Student):
            //        break;
            //    case Person t when t.Type == nameof(Teacher):
            //        break;
            //}
            var text = o switch
            {
                Person { Type: nameof(Student), Name: var n } => n,
                _ => "other"
            };

            return text;
        }
    }

    abstract class Person
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public void Deconstruct(out string name, out string type)
        {
            name = Name;
            type = Type;
        }
    }

    class Student : Person
    {
        public Student() => Type = nameof(Student);

        public int Class { get; set; }

        public void Deconstruct(out string name, out int @class)
        {
            name = Name;
            @class = Class;
        }
    }

    class Teacher : Person
    {
        public Teacher() => Type = nameof(Teacher);

        public string Title { get; set; }
        public string B { get; set; }
    }

}
