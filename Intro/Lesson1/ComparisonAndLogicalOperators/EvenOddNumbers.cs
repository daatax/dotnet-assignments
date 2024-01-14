using System;

namespace Intro.Lesson1.ComparisonAndLogicalOperators
{
    internal class EvenOddNumbers
    {
        public static void Main(string[] args) {
            Console.WriteLine("Please enter a number ...");
            int number = Convert.ToInt32(Console.ReadLine());
            CheckEvenOrOdd(number);
            Console.ReadKey();
        }

        static void CheckEvenOrOdd(int num) {
            if (num % 2 == 0) {
                Console.WriteLine("The number is even!");
            }
            else {
                Console.WriteLine("The number is odd!");
            }
        }
    }
}
