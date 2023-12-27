using System;

namespace Intro.Lesson1.ConditionalStatements
{
    internal class SeasonDeterminer
    {
        public static void Main(string[] args) {
            Console.WriteLine("Please enter a month, and I'll return the season of it.");
            string month = Console.ReadLine();
            DetermineSeason(month);
        }

        static void DetermineSeason(string month) {

            month = month.ToLower();

            if (month == "december" || month == "january" || month == "february") {
                Console.WriteLine(month.ToUpper() + ": Winter!");
            }
            else if (month == "march" || month == "april" || month == "may") {
                Console.WriteLine(month.ToUpper() + ": Srping!");
            }
            else if (month == "june" || month == "july" || month == "august") {
                Console.WriteLine(month.ToUpper() + ": Summer!");
            }
            else if (month == "september" || month == "october" || month == "november") {
                Console.WriteLine(month.ToUpper() + ": Fall!");
            }
            else {
                Console.WriteLine("Hmmm... Cannot determine the season. ");
            }
        }
    }
}
