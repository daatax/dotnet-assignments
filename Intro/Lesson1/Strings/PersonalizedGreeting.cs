using System;

namespace Intro.Lesson1.Strings
{
    internal class PersonalizedGreeting
    {
        public static void Main(string[] args) {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            Console.WriteLine("Hey " + firstName + " " + lastName + "! You've successfully used the application.");
            Console.ReadKey();
        }
    }
}
