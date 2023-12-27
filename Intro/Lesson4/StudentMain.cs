using System;

namespace Intro.Lesson4
{
    internal class StudentMain
    {
        public static void Main(string[] args) {
            // Create two instances of Student
            Student student1 = new Student("John Doe", 21, 3.8);
            Student student2 = new Student("Bob Sindle", 17, 1.5);
            Student student3 = new Student("Amy Winston", 14, 2.7);

            Console.WriteLine("Student 1 Info - " + student1.GetStudentInfo());
            Console.WriteLine("Student 2 Info - " + student2.GetStudentInfo());
            Console.WriteLine("Student 3 Info - " + student3.GetStudentInfo());
            Console.WriteLine();

            Console.WriteLine("Is Student 1 failing? " + student1.IsFailing());
            Console.WriteLine("Is Student 2 failing? " + student2.IsFailing());
            Console.WriteLine("Is Student 3 failing? " + student3.IsFailing());
            Console.WriteLine();

            Console.WriteLine("Student 1 Info (with grade) - " + student1.GetStudentInfo(true));
            Console.WriteLine("Student 2 Info (without grade) - " + student2.GetStudentInfo(false));
            Console.WriteLine("Student 3 Info (without grade) - " + student3.GetStudentInfo(false));
            Console.WriteLine();

            Console.WriteLine("Student 1 Status: " + student1.GetStudentStatus());
            Console.WriteLine("Student 2 Status: " + student2.GetStudentStatus());
            Console.WriteLine("Student 3 Status: " + student3.GetStudentStatus());
        }
    }
}