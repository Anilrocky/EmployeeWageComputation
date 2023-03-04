using System;
namespace EmployeeWageComputation
{
    public class EmployeeWage
    {
        const int IS_PRESENT = 1,WAGE_PER_HR=20,FULL_DAY_HR=8;
        public void Attendance()
        {
            Random random = new Random();
            int check = random.Next(0,2);
            if (check == IS_PRESENT)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }
        //Daily Wage Calculation
        public void DailyEmpWage()
        {
            int wage = WAGE_PER_HR * FULL_DAY_HR;
            Console.WriteLine(wage);
        }
    }
}
