using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageCalculation
{
    public class EmpWages
    {
        public const int EMP_PRESENT = 1;
        public void PresentAbsent()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);

            if (empCheck == EMP_PRESENT)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }

        }
    }
}
