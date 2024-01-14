using System;

namespace Intro.Lesson2
{
    internal class EvenOddNumbers
    {
        public static void Main(string[] args) {

            Console.WriteLine("Please enter a number ...");
            bool isNumber = int.TryParse(Console.ReadLine(), out int num);

            if (isNumber) {
                string result = num % 2 == 0 ? "even" : "odd";
                Console.WriteLine("The entered number is " + result);
            }
            else {
                Console.WriteLine("Invalid input. PLease enter a numeric value");
            }
        }
    }
}
