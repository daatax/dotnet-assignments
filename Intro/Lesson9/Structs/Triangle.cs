using System;

namespace Intro.Lesson9.Structs
{
    public struct Triangle : IShape
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public Triangle(double side1, double side2, double side3) {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0) {
                throw new ArgumentException("The side of a triangle cannot be less than or equal to 0.");
            }

            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public double CalculateArea() {
            double semiperimeter = (Side1 + Side2 + Side3) / 2.0;
            return Math.Sqrt(semiperimeter * ((semiperimeter - Side1) * (semiperimeter - Side2) * (semiperimeter - Side3)));
        }

        public double CalculatePerimeter() {
            return Side1 + Side2 + Side3;
        }
    }
}