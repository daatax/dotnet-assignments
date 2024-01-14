using System;

namespace Intro.Lesson7.Shapes
{
    public class Circle : Shape
    {
        private double radius;

        public double Radius {
            get { return radius; }
            set {
                if (value > 0) {
                    radius = value;
                }
                else {
                    throw new ArgumentException("The radius should be greater than 0.");
                }
            }
        }
        public Circle(double radius) {
            Radius = radius;
        }
        public override double CalculateArea() {
            return Math.PI * Math.Pow(radius, 2);
        }
        public override double CalculatePerimeter() {
            return 2 * Math.PI * radius;
        }
    }
}