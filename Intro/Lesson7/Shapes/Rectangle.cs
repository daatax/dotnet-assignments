using System;

namespace Intro.Lesson7.Shapes
{
    public class Rectangle : Shape
    {
        private double height;
        private double width;

        public double Height {
            get { return height; }
            set {
                if (value > 0) {
                    height = value;
                }
                else {
                    throw new ArgumentException("The height of a rectangle cannot be less than or equal to 0.");
                }
            }
        }

        public double Width {
            get { return width; }
            set {
                if (value > 0) {
                    width = value;
                }
                else {
                    throw new ArgumentException("The width of a rectangle cannot be less than or equal to 0.");
                }
            }
        }

        public Rectangle(double height, double width) {
            Height = height;
            Width = width;
        }

        public override double CalculateArea() {
            return height * width;
        }

        public override double CalculatePerimeter() {
            return 2 * (height + width);
        }
    }
}
