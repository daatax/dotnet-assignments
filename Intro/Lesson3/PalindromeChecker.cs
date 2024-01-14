using System;

namespace Intro.Lesson3
{
    internal class PalindromeChecker
    {
        public static void Main(string[] args) {
            Console.WriteLine("Enter a word to check if it's a palindrome ...");
            if (IsPalindrome(Console.ReadLine())) {
                Console.WriteLine("The entered word is palindrome!");
            }
            else {
                Console.WriteLine("The entered word is NOT palidrome!");
            }
        }

        static bool IsPalindrome(string input) {
            input = input.ToLower();
            for (int i = 0; i < input.Length / 2; i++) {
                if (input[i] != input[input.Length - i - 1]) {
                    return false;
                }
            }
            return true;
        }
    }
}