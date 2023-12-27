using System;

namespace Intro.Lesson4.OperatorOverloading
{
    internal class ComplexNumberMain
    {
        public static void Main(string[] args) {
            Console.WriteLine("Enter the first complex number (a + bi): ");
            Console.Write("a: ");
            if (!IsInputNumberValid(out double real1)) {
                Console.WriteLine("Invalid input of number.");
                return;
            }

            Console.Write("b: ");
            if (!IsInputNumberValid(out double imaginary1)) {
                Console.WriteLine("Invalid input of a number.");
                return;
            }

            Console.WriteLine("\nEnter the second complex number (c + di): ");
            Console.Write("c: ");
            if (!IsInputNumberValid(out double real2)) {
                Console.WriteLine("Invalid input of a number.");
                return;
            }

            Console.Write("d: ");
            if (!IsInputNumberValid(out double imaginary2)) {
                Console.WriteLine("Invalid input of number.");
                return;
            }

            ComplexNumber complexNumber1 = new ComplexNumber(real1, imaginary1);
            ComplexNumber complexNumber2 = new ComplexNumber(real2, imaginary2);

            Console.WriteLine("\n-----------------------------------------------\n");
            Console.WriteLine("Printing results for two complex numbers operations");

            ComplexNumber sum = complexNumber1 + complexNumber2;
            Console.WriteLine("The sum of two complex numbers is: " + ComplexNumber.ToString(sum));

            ComplexNumber difference = complexNumber1 - complexNumber2;
            Console.WriteLine("The difference of two complex numbers is: " + ComplexNumber.ToString(difference));

            ComplexNumber product = complexNumber1 * complexNumber2;
            Console.WriteLine("The product of two complex numbers is: " + ComplexNumber.ToString(product));

            ComplexNumber division = complexNumber1 / complexNumber2;
            Console.WriteLine("The division of two complex numbers is: " + ComplexNumber.ToString(division));

            if (complexNumber1 == complexNumber2) {
                Console.WriteLine("Complex numbers are equal.");
            }

            if (complexNumber1 != complexNumber2) {
                Console.WriteLine("Complex numbers are not equal");
            }
        }

        static bool IsInputNumberValid(out double number) {
            string input = Console.ReadLine();
            return double.TryParse(input, out number);
        }
    }
}