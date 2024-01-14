using System;

namespace Intro.Lesson6
{
    public class Person
    {
        private string name;
        private int age;

        public string Name {
            get { return name; }
            set {
                if (!string.IsNullOrEmpty(value)) {
                    name = value;
                }
            }
        }
        public int Age {
            get { return age; }
            set {
                if (value >= 0 && value <= 100) {
                    age = value;
                }
                else {
                    throw new ArgumentOutOfRangeException("Invalid input. Age must be between 0 and 100.");
                }
            }
        }

        public Person(string name, int age) {
            this.name = name;
            this.age = age;
        }

        public string GetDetails() {
            return "Name: " + name + "; Age: " + age;
        }
    }
}