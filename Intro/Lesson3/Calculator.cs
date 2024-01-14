using System;

namespace Intro.Lesson3
{
    internal class Calculator
    {
        // Write a program that takes two numbers and an operator (+, -, *, /) as input and performs the corresponding arithmetic operation using a switchstatement.
        // Days in a Month -Create a program that takes a month(as a string or number) as
        public static void Main(string[] args) {

            double num1;
            double num2;
            string operation;

            if (IsInputNumberValid("Please enter a valid number ...", out num1) && IsInputNumberValid("Please enter a valid number ...", out num2)) {
                GetInputOperation("What operation you want to perform? Possible operations are - /addition, subtraction, multiplication, division/", out operation);

                if (operation == "division" && num1 == 0 || num2 == 0) {
                    Console.WriteLine("Cannot Divide by 0.");
                }
                else {
                    PrintResult(num1, num2, operation);
                }
            }
            else {
                Console.WriteLine("Please enter a VALID number.");
            }
        }

        static bool IsInputNumberValid(string message, out double number) {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return double.TryParse(input, out number);
        }

        static string GetInputOperation(string message, out string operation) {

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

        static bool IsValidOperation(string operation) {
            string[] validOperations = { "addition", "subtraction", "multiplication", "division" };
            return validOperations.Contains(operation);
        }

        static void PrintResult(double num1, double num2, string operatrion) {

            switch (operatrion) {
                case "addition":
                    Console.WriteLine("The sum of the entered numbers is: " + (num1 + num2));
                    break;
                case "subtraction":
                    Console.WriteLine("The difference of the entered numbers is: " + (num1 - num2));
                    break;
                case "multiplication":
                    Console.WriteLine("The product of the entered numbers is: " + (num1 * num2));
                    break;
                case "division":
                    Console.WriteLine("The quotient of the entered numbers is: " + (num1 / num2));
                    break;
            }
        }
    }
}