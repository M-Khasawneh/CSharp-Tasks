using System;


namespace EmployeeManagementSystem
{
    internal class FullTimeEmployee : Employee, IWorkable
    {
        private decimal _monthlySalary { get; set; }

        public decimal MonthlySalary
        {
            get { return _monthlySalary; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Monthly Salary cannot be negative");
                }
                _monthlySalary = value;
            }
        }
        public FullTimeEmployee(string name, DateOnly dateOfBirth, int employeeId , decimal monthlySalary) : base(name, dateOfBirth, employeeId)
        {
            MonthlySalary = monthlySalary;
        }

        public override decimal CalculateSalary()
        {
            return MonthlySalary;
        }

        public void Work()
        {
            Console.WriteLine($"Full-time employee {Name} is working.");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Full-time employee {Name} (ID: {EmployeeId}) has a monthly salary of {MonthlySalary:C}");
        }
    }
}
