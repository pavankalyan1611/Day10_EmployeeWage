using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageCalculation
{
    public class EmpWages
    {
        public const int EMP_ABSENT = 0, PART_TIME = 1, FULL_TIME = 2, EMP_RATE_PER_HOUR = 20, FULL_TIME_HOURS = 8, PART_TIME_HOURS = 4;
        public const int MAX_WORKING_HOURS = 100, MAX_WORKING_DAYS = 20;
        public EmpWages()
        {
            Console.WriteLine("Welcome To Employee Wage Problem:\n");
        }
        public static int ComputeEmpWage()
        {
            int totalEmpWage = 0, totalEmpHrs = 0, totalworkingDays = 0,empHours = 0;

            while (totalEmpHrs <= MAX_WORKING_HOURS && totalworkingDays <= MAX_WORKING_DAYS)
            {
                totalworkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case EMP_ABSENT:                     
                        break;
                    case PART_TIME:
                        empHours = PART_TIME_HOURS;
                        break;
                    case FULL_TIME:
                        empHours = FULL_TIME_HOURS;
                        break;
                }
                totalEmpHrs += empHours;
                Console.WriteLine($"Day {totalworkingDays}; emp Hours{empHours}" );
            }
            totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine(" Total Emp Wage  : " + totalEmpWage);

            return totalEmpWage;
        }
    }
}
