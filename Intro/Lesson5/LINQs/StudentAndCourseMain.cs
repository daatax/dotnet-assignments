using System;
using System.Collections.Generic;
using System.Linq;

namespace Intro.Lesson5.LINQs
{

    // Given two lists: one containing students(StudentId, Name, CourseId) and their
    // courses(CourseId, CourseName, Instructor) and another containing courses and their instructors,
    // write a C# program that uses LINQ to perform the following tasks:Join the two lists to find which
    // students are enrolled in which courses and who the instructors are.
    // Display the result with student names, course names, and instructor names.
    internal class StudentAndCourseMain
    {
        public static void Main(string[] args) {
            List<Student> students = new List<Student> {
            new Student("Alice", 101, 303),
            new Student("Dave", 202, 505),
            new Student("Charlie", 303, 707),
            new Student("Ammy", 404, 909),
            new Student("Hayden", 505, 1010),
        };

            List<Course> courses = new List<Course> {
            new Course("C# & .NET", 505, "Mr. Brown"),
            new Course("Java", 909, "Sam Winston"),
            new Course("Math", 303, "Dr. Johnson"),
            new Course("History", 515, "Ms. Metz")
        };

            var studentsAndCourses = from student in students
                                     join course in courses
                                     on student.CourseID equals course.CourseID
                                     select new {
                                         StudentName = student.Name,
                                         CourseName = course.Name,
                                         course.Instructor
                                     };

            Console.WriteLine("Student Enrollments:");
            foreach (var result in studentsAndCourses) {
                Console.WriteLine($"Student's Name: {result.StudentName}, Course's Name: {result.CourseName}, Instructor's Name: {result.Instructor}");
            }
        }
    }
}