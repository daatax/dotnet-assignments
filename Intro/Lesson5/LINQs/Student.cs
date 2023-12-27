using System;

namespace Intro.Lesson5.LINQs
{
    internal class Student
    {
        public string Name { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }

        public Student(string name, int studentID, int courseID) {
            Name = name;
            StudentID = studentID;
            CourseID = courseID;
        }
    }
}