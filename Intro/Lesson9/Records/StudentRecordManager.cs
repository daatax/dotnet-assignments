using System;
using System.Collections.Generic;

namespace Intro.Lesson9.Records
{
    public class StudentRecordManager
    {
        private List<Student> studentRecords = new List<Student>();

        public void AddStudentRecord(int studentID, string firstName, string lastName, double gpa) {
            Student student = new Student(studentID, firstName, lastName, gpa);
            studentRecords.Add(student);
        }

        public Student GetStudentRecord(int studentID) {
            return studentRecords.Find(student => student.StudentId == studentID);
        }

        public List<Student> ListAllStudentRecords() {
            return studentRecords;
        }
    }
}
