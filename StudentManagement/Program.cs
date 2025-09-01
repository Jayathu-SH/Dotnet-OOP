using System;
using StudentManagement.Models;

namespace StudentManagement{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Jayathu", 21, "cs101");
            Student s2 = new Student("Sanka", 22, "cs102");

            Teacher t1 = new Teacher("Naveen", 30, "Maths");

            Course course = new Course("OOP .NET", t1);
            course.AddStudent(s1);
            course.AddStudent(s2);

            course.ShowCourseDetails();

        }
    }
   
}
