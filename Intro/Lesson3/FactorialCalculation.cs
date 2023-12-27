using System;

namespace Intro.Lesson3
{
    internal class FactorialCalculation
    {
        //Factorial Calculation - Implement a program that calculates and prints the factorial of a given positive integer using a while loop.
        public static void Main(string[] args) {
            if (IsInputNumberValid("Please enter a number ...", out int number) & number > 0) {
                Console.WriteLine("The factorial of " + number + " is " + CalculateFactorial(number));
            }
            else {
                Console.WriteLine("Invalid input of a number.");
            }
        }

        static long CalculateFactorial(int number) {
            long factorial = 1;
            int i = 1;

            while (i <= number) {
                factorial *= i;
                i++;
            }

            return factorial;
        }
        static bool IsInputNumberValid(string message, out int number) {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return int.TryParse(input, out number);
        }
    }
}