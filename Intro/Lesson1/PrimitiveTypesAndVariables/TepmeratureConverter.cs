using System;

namespace Intro.Lesson1.PrimitiveTypesAndVariables
{
    internal class TepmeratureConverter
    {
        public static void Main(string[] args) {
            double fahrenheit = 86.0;
            double celsius = 28.0;

            Console.WriteLine(fahrenheit + " degrees Fahrenheit is: " + ConvertFahrenheitToCelsius(fahrenheit) + " degrees Celsius.");
            Console.WriteLine(celsius + " degrees Celsius is: " + ConvertCelsiusToFahrenheit(celsius) + " degrees Fahrenheit.");
            Console.ReadKey();
        }
        static double ConvertFahrenheitToCelsius(double temperature) {
            return (temperature - 32) / 1.8;
        }
        static double ConvertCelsiusToFahrenheit(double temperature) {
            return (temperature * 1.8) + 32;
        }
    }
}
