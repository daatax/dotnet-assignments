using System;

namespace Intro.Lesson9.Records
{
    public record Student
    {
        public int StudentId { get; init; }
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public double GPA { get; init; }

        public Student(int studentID, string firstName, string lastName, double gpa) {
            if (studentID <= 0) {
                throw new ArgumentException("Invalid value for StudentID. It should be greater than 0.");
            }
            if (string.IsNullOrEmpty(firstName)) {
                throw new ArgumentException("Invalid value for student's First Name. Cannot be null or empty");
            }
            if (string.IsNullOrEmpty(lastName)) {
                throw new ArgumentException("Invalid value for student's Last Name. Cannot be null or empty");
            }
            if (gpa <= 0 || gpa > 4.0) {
                throw new ArgumentException("Invalid value for GPA. It should be between 0 and 4.0.");
            }

            StudentId = studentID;
            FirstName = firstName;
            LastName = lastName;
            GPA = gpa;
        }
    }
}