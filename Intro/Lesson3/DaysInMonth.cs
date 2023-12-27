using System;

namespace Intro.Lesson3
{
    internal class DaysInMonth
    {
        public static void Main(string[] args) {
            Console.WriteLine("Please enter a month in order to get the number of days ...");
            string month = GetInputMonth();

            Console.WriteLine("The days in the " + month + " are " + GetDaysInMonth(month));
        }

        static string GetInputMonth() {
            string month;
            while (true) {
                month = Console.ReadLine().ToLower();

                if (!string.IsNullOrEmpty(month) && IsValidMonth(month)) {
                    return month;
                }
                else {
                    Console.WriteLine("Invalid input of the month. Try one more time");
                }
            }
        }

        static bool IsValidMonth(string month) {
            string[] validMonths = { "january", "february", "march", "april", "may", "june", "july", "august", "september", "october", "november", "december" };
            return validMonths.Contains(month);
        }

        static int GetDaysInMonth(string month) {

            switch (month) {
                case "february":
                    return DateTime.IsLeapYear(DateTime.Now.Year) ? 29 : 28;
                case "april":
                case "june":
                case "september":
                case "november":
                    return 30;
                default:
                    return 31;
            }
        }
    }
}