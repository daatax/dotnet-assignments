using System;

namespace Intro.Lesson9.Structs
{
    internal struct Circle : IShape
    {

        public double Radius { get; set; }

        public Circle(double radius) {
            if (radius <= 0) {
                throw new ArgumentException("The radius should be greater than or equal to 0.");
            }
            Radius = radius;
        }

        public double CalculateArea() {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double CalculatePerimeter() {
            return 2 * Math.PI * Radius;
        }
    }
}
