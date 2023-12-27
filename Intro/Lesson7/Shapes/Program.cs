using System;

namespace Intro.Lesson7.Shapes
{
    public class Program
    {
        public static void Main(string[] args) {
            Rectangle rectangle = new Rectangle(12, 27);
            Circle circle = new Circle(10);

            Console.WriteLine("Area of Rectangle: " + rectangle.CalculateArea());
            Console.WriteLine("Perimeter of Rectangle: " + rectangle.CalculatePerimeter());

            Console.WriteLine("The area of a Circle is: " + circle.CalculateArea());
            Console.WriteLine("The perometer of a Circle is: " + circle.CalculatePerimeter());
        }
    }
}