using System;

namespace Intro.Lesson1.ConditionalStatements
{
    internal class Calculator
    {
        public static void Main(string[] args) {
            Console.WriteLine("Please enter a number ...");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter a number ...");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What operation you want to perform? Possible operations are - /addition, subtraction, multiplication, division/");
            string operation = Console.ReadLine();

            if (operation != "addition" && operation != "subtraction" && operation != "multiplication" && operation != "division") {
                Console.WriteLine("Invalid input of the operation.");
            }

            if (operation == "division" && num1 == 0 || num2 == 0) {
                Console.WriteLine("Cannot Divide by 0.");
                Console.ReadKey();
            }
            else {
                PrintResult(num1, num2, operation);
            }

        }

        static void PrintResult(double num1, double num2, string operatrion) {

            switch (operatrion) {
                case "addition":
                    Console.WriteLine("The sum of the entered numbers is: " + (num1 + num2));
                    Console.ReadKey();
                    break;
                case "subtraction":
                    Console.WriteLine("The difference of the entered numbers is: " + (num1 - num2));
                    Console.ReadKey();
                    break;
                case "multiplication":
                    Console.WriteLine("The product of the entered numbers is: " + (num1 * num2));
                    Console.ReadKey();
                    break;
                case "division":
                    Console.WriteLine("The quotient of the entered numbers is: " + (num1 / num2));
                    Console.ReadKey();
                    break;
            }
        }
    }
}
