using System;

namespace Intro.Lesson3
{
    internal class NumberGuessingGame
    {
        // Number Guessing Game - Create a number guessing game where the computer generates a random number between 1 and 100,
        // and the user tries to guess it. Use a do-whileloop to keep the game running until the user guesses correctly.
        public static void Main(string[] args) {
            PlayNumberGuesser();
        }

        static void PlayNumberGuesser() {
            Random random = new Random();
            int randomNumber = random.Next(1, 100);
            int number;
            do {
                if (IsInputNumberValid("Try to guess the number", out number)) {
                    if (number == randomNumber) {
                        Console.WriteLine("Congrats! You've guessed the number!");
                    }
                    else {
                        Console.WriteLine("Nope,that's not correct. Try one more time");
                    }
                }
                else {
                    Console.WriteLine("Invalid input of number.");
                    break;
                }
            } while (number != randomNumber);
        }


        static bool IsInputNumberValid(string message, out int number) {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return int.TryParse(input, out number);
        }
    }
}