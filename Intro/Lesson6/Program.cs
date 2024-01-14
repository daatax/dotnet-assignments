using System;

namespace Intro.Lesson6
{
    public class Program
    {
        public static void Main(string[] args) {

            University university = new University("Penn Engineering");

            // Adding Major Courses to the University
            List<Course> majorCourses = new List<Course>() {
                new Course("C#", "101"),
                new Course("C++", "202"),
                new Course("Java", "303"),
                new Course("Computer Science", "404"),
            };

            foreach (Course course in majorCourses) {
                university.AddCourse(course);
            }

            // Adding Students to the University
            List<Student> students = new List<Student>() {
                new Student("Jack", 21, new Course("C#", "101")),
                new Student("Ammie", 23,new Course("C#", "101")),
                new Student("Henry", 22, new Course("C++", "202")),
                new Student("Samuel", 22, new Course("Computer Science", "404")),
                new Student("Suzan", 18, new Course("Java", "303")),
                new Student("William", 24, new Course("Java", "303")),
                new Student("Hayden", 22, new Course("Java", "303")),
                new Student("Gillian", 20, new Course("C#", "101")),
                new Student("Anthony", 25, new Course("C#", "101")),
            };

            foreach (Student student in students) {
                university.AddStudent(student);
            }

            // Adding Teachers to the University
            List<Teacher> teachers = new List<Teacher>() {
                new Teacher("Dr. Johnson", 54,  new Course("C#", "101")),
                new Teacher("Dr. Blanco", 47, new Course("Java", "303")),
                new Teacher("Profesor Smith", 67, new Course("C++", "202")),
                new Teacher("Hayes Giffors", 33, new Course("Computer Science", "404")),
                new Teacher("Ammie Grant (C++ TA)", 24, new Course("C++", "202")),
                new Teacher("Lenale Adnew", 32, new Course("C#", "101")),
                new Teacher("Evan Blanco", 37, new Course("Java", "303")),
            };

            foreach (Teacher teacher in teachers) {
                university.AddTeacher(teacher);
            }

            Console.WriteLine("The University name is: " + university.Name + "\n");
            Console.WriteLine("There are " + university.GetTeachersCount() + " teachers in the university of " + university.Name);

            Console.WriteLine("These are teachers' names: " + university.GetTeachersNames() + "\n");
            Console.WriteLine(university.GetStudentsCount() + " students are studying in the university of " + university.Name);

            Console.WriteLine("These are students' names: " + university.GetStudentsNames() + "\n");
            Console.WriteLine("There are " + university.GetCoursesCount() + " major courses in the university of " + university.Name + "\n");

            Console.WriteLine("These are the courses' names: " + university.GetCourseNames() + "\n");

            Console.WriteLine("Courses and enrolled students count: \n" + university.GetStudentsCountPerCourse() + "\n");
            Console.WriteLine("Courses and enrolled students names: \n" + university.GetStudentsNamesPerCourse() + "\n");

            Console.WriteLine("Courses and the number of the Teachers: \n" + university.GetTeachersCountPerCourses() + "\n");
            Console.WriteLine("Courses and names of the Teachers: \n" + university.GetTeachersNamesPerCourse() + "\n");

            Console.WriteLine("Teachers and number of their students: \n" + university.GetStudentsCountPerTeacher() + "\n");
            Console.WriteLine("Teachers and names of their students: \n" + university.GetStudentsNamesPerTeacher());
        }
    }
}