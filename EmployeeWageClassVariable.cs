using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmployeeWageClassVariable
    {
        /// <summary>
        /// Calulating Wage for 10 days or less than 100 hours
        /// </summary>
        public static int TotalWage = 0;
        public static int WorkingHour;
        public static int DailyWage;
        public static int TotalWorkingDay = 0;
        public static int AttendanceVariable;
        public const int IsPresent = 1;
        public const int IsPartTime = 2;
        public const int PartTimeHour = 4;
        public const int WagePerHour = 20;
        public const int FullDayHour = 8;
        public static int TotaWorkingHour = 0;
        public void WageForMonth()
        {
            while (TotalWorkingDay < 20 && TotaWorkingHour < 100)

            {
                Random random = new Random();
                AttendanceVariable = random.Next(3);
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

                TotaWorkingHour = TotaWorkingHour + WorkingHour;
                DailyWage = WagePerHour * WorkingHour;
                TotalWage = TotalWage + DailyWage;
                Console.WriteLine("Daily wage of employee is " + DailyWage);
                int TotalWorkingHour = TotaWorkingHour + WorkingHour;
                TotalWorkingDay++;

            }
            Console.WriteLine("Total Working Hour" + TotaWorkingHour);
            Console.WriteLine("Monthly wage of employee is " + TotalWage);
        }
    }
}
