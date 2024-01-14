using System;

namespace Intro.Lesson6
{
    public class University
    {
        private string name;
        private List<Teacher> teachers = new List<Teacher>();
        private List<Student> students = new List<Student>();
        private List<Course> courses = new List<Course>();

        public string Name {
            get { return name; }
            set {
                if (!string.IsNullOrEmpty(value)) {
                    name = value;
                }
            }
        }

        public University(string name) {
            this.name = name;
        }

        /// <summary>
        /// Gets the number of the teachers working in the <see cref="University"/>.
        /// </summary>
        /// <returns></returns>
        public int GetTeachersCount() {
            return teachers.Count;
        }
        /// <summary>
        /// Gets the names of the teachers working in the <see cref="University"/> in a string.
        /// </summary>
        /// <returns></returns>
        public string GetTeachersNames() {
            var names = from teacher in teachers
                        select teacher.Name;

            return string.Join("; ", names);
        }
        /// <summary>
        /// Adds a <see cref="Teacher"/> to the <see cref="University"/>.
        /// </summary>
        /// <param name="teacher"></param>
        public void AddTeacher(Teacher teacher) {
            teachers.Add(teacher);
        }
        /// <summary>
        /// Removes a <see cref="Teacher"/> from the <see cref="University"/>.
        /// </summary>
        /// <param name="teacher"></param>
        public void RemoveTeacher(Teacher teacher) {
            teachers.Remove(teacher);
        }

        /// <summary>
        /// Gets the number of the students learning in the <see cref="University"/>.
        /// </summary>
        /// <returns></returns>
        public int GetStudentsCount() {
            return students.Count;
        }
        /// <summary>
        /// Gets the names of the students learning in the <see cref="University"/> in a string.
        /// </summary>
        /// <returns></returns>
        public string GetStudentsNames() {
            var names = from student in students
                        select student.Name;

            return string.Join("; ", names);
        }
        /// <summary>
        /// Adds a <see cref="Student"/> to the <see cref="University"/>.
        /// </summary>
        /// <param name="student"></param>
        public void AddStudent(Student student) {
            students.Add(student);
        }
        /// <summary>
        /// Removes a <see cref="Student"/> from the <see cref="University"/>.
        /// </summary>
        /// <param name="student"></param>
        public void RemoveStudent(Student student) {
            students.Remove(student);
        }
        /// <summary>
        /// Get the number of major <see cref="Course"/> in the <see cref="University"/>.
        /// </summary>
        /// <returns></returns>
        public int GetCoursesCount() {
            return courses.Count;
        }
        /// <summary>
        /// Get the names of major <see cref="Course"/> in the <see cref="University"/> in a string
        /// </summary>
        /// <returns></returns>
        public string GetCourseNames() {
            var names = from course in courses
                        select course.Name;

            return string.Join("; ", names);
        }
        /// <summary>
        /// Add a <see cref="Course"/> to the <see cref="University"/>.
        /// </summary>
        /// <param name="course"></param>
        public void AddCourse(Course course) {
            courses.Add(course);
        }
        /// <summary>
        /// Removes a <see cref="Course"/> from the <see cref="University"/>.
        /// </summary>
        /// <param name="course"></param>
        public void RemoveCourse(Course course) {
            courses.Remove(course);
        }
        /// <summary>
        /// Joins the lists of <see cref="Course"/> and <see cref="Student"/>, and groups by the 
        /// <see cref="Course"/> in order to count the number of <see cref="Student"/> enrolled in the specific <see cref="Course"/>
        /// </summary>
        /// <returns>
        /// A string containing the name of the <see cref="Course"/> and the number of <see cref="Student"/>.
        /// </returns>
        public string GetStudentsCountPerCourse() {
            var result = from course in courses
                         join student in students
                         on course.Name equals student.Major
                         group course by course.Name into groupedCourses
                         select new {
                             CourseName = groupedCourses.Key,
                             CountOfStudents = groupedCourses.Count()
                         };

            return string.Join("\n", result);
        }
        /// <summary>
        /// Gets the names of the <see cref="Student"/> enrolled in each <see cref="Course"/>.
        /// </summary>
        /// <returns>
        /// A string containing the name of the <see cref="Course"/> and the names of the <see cref="Student"/>.
        /// </returns>
        public string GetStudentsNamesPerCourse() {
            List<string> result = new List<string>();

            foreach (Course course in courses) {
                var enrolledStudents = students.Where(student => student.Major == course.Name)
                                                    .Select(student => student.Name)
                                                    .ToList();

                var courseAndStudents = new {
                    CourseName = course.Name,
                    StudentNames = string.Join(", ", enrolledStudents)
                };

                result.Add("{ CourseName = '" + courseAndStudents.CourseName +
                            "'; StudentNames = " + courseAndStudents.StudentNames + " }");
            }

            return string.Join("\n", result);
        }
        /// <summary>
        /// Gets the number of the <see cref="Student"/> per each <see cref="Teacher"/>.
        /// </summary>
        /// <returns>
        /// A string containing the name of the <see cref="Teacher"/> and the number of the <see cref="Student"/>.
        /// </returns>
        public string GetStudentsCountPerTeacher() {
            var result = from teacher in teachers
                         join student in students
                         on teacher.Profession equals student.Major
                         group teacher by teacher.Name into groupedTeachers
                         select new {
                             TeacherName = groupedTeachers.Key,
                             CountOfStudents = groupedTeachers.Count()
                         };

            return string.Join("\n", result);
        }

