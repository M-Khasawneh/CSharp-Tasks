using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSystem
{
    public class Person
    {
        public string Name { get; set; } 
        public int Age { get; set; }

        protected string SchoolName { get; set; } = "Default School";

        private int _internalCode { get; set; }

        
        public Person()
        {
            
        }
        public Person(string name)
        {
            Name = name;
        }

        public Person(string name, int age, string schoolName)
        {
            Name = name;
            Age = age;
            SchoolName = schoolName;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age} ");
        }

        

       
    }
}
