using System;


namespace Intro.Lesson1.PrimitiveTypesAndVariables
{
    internal class AreaOfRectangle
    {
        public static void Main(string[] args) {
            int width = 10;
            int height = 15;

            Console.WriteLine("The area of the rectangel is: " + CalculateAreaOfRectangle(width, height));
        }

        static int CalculateAreaOfRectangle(int width, int height) {
            return width * height;
        }
    }
}
