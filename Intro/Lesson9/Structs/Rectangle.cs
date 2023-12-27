using System;

namespace Intro.Lesson9.Structs
{
    public struct Rectangle : IShape
    {

        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle(double height, double width) {
            if (height < 0) {
                throw new ArgumentException("The height of a rectangle cannot be less than or equal to 0.");
            }
            if (width < 0) {
                throw new ArgumentException("The width of a rectangle cannot be less than or equal to 0.");
            }
            Height = height;
            Width = width;
        }

        public double CalculateArea() {
            return Height * Width;
        }
        public double CalculatePerimeter() {
            return 2 * (Height + Width);
        }
    }
}