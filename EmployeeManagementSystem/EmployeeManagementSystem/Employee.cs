using System;

namespace EmployeeManagementSystem
{
    public abstract class Employee : Person
    {
        private int _employeeId { get; set; }
        public int EmployeeId
        {
            get { return _employeeId; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Employee ID cannot be negative");
                }
                _employeeId = value;
            }
        }
        protected Employee(string name, DateOnly dateOfBirth,int employeeId ) : base(name, dateOfBirth)
        {
            _employeeId = employeeId;
        }
        public abstract decimal CalculateSalary();
        public abstract void DisplayInfo();

    }
}
