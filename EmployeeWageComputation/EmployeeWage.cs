using System;
namespace EmployeeWageComputation
{
    public class EmployeeWage
    {
        const int IS_PRESENT = 1, FULL_DAY_HR = 8, PART_TIME_HR = 4, IS_FULL_TIME = 0, IS_PART_TIME = 1;
        public void Attendance()
        {
            Random random = new Random();
            int check = random.Next(0,2);
            if (check == IS_PRESENT)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }
        public void DailyEmpWage(string Company_Name,int Wage_Per_Hr,int Total_Working_Days,int Total_Working_Hrs)
        {
            int empHrs = 0;
            Random random = new Random();
            int check = random.Next(0, 3);
            for (int i = 0; i <= Total_Working_Days && empHrs <= Total_Working_Hrs; i++)
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
            int wage = Wage_Per_Hr * empHrs;
            Console.WriteLine("Employee Wage is: " + wage);
        }
    }
}