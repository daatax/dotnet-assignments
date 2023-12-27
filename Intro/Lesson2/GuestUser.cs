using System;

namespace Intro.Lesson2
{
    internal class GuestUser
    {
        public static void Main(string[] args) {
            Console.WriteLine("Please enter your name ...");
            string? enteredName = Console.ReadLine();
            string checkedName = string.IsNullOrEmpty(enteredName) ? "Guest" : enteredName;
            Console.WriteLine("Welcome " + checkedName);
        }
    }
}
