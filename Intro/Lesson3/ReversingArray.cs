using System;

namespace Intro.Lesson3
{
    internal class ReversingArray
    {
        // Create a program that takes an array of elements and reverses the order of the elements.
        public static void Main(String[] args) {
            int[] numbers = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };

            Console.Write("The reversed array is: ");
            PrintArray(ReverseArray(numbers));
        }

        // I'm aware of the .Reverse() method, but gonna use a custom one
        static int[] ReverseArray(int[] numbers) {
            int[] reversedNumbers = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++) {
                reversedNumbers[i] = numbers[numbers.Length - i - 1];
            }
            return reversedNumbers;
        }

        static void PrintArray(int[] numbers) {
            for (int i = 0; i < numbers.Length; i++) {
                if (i == 0) {
                    Console.Write("[" + numbers[i] + "; ");
                }
                else if (i == numbers.Length - 1) {
                    Console.Write(numbers[i] + "]");
                }
                else {
                    Console.Write(numbers[i] + "; ");
                }
            }
        }
    }
}