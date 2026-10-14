using System;


namespace EmployeeManagementSystem
{
    public class Person
    {
        private string _name;

        private DateOnly _dateOfBirth;

        public int Age
        {
            get
            {
                DateOnly today = DateOnly.FromDateTime(DateTime.Today);
                int age = today.Year - _dateOfBirth.Year;

                if (_dateOfBirth > today.AddYears(-age))
                {
                    age--;
                }

                return age;
            }
        }
        public DateOnly DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
            set
            {
                if (value > DateOnly.FromDateTime(DateTime.Now)|| value < DateOnly.FromDateTime(new DateTime(1950, 1, 1)))
                {
                    throw new Exception("Invalid Date of Birth , must be between 1950 and the current date");
                }
                _dateOfBirth = value;
            }
        }
        public string Name 
        { 
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value)||value=="")
                {
                    throw new ArgumentOutOfRangeException("Name Cannot be Empty");  
                }
                 _name = value.Trim();
            }
        }
        public Person( string name, DateOnly dateOfBirth)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
        }

        
    }
}
