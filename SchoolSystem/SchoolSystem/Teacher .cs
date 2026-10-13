using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSystem
{
    public class Teacher : Person
    {
        public string Subject { get; set; }

        public Teacher(string name) : base(name)
        {
        }

        public void DisplayTeacherInfo()
        {
            Console.WriteLine($"Teacher Name: {Name}, Age: {Age}, Subject: {Subject}");
        }   
    }
}
