using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class CheckEmployee
    {
        /// <summary>
        /// Check if Employee Present or Absent.
        /// </summary>
        public static int IsPresent = 1;
        public void CheckEmployeePresentOrNot()
        {
            Random random = new Random();
            int AttendanceVariable = random.Next(2);

            if (AttendanceVariable == IsPresent)

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
    

