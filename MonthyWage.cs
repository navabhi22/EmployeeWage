using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class MonthyWage
    {
        /// <summary>
        /// Calculating Monthly Wage
        /// </summary>
        public const int IsPresent = 1;
        public const int IsPartTime = 2;
        public const int PartTimeHour = 4;
        public const int WagePerHour = 20;
        public const int FullDayHour = 8;
        public void CalculateWageForMonth()
        {

            int TotalWage = 0;
            int WorkingHour;
            int DailyWage;
            for (int i = 0; i < 30; i++)
            {
                Random random = new Random();
                int AttendanceVariable = random.Next(3);
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
                TotalWage = TotalWage + DailyWage;
                Console.WriteLine("Daily wage of employee is " + DailyWage);

            }
            Console.WriteLine("Monthly wage of employee is " + TotalWage);
        }
    }
}
