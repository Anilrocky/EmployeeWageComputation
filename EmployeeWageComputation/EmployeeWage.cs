using System;
namespace EmployeeWageComputation
{
    public class EmployeeWage
    {
        const int IS_PRESENT = 1, WAGE_PER_HR = 20, FULL_DAY_HR = 8, PART_TIME_HR = 4, IS_FULL_TIME = 0, IS_PART_TIME = 1;
        public void Attendance()
        {
            Random random = new Random();
            int check = random.Next(0,2);
            if (check == IS_PRESENT)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }
        public void DailyEmpWage()
        {
            int wage = WAGE_PER_HR * FULL_DAY_HR;
            Console.WriteLine("Daily Wage: " + wage);
        }
        public void PartTimeEmp()
        {
            int empHrs = 0;
            Random random = new Random();
            int check = random.Next(0,3);
            switch (check)
            {
                case IS_FULL_TIME:
                    empHrs = FULL_DAY_HR;
                    Console.WriteLine("Employee Present with Full Time");
                    break;
                case IS_PART_TIME:
                    empHrs = PART_TIME_HR;
                    Console.WriteLine("Employee Present with Part Time");
                    break;
                default:
                    empHrs = 0;
                    Console.WriteLine("Employee is Absent");
                    break;
            }
            int wage = WAGE_PER_HR * empHrs;
            Console.WriteLine("Wage is: " +wage);
        }
    }
}