using System;

namespace Intro.Lesson4.MathOperations
{
    internal class MathHelper
    {
        public static double PI { get; } = Math.PI;
        private static double randomValue;

        static MathHelper() {
            Random random = new Random();
            randomValue = random.Next(1, 99999);
        }

        public static double GetRandomValue() {
            return randomValue;
        }

        public static double Add(double num1, double num2) {
            return num1 + num2;
        }

        public static double Substract(double num1, double num2) {
            return num1 - num2;
        }

        public static double Multiply(double num1, double num2) {
            return num1 * num2;
        }

        public static double Divide(double num1, double num2) {
            return num1 / num2;
        }

        public static double SquareRoot(double number) {
            return Math.Sqrt(number);
        }

        public static double Exponentiation(double number, double exponent) {
            return Math.Pow(number, exponent);
        }

        public static void PrintResult(double num1, double num2, string operatrion) {

            switch (operatrion) {
                case "addition":
                    Console.WriteLine("The sum of the entered numbers is: " + Add(num1, num2));
                    break;
                case "subtraction":
                    Console.WriteLine("The difference of the entered numbers is: " + Substract(num1, num2));
                    break;
                case "multiplication":
                    Console.WriteLine("The product of the entered numbers is: " + Multiply(num1, num2));
                    break;
                case "division":
                    Console.WriteLine("The quotient of the entered numbers is: " + Divide(num1, num2));
                    break;
            }
        }

        public static bool IsInputNumberValid(string message, out double number) {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return double.TryParse(input, out number);
        }

        public static string GetInputOperation(string message, out string operation) {

            while (true) {
                Console.WriteLine(message);
                operation = Console.ReadLine().ToLower();

                if (!string.IsNullOrEmpty(operation) && IsValidOperation(operation)) {
                    return operation;
                }
                else {
                    Console.WriteLine("Invalid input of the operation.");
                }
            }
        }

        public static bool IsValidOperation(string operation) {
            string[] validOperations = { "addition", "subtraction", "multiplication", "division" };
            return validOperations.Contains(operation);
        }
    }
}