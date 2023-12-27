using System;

namespace Intro.Lesson1.ArithmeticOperations
{
    internal class ArithmeticOperations
    {

        public static void Main(string[] args) {
            Console.WriteLine("Please enter a number ...");
            double num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a number ...");
            double num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The sum of the entered numbers is: " + CalculateSum(num1, num2));
            Console.WriteLine("The difference of the entered numbers is: " + CalculateDifference(num1, num2));
            Console.WriteLine("The product of the entered numbers is: " + CalculateProduct(num1, num2));
            Console.WriteLine("The quotient of the entered numbers is: " + CalculateQuotient(num1, num2));
        }

        static double CalculateSum(double num1, double num2) {
            return num1 + num2;
        }
        static double CalculateDifference(double num1, double num2) {
            return num1 - num2;
        }
        static double CalculateProduct(double num1, double num2) {
            return num1 * num2;
        }
        static double CalculateQuotient(double num1, double num2) {
            return num1 / num2;
        }
    }
}
