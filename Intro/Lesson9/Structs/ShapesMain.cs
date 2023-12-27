using System;
using System.Runtime.InteropServices;

namespace Intro.Lesson9.Structs
{
    public class ShapesMain
    {
        public static void Main(string[] args) {
            Rectangle rectangle = new Rectangle(12, 27);
            Circle circle = new Circle(10);
            Triangle triangle = new Triangle(15, 17, 22);

            Console.WriteLine("Area of Rectangle: " + rectangle.CalculateArea());
            Console.WriteLine("Perimeter of Rectangle: " + rectangle.CalculatePerimeter());

            Console.WriteLine("The area of a Circle is: " + circle.CalculateArea());
            Console.WriteLine("The perometer of a Circle is: " + circle.CalculatePerimeter());

            Console.WriteLine("The area of a Triangle is: " + triangle.CalculateArea());
            Console.WriteLine("The perometer of a Triangle is: " + triangle.CalculatePerimeter());

            Console.WriteLine("\nGetting the sizes of struct shape objects in memory ...");
            int sizeOfRectangle = Marshal.SizeOf(rectangle);
            int sizeOfCircle = Marshal.SizeOf(circle);
            int sizeOfTriangle = Marshal.SizeOf(triangle);

            Console.WriteLine("Number of bytes needed for Rectangel is: " + sizeOfRectangle);
            Console.WriteLine("Number of bytes needed for Circle is: " + sizeOfCircle);
            Console.WriteLine("Number of bytes needed for Triangle is: " + sizeOfTriangle);
        }
    }
}