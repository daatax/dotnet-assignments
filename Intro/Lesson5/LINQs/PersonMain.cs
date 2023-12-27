using System;
using System.Collections.Generic;

namespace Intro.Lesson5.LINQs
{
    // Given a list of Person objects (with properties like Name and Age),
    // write a C# program that uses LINQ to perform the following tasks:
    // Filter out people who are older than 30.
    // Create a new list containing only the names of the filtered people.Display the names.
    internal class PersonMain
    {
        public static void Main(string[] args) {

            List<Person> people = new List<Person>() {
            new Person("Jack", 23),
            new Person("Ellie", 53),
            new Person("Bill", 30),
            new Person("Seven", 19),
            new Person("Damien", 46),
            new Person("Ammy", 28),
        };

            Console.WriteLine("List of people after filtering out... ");

            List<string> filtered = Person.FilterPeopleOver30(people);
            Person.PrintList(filtered);
        }
    }
}