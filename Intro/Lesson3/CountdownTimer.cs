using System;

namespace Intro.Lesson3
{
    internal class CountdownTimer
    {
        // Countdown Timer - Build a countdown timer that takes a positive integer as input and counts down from that number to 1, printing each value. Use a while loop.
        public static void Main(string[] args) {
            if (IsInputNumberValid("Please enter a number ...", out int number) && number > 0) {
                Console.WriteLine("Countdount begins ...");
                CountdownToOne(number);
            }
            else {
                Console.WriteLine("Invalid input of a number.");
            }
        }

        static void CountdownToOne(int number) {
            while (number >= 1) {
                Console.WriteLine(number + " ~");
                number--;
            }
        }

        static bool IsInputNumberValid(string message, out int number) {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return int.TryParse(input, out number);
        }
    }
}