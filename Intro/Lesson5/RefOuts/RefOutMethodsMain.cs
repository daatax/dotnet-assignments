using System;

namespace Intro.Lesson5.RefOuts
{
    internal class RefOutMethodsMain
    {
        public static void Main(string[] args) {
            // Test the Swap method
            int num1 = 5, num2 = 10;
            Console.WriteLine($"Before swap: num1 = {num1}, num2 = {num2}");
            RefOutMehods.Swap(ref num1, ref num2);
            Console.WriteLine($"After swap: num1 = {num1}, num2 = {num2}");
            Console.WriteLine();

            // Test the CalculateRectangle method
            double length = 5.5, width = 3.2;
            RefOutMehods.CalculateRectangle(length, width, out double area, out double perimeter);
            Console.WriteLine($"Rectangle with length {length} and width {width}:");
            Console.WriteLine($"Area = {area} || Perimeter = {perimeter}");
            Console.WriteLine();

            // Test the FindMax method
            int[] numbers = { 12, 45, 67, 32, 9 };
            RefOutMehods.FindMax(ref numbers, out int max);
            Console.WriteLine($"Maximum value in the array is: {max}");
            Console.WriteLine();

            // Test the TryParseInt method
            string input = "123";
            if (RefOutMehods.TryParseInt(input, out int parsedValue)) {
                Console.WriteLine($"Parsing successful. Parsed value is: {parsedValue}");
            }
            else {
                Console.WriteLine("Parsing failed!");
            }
        }
    }
}