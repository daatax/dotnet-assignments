using System;

namespace Intro.Lesson1.ArithmeticOperations
{
    internal class AreaCircumferenceOfCircle
    {
        public static void Main(string[] args) {
            Console.WriteLine("Enter the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The areo of the circle is: " + CalculateArea(radius));
            Console.WriteLine("The circumference of the circle is: " + CalculateCircumference(radius));
        }

        static double CalculateArea(double radius) {
            return Math.PI * Math.Pow(radius, 2);
        }

        static double CalculateCircumference(double radius) {
            return 2 * Math.PI * radius;
        }
    }
}