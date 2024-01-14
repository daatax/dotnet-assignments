using System;

namespace Intro.Lesson3
{
    internal class PrimeNumberChecker
    {
        //Write a program that takes an integer as input and determines whether it's a prime number (only divisible by 1 and itself).
        public static void Main(string[] args) {
            Console.WriteLine("Enter a number ...");
            if (int.TryParse(Console.ReadLine(), out int primeNumber)) {
                if (IsPrime(primeNumber)) {
                    Console.WriteLine("The entered number is Prime!");
                }
                else {
                    Console.WriteLine("The entered number is NOT Prime!");
                }
            }
            else {
                Console.WriteLine("Please enter a VALID number.");
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