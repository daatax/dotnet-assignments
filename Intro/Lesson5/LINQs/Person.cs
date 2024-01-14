using System;

namespace Intro.Lesson5.LINQs
{
    // Given a list of Person objects (with properties like Name and Age),
    // write a C# program that uses LINQ to perform the following tasks:
    // Filter out people who are older than 30.
    // Create a new list containing only the names of the filtered people.Display the names.
    internal class Person
    {
        private string Name { get; }
        public int Age { get; }

        public Person(string name, int age) {
            Name = name;
            Age = age;
        }

        /// <summary>
        /// Filters people over 30 years old, and returns a List with their names. 
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        public static List<string> FilterPeopleOver30(List<Person> people) {
            var peopleOver30 = from person in people
                               where person.Age >= 30
                               select person.Name;

            return peopleOver30.ToList();
        }

        /// <summary>
        /// Prints the given list.
        /// </summary>
        /// <param name="list"></param>
        public static void PrintList(List<string> list) {
            int index = 0;
            foreach (string str in list) {
                if (index == 0) {
                    Console.Write("[" + str + ", ");
                    index++;
                }
                else if (index == list.Count - 1) {
                    Console.Write(str + "]");
                    index++;
                }
                else {
                    Console.Write(str + ", ");
                    index++;
                }
            }
        }
    }
}