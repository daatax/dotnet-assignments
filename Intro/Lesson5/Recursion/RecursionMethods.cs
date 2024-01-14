using System;

namespace Intro.Lesson5.Recursion
{
    internal class RecursionMethods
    {
        /// <summary>
        /// Recursive method to calculate the nth Fibonacci number
        /// </summary>
        /// <param name="nThFibonacci"></param>
        /// <returns></returns>
        public static int GetNthFibonacci(int nThFibonacci) {
            if (nThFibonacci == 1) {
                return 0;
            }
            else if (nThFibonacci == 2 || nThFibonacci == 3) {
                return 1;
            }
            return GetNthFibonacci(nThFibonacci - 1) + GetNthFibonacci(nThFibonacci - 2);
        }

        /// <summary>
        /// Prints the Fibonacci sequence up to a given number of terms using recursion.
        /// </summary>
        /// <param name="nThFibonacci"></param>
        public static void PrintFibonacciSequence(int nThFibonacci) {
            for (int i = 1; i <= nThFibonacci; i++) {
                if (i == 1) {
                    Console.Write("[" + GetNthFibonacci(i) + ", ");
                }
                else if (i == nThFibonacci) {
                    Console.Write(GetNthFibonacci(i) + "]");
                }
                else {
                    Console.Write(GetNthFibonacci(i) + ", ");
                }
            }
        }

        /// <summary>
        /// Calculates the sum of the digits of a positive integer using recursion.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int SumOfDigits(int number) {
            if (number == 0) {
                return 0;
            }
            return number % 10 + SumOfDigits(number / 10);
        }
    }
}