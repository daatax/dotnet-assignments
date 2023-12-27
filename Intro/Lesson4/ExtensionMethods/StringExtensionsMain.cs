using System;

namespace Intro.Lesson4.ExtensionMethods
{
    internal class StringExtensionsMain
    {
        public static void Main(string[] args) {
            string palindromeWord = "NairiaN";
            bool isPalindrom = palindromeWord.IsPalindrome();
            string message = isPalindrom ? palindromeWord + " is Palindrome" : palindromeWord + " is not Palindrome";
            Console.WriteLine(message);

            string sentence = "This is a sample sentence to get the count of the words in it.";
            Console.WriteLine("The are " + sentence.GetWordsCount(" ") + " words in the senctence.");

            string lowerString = "jack";
            Console.WriteLine("Capitalize string is: " + lowerString.Capitalize());

            string sentenceWithVowels = "A sentence that contains vowels";
            Console.WriteLine("A sentence without vowels: " + sentenceWithVowels.RemoveVowels());

            string firstWord = "earth";
            string secondWord = "heart";
            bool areAmagrams = firstWord.AreAnagrams(secondWord);
            string printMessage = areAmagrams ? firstWord + " and " + secondWord + " are Anagrams!" : firstWord + " and " + secondWord + " are not Anagrams!";
            Console.WriteLine(printMessage);
        }
    }
}