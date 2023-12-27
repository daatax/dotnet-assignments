using System;

namespace Intro.Lesson3
{
    internal class LanguageGreeting
    {
        // Create a program that prompts users to input their preferred language ("English", "French", "Spanish") and uses a switch statement to display a corresponding greeting.
        public static void Main(string[] args) {
            Console.WriteLine("Please enter a preferred language (\"English\", \"French\", \"Spanish\") ...");
            string language = GetInputLanguage();

            GreetUserPerSelectedLanguage(language);
        }

        static string GetInputLanguage() {
            string language;
            while (true) {
                language = Console.ReadLine().ToLower();

                if (!string.IsNullOrEmpty(language) && IsValidLanguage(language)) {
                    return language;
                }
                else {
                    Console.WriteLine("Invalid input of the language. Try one more time");
                }
            }
        }

        static bool IsValidLanguage(string language) {
            string[] validLanguages = { "english", "french", "spanish" };
            return validLanguages.Contains(language);
        }

        static void GreetUserPerSelectedLanguage(string language) {
            switch (language) {
                case "english":
                    Console.WriteLine("Hey there! We are happy to have you join our community!");
                    break;
                case "french":
                    Console.WriteLine("Salut! Nous sommes heureux de vous voir rejoindre notre communauté!");
                    break;
                case "spanish":
                    Console.WriteLine("¡Hola! ¡Estamos felices de que te unas a nuestra comunidad!");
                    break;
            }
        }
    }
}