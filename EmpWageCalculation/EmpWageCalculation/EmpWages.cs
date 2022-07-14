using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageCalculation
{
    public class EmpWages
    {
        public const int PART_TIME = 1, FULL_TIME = 2, EMP_RATE_PER_HOUR = 20, FULL_TIME_HOURS = 8, PART_TIME_HOURS = 4;
        int empHours = 0;
        int EmpWage = 0;
        public void AddingPartTime()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);

            if (empCheck == PART_TIME)
            {
                Console.WriteLine("Employee is Present For Part Time ");
                empHours = PART_TIME_HOURS;
            }
            else if (empCheck == FULL_TIME)
            {
                Console.WriteLine("Employee is Present For Full Time ");
                empHours = FULL_TIME_HOURS;
            }
            else            
                Console.WriteLine("Employee is Absent ");
            
            EmpWage = EMP_RATE_PER_HOUR * empHours;
            Console.WriteLine($"Emp Wage : {EmpWage}");
        }
    }
}
