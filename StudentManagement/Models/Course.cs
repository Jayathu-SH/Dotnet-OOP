using System;
using System.Collections.Generic;

namespace StudentManagement.Models
{
    public class Course
    {
        public string CourseName { get; private set; }
        public Teacher CourseTeacher { get; private set; }
        private List<Student> students = new List<Student>();



        public Course(string courseName, Teacher teacher)
        {
            CourseName = courseName;
            CourseTeacher = teacher;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);//Add->abstraction
        }

        public void ShowCourseDetails()
        {
            Console.WriteLine($"Course: {CourseName}");
            Console.WriteLine("Teacher:");
            CourseTeacher.ShowInfo();

            Console.WriteLine("\nEnrolled Students:");
            foreach (var s in students)//s is a reference variable
            {
                s.ShowInfo();
            }
        }
    }
}