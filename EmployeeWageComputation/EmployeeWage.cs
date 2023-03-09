using System;
namespace EmployeeWageComputation
{
    public class EmployeeWage
    {
        const int IS_PRESENT=1,WAGE_PER_HR=20,FULL_DAY_HR=8,PART_TIME_HR=4,IS_FULL_TIME=0,IS_PART_TIME=1,TOTAL_WORKING_DAYS=20,TOTAL_WORKING_HOURS=100;
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
            int empHrs = 0;
            Random random = new Random();
            int check = random.Next(0, 3);
            for (int i = 0; i <= TOTAL_WORKING_DAYS && empHrs <= TOTAL_WORKING_HOURS; i++)
            {
                switch (check)
                {
                    case IS_FULL_TIME:
                        empHrs += FULL_DAY_HR;
                        break;
                    case IS_PART_TIME:
                        empHrs += PART_TIME_HR;
                        break;
                    default:
                        empHrs += 0;
                        break;
                }
            }
            int wage = WAGE_PER_HR * empHrs;
            Console.WriteLine("Employee Wage is: " + wage);
        }
    }
}