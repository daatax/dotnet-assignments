using System;

namespace Intro.Lesson4.OperatorOverloading
{
    /// <summary>
    /// Represents a complex number with real and imaginary parts.
    /// </summary>
    internal class ComplexNumber
    {
        /// <summary>
        /// Gets the real part of the complex number.
        /// </summary>
        public double real { get; }

        /// <summary>
        /// Gets the imaginary part of the complex number.
        /// </summary>
        public double imaginary { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComplexNumber"/> class.
        /// </summary>
        /// <param name="real">The real part of the complex number.</param>
        /// <param name="imaginary">The imaginary part of the complex number.</param>
        public ComplexNumber(double real, double imaginary) {
            this.real = real;
            this.imaginary = imaginary;
        }

        /// <summary>
        /// Overloads the + operator to allow addition of two complex numbers.
        /// The formula for adding two complex numbers is: (a + bi) + (c + di) = (a + c) + (b + d)i
        /// </summary>
        public static ComplexNumber operator +(ComplexNumber num1, ComplexNumber num2) {
            return new ComplexNumber(num1.real + num2.real, num1.imaginary + num2.imaginary);
        }

        /// <summary>
        /// Overloads the - operator to allow subtraction of two complex numbers.
        /// The formula for substracing two complex numbers is: (a + bi) - (c + di) = (a - c) + (b - d)i
        /// </summary>
        public static ComplexNumber operator -(ComplexNumber num1, ComplexNumber num2) {
            return new ComplexNumber(num1.real - num2.real, num1.imaginary - num2.imaginary);
        }

        /// <summary>
        /// Overloads the * operator to allow multiplication of two complex numbers.
        /// The formula for multiplying two complex numbers si: (a + bi) * (c + di) = (ac - bd) + (ad + bc)i
        /// </summary>
        public static ComplexNumber operator *(ComplexNumber num1, ComplexNumber num2) {
            double realPart = num1.real * num2.real - num1.imaginary * num2.imaginary;
            double imaginaryPart = num1.real * num2.imaginary + num2.real * num1.imaginary;
            return new ComplexNumber(realPart, imaginaryPart);
        }

        /// <summary>
        /// Overloads the / operator to allow division of two complex numbers.
        /// The formula for dividing complex numbers is: (a + bi) / (c + di) = ((a + bi) * (c - di)) / ((c + di) * (c - di))
        /// </summary>
        public static ComplexNumber operator /(ComplexNumber num1, ComplexNumber num2) {
            double denominator = num2.real * num2.real + num2.imaginary * num2.imaginary;
            double real = (num1.real * num2.real + num1.imaginary * num2.imaginary) / denominator;
            double imaginary = (num1.imaginary * num2.real - num1.real * num2.imaginary) / denominator;

            return new ComplexNumber(real, imaginary);
        }

        /// <summary>
        /// Overloads the == operator to compare two complex numbers for equality.
        /// </summary>
        public static bool operator ==(ComplexNumber a, ComplexNumber b) {
            return a.real == b.real && a.imaginary == b.imaginary;
        }

        /// <summary>
        /// Overloads the != operator to compare two complex numbers for inequality.
        /// </summary>
        public static bool operator !=(ComplexNumber a, ComplexNumber b) {
            return !(a == b);
        }

        /// <summary>
        /// Overloads the ToString() method to print the complex number.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string ToString(ComplexNumber num) {
            return "(" + num.real + " + " + num.imaginary + "i)";
        }
    }
}