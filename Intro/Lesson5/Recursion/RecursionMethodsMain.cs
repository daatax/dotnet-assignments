using System;

namespace Intro.Lesson5.Recursion;
internal class RecursionMethodsMain
{
    public static void Main(string[] args) {
        Console.Write("Enter the number of Fibonacci terms ... ");
        if (!isInputNumberValid(out int nThFibonacci)) {
            Console.WriteLine("Invalid input of Fibonacci terms .");
            return;
        }
        Console.WriteLine("Fibonacci sequence:");
        RecursionMethods.PrintFibonacciSequence(nThFibonacci);

        Console.WriteLine();
        Console.WriteLine("Enter a number to calculate the sum of the digits ...");
        if (!isInputNumberValid(out int number)) {
            Console.WriteLine("Invalid input of number.");
            return;
        }

        int sumOfDigits = RecursionMethods.SumOfDigits(number);
        Console.WriteLine($"The sum of the digits is {sumOfDigits}");
    }

    static bool isInputNumberValid(out int number) {
        string input = Console.ReadLine();
        return int.TryParse(input, out number);
    }
}
