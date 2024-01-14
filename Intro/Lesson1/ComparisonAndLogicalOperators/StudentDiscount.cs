using System;

namespace Intro.Lesson1.ComparisonAndLogicalOperators
{
    internal class StudentDiscount
    {
        public static void Main(string[] args) {
            Console.WriteLine("Are you a student? (Yes/No)");
            string isStudent = Console.ReadLine();
            if (isStudent == "No") {
                Console.WriteLine("Sorry, but this is only for students.");
                Console.ReadKey();
            }
            else if (isStudent != "Yes" && isStudent != "No") {
                Console.WriteLine("Invalid input.");
                Console.ReadKey();
            }
            else {
                Console.WriteLine("How old are you?");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What's your GPA?");
                double gpa = Convert.ToDouble(Console.ReadLine());
                CheckEligibility(age, gpa);
            }
        }

        static void CheckEligibility(int age, double gpa) {
            if (age > 18 && gpa > 3.9) {
                Console.WriteLine("Congrats!!! You're eligible for student discount.");
            }
        }
    }
}
