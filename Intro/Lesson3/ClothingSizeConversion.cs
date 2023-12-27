using System;

namespace Intro.Lesson3
{
    internal class ClothingSizeConversion
    {
        // Implement a program that converts clothing sizes between different regions (e.g., US, EU, UK). Use a switch statement to handle the size conversion.
        public static void Main(String[] args) {
            Console.WriteLine("Clothing Size Converter");

            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Convert US to EU");
            Console.WriteLine("2. Convert EU to US");
            Console.WriteLine("3. Convert UK to US");
            Console.WriteLine("4. Quit");

            if (IsInputNumberValid("", out double choice)) {
                ConvertSize(choice);
            }
            else {
                Console.WriteLine("Invalid input. Please enter a valid option.");
            }
        }

        static void ConvertSize(double choice) {
            switch (choice) {
                case 1:
                    ConvertUStoEU();
                    break;
                case 2:
                    ConvertEUtoUS();
                    break;
                case 3:
                    ConvertUKtoUS();
                    break;
                case 4:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please select a valid option.");
                    break;
            }
        }

        static void ConvertUStoEU() {
            if (IsInputNumberValid("Enter US size that you want to convert: ", out double usSize)) {
                double euSize = usSize - 30;
                Console.WriteLine("Converted EU size is: " + euSize);
            }
            else {
                Console.WriteLine("Invalid input of size.");
            }
        }

        static void ConvertEUtoUS() {

            if (IsInputNumberValid("Enter EU size that you want to convert: ", out double euSize)) {
                double usSize = euSize + 30;
                Console.WriteLine("Converted US size is: " + usSize);
            }
            else {
                Console.WriteLine("Invalid input of size.");
            }
        }

        static void ConvertUKtoUS() {

            if (IsInputNumberValid("", out double ukSize)) {
                double usSize = ukSize + 2;
                Console.WriteLine("Converted US size is: " + usSize);
            }
            else {
                Console.WriteLine("Invalid input of size.");
            }
        }

        static bool IsInputNumberValid(string message, out double number) {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return double.TryParse(input, out number);
        }
    }
}