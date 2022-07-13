using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageCalculation
{
    public class EmpWages
    {
        public const int EMP_PRESENT = 1, EMP_RATE_PER_HOUR = 20, FULL_TIME = 8, PART_TIME = 4;
        int empHours = 0;
        public bool PresentAbsent()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);

            if (empCheck == EMP_PRESENT)
            {
                Console.WriteLine("Employee is Present");
                return true;

            }
            else
            {
                Console.WriteLine("Employee is Absent");
                return false;
            }
           
        }
        public void CalDailyWage()
        {
            if (PresentAbsent())
            {
                empHours += FULL_TIME;
            }
            Console.WriteLine(EMP_RATE_PER_HOUR*empHours);
        }


        
    }
}
