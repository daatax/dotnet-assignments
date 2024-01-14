using System;

namespace Intro.Lesson3
{
    internal class ArraySumAverage
    {
        //Write a program that initializes an array of integers and then calculates the sum and average of the array elements.
        public static void Main(string[] args) {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };

            Console.WriteLine("The sum of the numbers is: " + CalculateSum(numbers));
            Console.WriteLine("The average of the numbers is: " + CalculateAverage(numbers));
        }

        // I'm aware of the .Sum() method, but gonna use a custom one
        static int CalculateSum(int[] numbers) {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
            }
            return sum;
        }

        // I'm aware of the .Average() method, but gonna use a custom one
        static double CalculateAverage(int[] numbers) {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
            }
            return sum / numbers.Length;

            //v2
            //return CalculateSum(numbers) / numbers.Length;
        }

    }
}