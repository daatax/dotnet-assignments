using System;

namespace Intro.Lesson8.Enums
{
    public class Program
    {
        public static void Main(string[] args) {
            Console.WriteLine("Enter a day of the week ...");
            string userInput = Console.ReadLine();

            if (string.IsNullOrEmpty(userInput)) {
                Console.WriteLine("Invalid input.");
                return;
            }

            DayOfWeek userDay;
            if (Enum.TryParse(userInput, out userDay)) {

                if (DayHelper.IsWeekend(userDay)) {
                    Console.WriteLine($"The entered day '{userInput}' is a weekend day.");
                }
                else {
                    Console.WriteLine($"The entered day '{userInput}' is not a weekend day.");
                }

                Console.WriteLine($"Weekday name: {DayHelper.GetWeekdayName(userDay)}");
            }
            else {
                Console.WriteLine("Invalid input. Please enter a valid day of the week.");
            }
        }
    }
}