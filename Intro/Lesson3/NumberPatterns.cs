using System;

namespace Intro.Lesson3
{
    internal class NumberPatterns
    {
        //Number Patterns - Create a program that uses nested for loops to print different number patterns.
        public static void Main(string[] args) {
            if (IsInputNumberValid("Please enter a number ...", out int number)) {
                PrintNumberPattern(number);
            }
            else {
                Console.WriteLine("Invalid input of number.");
            }
        }

        static void PrintNumberPattern(int number) {
            for (int i = 1; i <= number; i++) {
                for (int j = 1; j <= i; j++) {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        static bool IsInputNumberValid(string message, out int number) {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return int.TryParse(input, out number);
        }
    }
}