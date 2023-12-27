using System;
using System.Collections.Generic;

namespace Intro.Lesson9.Generics2
{
    public class GenericSwapMain
    {
        public static void Main(string[] args) {
            int number = 10;
            string str = "A string value.";

            Console.WriteLine($"Original values - number: {number}, str: {str}");
            Console.WriteLine($"Values after swapping - number: {number}, str: {str}");
        }

        public static void Swap<T>(ref T value1, ref T value2) {
            T tempValue = value1;
            value1 = value2;
            value2 = tempValue;
        }
    }
}