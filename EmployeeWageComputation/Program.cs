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
            EmployeeWage wage = new EmployeeWage();
            wage.DailyEmpWage();
        }
    }
}