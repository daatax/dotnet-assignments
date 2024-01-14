using System;
using System.Collections.Generic;

namespace Intro.Lesson9.Records
{
    public class StudentsMain
    {
        public static void Main(string[] args) {
            StudentRecordManager studentManager = new StudentRecordManager();

            studentManager.AddStudentRecord(101, "John", "Doe", 3.4);
            studentManager.AddStudentRecord(202, "Samuel", "Smith", 2.8);
            studentManager.AddStudentRecord(303, "Ammie", "Wild", 3.6);
            studentManager.AddStudentRecord(404, "Hayden", "Grant", 3.1);
            studentManager.AddStudentRecord(505, "Gillian", "Metz", 3.9);

            Console.WriteLine("Getting the student's record based on the ID ...");
            Console.WriteLine(studentManager.GetStudentRecord(202).ToString());
            Console.WriteLine(studentManager.GetStudentRecord(303).ToString());
            Console.WriteLine(studentManager.GetStudentRecord(505).ToString());

            Console.WriteLine("\nPrint all student records. ");
            List<Student> allStudents = studentManager.ListAllStudentRecords();
            foreach (var student in allStudents) {
                Console.WriteLine(student.ToString());
            }
        }
    }
}