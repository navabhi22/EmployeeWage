using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class MonthlyWagesForMultipleCompanies
    {
        /// <summary>
        /// Calulating Wage for 20 days or less than 100 hours
        /// </summary>
        public static int TotalWage = 0;
        public static int WorkingHour;
        public static int DailyWage;
        public static int TotalWorkingDay = 0;
        public static int AttendanceVariable;
        public const int IsPresent = 1;
        public const int IsPartTime = 2;
        public const int PartTimeHour = 4;
        public const int FullDayHour = 8;
        public void WageForMonth(int WagePerHour, int MaxWorkingDays, int WorkingHourPerMonth )
        {
            int TotalWorkingHour = 0;
            while (TotalWorkingDay < MaxWorkingDays && TotalWorkingHour < WorkingHourPerMonth)

            {
                Random random = new Random();
                AttendanceVariable = random.Next(3);
                switch (AttendanceVariable)
                {
                    case (IsPresent):
                        WorkingHour = FullDayHour;
                        break;
                    case (IsPartTime):
                        WorkingHour = PartTimeHour;
                        break;
                    default:
                        WorkingHour = 0;
                        break;

                }
                
                TotalWorkingHour = TotalWorkingHour + WorkingHour;
                DailyWage = WagePerHour * WorkingHour;
                TotalWage = TotalWage + DailyWage;
                TotalWorkingDay++;

            }
            Console.WriteLine("Total Working Hour" + TotalWorkingHour);
            Console.WriteLine("Monthly wage of employee is " + TotalWage);
        }
    }
}
