using System;

namespace Intro.Lesson1.Strings
{
    internal class VowelRemover
    {
        public static void Main(string[] args) {
            Console.WriteLine("Please enter any senctence ...");
            string sentence = Console.ReadLine();
            Console.WriteLine("The vowels have been removed from the provided senctence");
            Console.WriteLine(RemoveVowels(sentence));
            Console.ReadKey();
        }

        static string RemoveVowels(string input) {
            string sentenceWitoutVowels = "";

            foreach (char letter in input) {
                if (letter != 'a' && letter != 'e' && letter != 'i' && letter != 'o' && letter != 'u') {
                    sentenceWitoutVowels += letter;
                }
            }
            return sentenceWitoutVowels;
        }
    }
}
