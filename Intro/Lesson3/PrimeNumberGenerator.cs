using System;

namespace Intro.Lesson3
{
    internal class PrimeNumberGenerator
    {
        //Generate a list of prime numbers up to a given limit. 
        //Implement a function to check if a number is prime and then populate the list.
        public static void Main(string[] args) {
            Console.WriteLine("Enter a size for the prime numbers list ... ");

            if (int.TryParse(Console.ReadLine(), out int listSize)) {
                List<int> primeNumbers = GeneratePrimeNumbers(listSize);
                Console.WriteLine("The prime numbers up to the " + listSize + " are ...");
                PrintList(primeNumbers);
            }
            else {
                Console.WriteLine("Please enter a valid number greater than 0!");
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

        static List<int> GeneratePrimeNumbers(int limit) {
            List<int> primeNumbers = new List<int>();

            for (int i = 2; i <= limit; i++) {
                if (IsPrime(i)) {
                    primeNumbers.Add(i);
                }
            }

            return primeNumbers;
        }

        static void PrintList(List<int> list) {
            for (int i = 0; list.Count > i; i++) {
                if (i == 0) {
                    Console.Write("[ " + list[i] + "; ");
                }
                else if (i == list.Count - 1) {
                    Console.Write(list[i] + " ]");
                }
                else {
                    Console.Write(list[i] + "; ");
                }
            }
        }
    }

}