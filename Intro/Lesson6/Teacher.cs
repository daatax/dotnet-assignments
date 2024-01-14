using System;

namespace Intro.Lesson6
{
    public class Teacher : Person
    {
        private Course profession;
        private List<Course> courses = new List<Course>();

        public string Profession {
            get {
                return profession.Name;
            }
        }

        public Teacher(string name, int age, Course profession) : base(name, age) {
            this.profession = profession;
            Teach(profession);
        }
        public void Teach(Course course) {
            courses.Add(course);
        }
        public string GetTeacherInfo() {
            return GetDetails() + ", Profession: " + Profession;
        }
    }
}