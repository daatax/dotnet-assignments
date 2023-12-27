using System;

namespace Intro.Lesson3
{
    internal class PrimeNumbers
    {
        // Prime Numbers - Write a program that uses a for loop to find and print all prime numbers between 1 and 100.
        public static void Main(string[] args) {
            for (int i = 0; i <= 100; i++) {
                if (IsPrime(i)) {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsPrime(int num) {
            int potentialFactor = 2;

            if (num < 2 && num >= 0) {
                return false;
            }

            while (num % potentialFactor != 0) {
                potentialFactor++;
            }

            if (potentialFactor == num) {
                return true;
            }
            return false;
        }
    }
}