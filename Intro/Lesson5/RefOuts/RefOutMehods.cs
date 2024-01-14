using System;

namespace Intro.Lesson5.RefOuts
{
    internal class RefOutMehods
    {
        /// <summary>
        /// Swaps two integers' values. Parameters are passed by reference.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        public static void Swap(ref int num1, ref int num2) {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }

        /// <summary>
        /// Calculates the area and perimeter of a rectangle.
        /// </summary>
        /// <param name="lenght"></param>
        /// <param name="width"></param>
        /// <param name="area"></param>
        /// <param name="perimeter"></param>
        public static void CalculateRectangle(double lenght, double width, out double area, out double perimeter) {
            area = lenght * width;
            perimeter = 2 * (lenght + width);
        }

        /// <summary>
        /// Finds the maximum value in an array of integers. Array is being passed by reference.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="max"></param>
        public static void FindMax(ref int[] array, out int max) {
            max = array[0];

            for (int i = 1; i < array.Length; i++) {
                if (array[i] > max) {
                    max = array[i];
                    break;
                }
            }
        }

        /// <summary>
        /// Atempts to parse the input string into an integer.
        /// Uses an out parameter to return the parsed integer, and a bool to indicate whether the parsing was successful.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="parsedValue"></param>
        /// <returns></returns>
        public static bool TryParseInt(string input, out int parsedValue) {
            if (int.TryParse(input, out parsedValue)) {
                return true;
            }
            else {
                parsedValue = 0;
                return false;
            }
        }
    }
}