using System;

namespace Intro.Lesson6
{
    public class Course
    {
        private string name;
        private string courseID;

        public string Name {
            get { return name; }
            set {
                if (!string.IsNullOrEmpty(value)) {
                    name = value;
                }
            }
        }
        public string CourseID {
            get { return courseID; }
            set {
                if (!string.IsNullOrEmpty(value)) {
                    courseID = value;
                }
            }
        }
        public Course(string name, string courseID) {
            this.name = name;
            this.courseID = courseID;
        }
    }
}
