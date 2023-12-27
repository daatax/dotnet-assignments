using System;

namespace Intro.Lesson5.LINQs
{
    internal class Course
    {
        public string Name { get; set; }
        public int CourseID { get; set; }
        public string Instructor { get; set; }

        public Course(string name, int courseID, string instructor) {
            Name = name;
            CourseID = courseID;
            Instructor = instructor;
        }
    }
}