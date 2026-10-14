namespace EmployeeManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor= ConsoleColor.Red;
            var partTimeEmployee = new PartTimeEmployee("John Doe", new DateOnly(1990, 1, 1), 1, 20.5m, 80);
            partTimeEmployee.Work();
            partTimeEmployee.DisplayInfo();
            Console.ForegroundColor = ConsoleColor.Green;

            var fullTimeEmployee = new FullTimeEmployee("Jane Smith", new DateOnly(1985, 5, 15), 2, 5000m);
            fullTimeEmployee.Work();
            fullTimeEmployee.DisplayInfo();
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
