using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSystem
{
    public class Student : Person
    {
       

        public string StudentId { get; set; }
        public int Grade { get; set; }

        public Student(string name ) :base(name)
        {
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Student Name: {Name}, Age: {Age}, School: {SchoolName}, Student ID: {StudentId}, Grade: {Grade}");
        }
    }
}
