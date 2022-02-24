using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class EmployeeWageUsingSwitchCase
    {
        /// <summary>
        /// EmployeeWageProgram by using Switch Case
        /// </summary>
        public const int IsPresent = 1;
        public const int IsPartTime = 2;
        public const int PartTimeHour = 4;
        public const int WagePerHour = 20;
        public const int FullDayHour = 8;
        public void CalculateDailyWage()
        {
            Random random = new Random();
            int AttendanceVariable = random.Next(3);

            int WorkingHour;
            int DailyWage;

            switch (AttendanceVariable)
            {
                case (IsPresent):
                    WorkingHour = FullDayHour;
                    Console.WriteLine("Employee is Present");
                    break;
                case (IsPartTime):
                    WorkingHour = PartTimeHour;
                    Console.WriteLine("PartTime");
                    break;
                default:
                    WorkingHour = 0;
                    Console.WriteLine("Employee is Absent");
                    break;

            }


            DailyWage = WagePerHour * WorkingHour;
            Console.WriteLine("Daily wage of employee is " + DailyWage);
        }
    }
}
