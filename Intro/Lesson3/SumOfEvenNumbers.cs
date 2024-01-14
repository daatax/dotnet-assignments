using System;

namespace Intro.Lesson3
{
    internal class SumOfEvenNumbers
    {
        //Sum of Even Numbers-Create a program that calculates and prints the sum of even numbers from 1 to 50 using a forloop.
        public static void Main(string[] args) {
            for (int i = 0; i <= 50; i++) {
                if (i % 2 == 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}