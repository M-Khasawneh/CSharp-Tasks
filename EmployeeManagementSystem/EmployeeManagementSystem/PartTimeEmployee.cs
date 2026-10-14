using System;


namespace EmployeeManagementSystem
{
    internal class PartTimeEmployee : Employee, IWorkable
    {

        private decimal _hourlyRate;
        private decimal _hoursWorked;

        public decimal HourlyRate
        {
            get { return _hourlyRate; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Hourly Rate cannot be negative");
                }
                _hourlyRate = value;
            }
        }

        public decimal HoursWorked
        {
            get { return _hoursWorked; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Hours Worked cannot be negative");
                }
                _hoursWorked = value;
            }
        }
        public PartTimeEmployee(string name, DateOnly dateOfBirth, int employeeId, decimal hourlyRate, decimal hoursWorked) : base(name, dateOfBirth, employeeId)
        {
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }
        public override decimal CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }

        public void Work()
        {
            Console.WriteLine($"Part-time employee {Name} is working.");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Part-time employee {Name} (ID: {EmployeeId}) has worked {HoursWorked} hours at an hourly rate of {HourlyRate:C}");
        }
    }
}
