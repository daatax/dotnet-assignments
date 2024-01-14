using System;

namespace Intro.Lesson8.Enums
{
    public enum DayOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    public class DayHelper
    {
        public static bool IsWeekend(DayOfWeek day) {
            return day == DayOfWeek.Saturday || day == DayOfWeek.Sunday;
        }
        public static string GetWeekdayName(DayOfWeek day) {
            return day.ToString();
        }
    }
}