using System;

namespace Intro.Lesson6
{
    public class Student : Person
    {
        private Course major;

        List<Course> courses = new List<Course>();
        public string Major {
            get { return major.Name; }
        }
        public List<Course> Courses {
            get { return courses; }
        }

        public Student(string name, int age, Course major) : base(name, age) {
            this.major = major;
            Enroll(major);
        }

        public void Enroll(Course course) {
            courses.Add(course);
        }

        public string GetCourseName() {
            var names = from course in courses
                        select course.Name;

            return string.Join(";", names);
        }

        public string GetStudentInfo() {
            return GetDetails() + ", Major: " + major.Name;
        }
    }
}