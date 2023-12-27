using System;

namespace Intro.Lesson4
{
    internal class Student
    {
        private string name;
        private int age;
        private double grade;
        public Student(string name, int age, double grade) {
            this.age = age;
            this.name = name;
            this.grade = grade;
        }

        public string GetStudentInfo() {
            return "Name: " + this.name + "; Age: " + this.age + "; Grade: " + this.grade;
        }

        public bool IsFailing() {
            return this.grade < 2.0;
        }

        public string GetStudentInfo(bool includeGrade) {
            return includeGrade ? GetStudentInfo() : "Name: " + this.name + "; Age: " + this.age;
        }

        public string GetStudentStatus() {
            if (this.age <= 12) {
                return "Elementary School Student";
            }
            else if (this.age <= 15) {
                return "Middle School Student";
            }
            else if (this.age <= 18) {
                return "High School Student";
            }
            else {
                return "College Student";
            }
        }
    }
}