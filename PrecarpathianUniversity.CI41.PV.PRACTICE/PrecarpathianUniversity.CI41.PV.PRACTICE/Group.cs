using System;
using System.Collections.Generic;
using System.Linq;

namespace PrecarpathianUniversity.CI41.PV.PRACTICE
{
    public class Group
    {
        private int _currentId;

        public List<Student> GroupStudents = new List<Student>();


        public Group(string groupName, int yearOfStudy)
        {
            GroupId = GetNextId();
            GroupName = groupName;
            YearOfStudy = yearOfStudy;
        }

        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public int YearOfStudy { get; set; }

        private int GetNextId()
        {
            return ++_currentId;
        }

        public void CreateStudent()
        {
            Console.WriteLine("Type in name of a student");
            var studentName = Console.ReadLine();
            Console.WriteLine("Type in birthday date");
            var birthdayDate = Console.ReadLine();
            Console.WriteLine("Type in some data");
            var dataAbout = Console.ReadLine();
            var student = new Student(studentName, birthdayDate, dataAbout);
            GroupStudents.Add(student);
        }

        public void UpdateStudent(int studentId)
        {
            foreach (var std in GroupStudents.Where(std => std.StudentId == studentId).ToArray())
            {
                Console.WriteLine("NEW name of a student");
                var studentName = Console.ReadLine();
                std.StudentName = studentName;
                Console.WriteLine("NEW birthday date");
                var birthdayDate = Console.ReadLine();
                std.BirthdayDate = birthdayDate;
                Console.WriteLine("NEW data");
                var dataAbout = Console.ReadLine();
                std.DataAboutFormOfStudy = dataAbout;
            }
        }

        public void ShowStudents()
        {
            foreach (var student in GroupStudents) Console.WriteLine(student.ToString());
        }

        public void RemoveDepartment(int studentId)
        {
            foreach (var std in GroupStudents.Where(std => std.StudentId == studentId).ToArray())
                GroupStudents.Remove(std);
        }

        public void ShowDepartment(int studentId)
        {
            foreach (var std in GroupStudents.Where(std => std.StudentId == studentId).ToArray())
                Console.WriteLine(std);
        }

        public override string ToString()
        {
            return string.Format("{0}  -  {1}  -  {2}", GroupId, GroupName, YearOfStudy);
        }
    }
}