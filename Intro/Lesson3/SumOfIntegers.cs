using System;

namespace Intro.Lesson3
{
    internal class SumOfIntegers
    {
        // Sum of Integers - Write a program that takes positive integers as input until the user enters 0.
        // Calculate and print the sum of the entered integers using a do-while loop.
        public static void Main(string[] args) {
            Console.WriteLine("The sum of input numbers is: " + calculateSumOfEnteredNumbers());
        }

        static int calculateSumOfEnteredNumbers() {
            int sum = 0;
            int number = 0;
            do {
                if (isInputNumberValid("Please enter a number ...", out number)) {
                    sum += number;
                }
                else {
                    Console.WriteLine("Invalid input of a number.");
                }
            } while (number != 0);

            return sum;
        }

        static bool isInputNumberValid(string message, out int number) {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return int.TryParse(input, out number);
        }
    }
}