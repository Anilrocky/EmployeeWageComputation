using System;
namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");
            EmployeeWage employeeWage = new EmployeeWage();
            employeeWage.Attendance();
            employeeWage.DailyEmpWage("Infosys", 35, 20, 100);
            employeeWage.DailyEmpWage("CGI", 20, 25, 90);
            employeeWage.DailyEmpWage("Spatial", 30, 24, 120);
            employeeWage.DailyEmpWage("L&T", 20, 20, 130);
        }
    }
}