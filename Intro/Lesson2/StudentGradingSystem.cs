using System;

namespace Intro.Lesson2
{
    internal class StudentGradingSystem
    {
        public static void Main(string[] args) {
            Console.WriteLine("Enter your score ...");
            bool isValidScore = int.TryParse(Console.ReadLine(), out int score) && score >= 0 && score <= 100;

            string grade = isValidScore ? GetGrade(score)
                            : "Invalid score input. Please enter a valid integer between 0 and 100.";
            Console.WriteLine(grade);
        }

        static string GetGrade(int score) {

            bool gradeA = score >= 90 && score <= 100;
            bool gradeB = score >= 80 && score <= 89;
            bool gradeC = score >= 70 && score <= 79;
            bool gradeD = score >= 60 && score <= 69;
            bool gradeF = score < 60 && score >= 0;

            string message = "Your grade is: ";

            return gradeA ? message + "A"
                : gradeB ? message + "B"
                : gradeC ? message + "C"
                : gradeD ? message + "D"
                : message + "F";
        }
    }
}