        /// <summary>
        /// Gets the names of the <see cref="Student"/> per each <see cref="Teacher"/>.
        /// </summary>
        /// <returns>
        /// A string containing the name of the <see cref="Teacher"/> and the names of their <see cref="Student"/>.
        /// </returns>
        public string GetStudentsNamesPerTeacher() {
            List<string> result = new List<string>();

            foreach (Teacher teacher in teachers) {
                var students = this.students.Where(student => student.Major == teacher.Profession)
                                            .Select(student => student.Name)
                                            .ToList();

                var studentAndTeachers = new {
                    TeacherName = teacher.Name,
                    StudentName = string.Join(", ", students)
                };

                result.Add("{ TeacherName = '" + studentAndTeachers.TeacherName +
                            "'; StudentsName = " + studentAndTeachers.StudentName + " }");
            }

            return string.Join("\n", result);
        }

        /// <summary>
        /// Gets the number of the <see cref="Teacher"/> per each <see cref="Course"/>.
        /// </summary>
        /// <returns>
        /// A string containing the name of the <see cref="Course"/> and the number of the <see cref="Teacher"/>.
        /// </returns>
        public string GetTeachersCountPerCourses() {
            var result = from course in courses
                         join teacher in teachers
                         on course.Name equals teacher.Profession
                         group course by course.Name into groupedCourse
                         select new {
                             CourseName = groupedCourse.Key,
                             CuntOfTeachers = groupedCourse.Count()
                         };

            return string.Join("\n", result);
        }

        /// <summary>
        /// Gets the names of the <see cref="Teacher"/> per each <see cref="Course"/>.
        /// </summary>
        /// <returns>
        /// A string containing the name of the <see cref="Course"/> and the names of the <see cref="Teacher"/>.
        /// </returns>
        public string GetTeachersNamesPerCourse() {
            List<string> result = new List<string>();

            foreach (Course course in courses) {
                var teachers = this.teachers.Where(teacher => teacher.Profession == course.Name)
                                            .Select(teacher => teacher.Name)
                                            .ToList();

                var courseAndTeachers = new {
                    CourseName = course.Name,
                    TeacherName = string.Join(", ", teachers)
                };

                result.Add("{ CourseName = '" + courseAndTeachers.CourseName +
                            "'; TeacherName = " + courseAndTeachers.TeacherName + " }");
            }

            return string.Join("\n", result);
        }
    }
}