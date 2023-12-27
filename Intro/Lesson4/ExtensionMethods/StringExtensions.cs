using System;

namespace Intro.Lesson4.ExtensionMethods
{
    public static class StringExtensions
    {
        /// <summary>
        /// This extension method checks if the input string is Palindrome or not.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>
        /// returns TRUE if the input string is Palindrome, FALSE otherwise
        /// </returns>
        public static bool IsPalindrome(this string input) {
            if (string.IsNullOrEmpty(input))
                return false;

            input = input.ToLower();

            for (int i = 0; i < input.Length / 2; i++) {
                if (input[i] != input[input.Length - i - 1]) {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// This extension method counts the words in the input string based on the provided delimiter.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="delimiter"></param>
        /// <returns>
        /// count of the words in the input string.
        /// </returns>
        public static int GetWordsCount(this string input, string delimiter) {

            if (string.IsNullOrEmpty(input))
                return 0;

            input = input.ToLower().Trim();

            string[] words = input.Split(delimiter);

            return words.Length;
        }

        /// <summary>
        /// This extension method takes the input string and capitalizes it.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Capitalize(this string input) {
            if (string.IsNullOrEmpty(input))
                return input;

            return char.ToUpper(input[0]) + input.Substring(1);
        }

        /// <summary>
        /// This extension method removes vowels from the input string.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string RemoveVowels(this string input) {
            string inputWitoutVowels = "";

            foreach (char letter in input) {
                if (letter != 'a' && letter != 'e' && letter != 'i' && letter != 'o' && letter != 'u') {
                    inputWitoutVowels += letter;
                }
            }

            return inputWitoutVowels;
        }

        /// <summary>
        /// This extension method checks if the provided strings are anagrams or not.
        /// </summary>
        /// <param name="firstWord"></param>
        /// <param name="secondWord"></param>
        /// <returns></returns>
        public static bool AreAnagrams(this string firstWord, string secondWord) {

            if (string.IsNullOrEmpty(firstWord) || string.IsNullOrEmpty(secondWord) || firstWord.Length != secondWord.Length) {
                return false;
            }

            firstWord = firstWord.ToLower();
            secondWord = secondWord.ToLower();

            char[] firstWordChars = firstWord.ToCharArray();
            char[] secondWordChars = secondWord.ToCharArray();
            Array.Sort(firstWordChars);
            Array.Sort(secondWordChars);

            for (int i = 0; i < firstWordChars.Length; i++) {
                if (firstWordChars[i] != secondWordChars[i]) {
                    return false;
                }
            }

            return true;
        }
    }
}