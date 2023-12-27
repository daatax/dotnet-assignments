using System;

namespace Intro.Lesson3
{
    internal class SumOfDigits
    {
        //Sum of Digits - Build a program that takes an integer as input and calculates the sum of its digits using a while loop.
        public static void Main(string[] args) {
            if (IsInputNumberValid("Please enter a number ...", out int number) && number > 0) {
                Console.WriteLine("The sum of the digits is: " + CalculateSumOfDigits(number));
            }
            else {
                Console.WriteLine("Invalid input of a number.");
            }
        }

        static int CalculateSumOfDigits(int number) {
            int result = 0;

            while (number > 0) {
                result += number % 10;
                number /= 10;
            }

            return result;
        }
        static bool IsInputNumberValid(string message, out int number) {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return int.TryParse(input, out number);
        }
    }
}