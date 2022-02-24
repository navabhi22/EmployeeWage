using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class AddPartTime
    {
        /// <summary>
        /// Calculate Daily Wages including PartTime
        /// </summary>
        public static int AttendanceVariable;
        public static int IsAbsent = 0;
        public static int IsPresent = 1;
        public static int IsPartTime = 2;
        public static int WagePerHour = 20;
        public static int FullDayHour = 8;
        public static int PartTimeHour = 4;
        public static int WorkingHour;
        public static int DailyWage;

        public void CalculateDailyWage()
        {
            Random random = new Random();
            AttendanceVariable = random.Next(3);

            if (AttendanceVariable == IsPresent)

            {
                WorkingHour = FullDayHour;
                Console.WriteLine("Employee is Present");
            }
            else if (AttendanceVariable == IsPartTime)
            {
                WorkingHour = PartTimeHour;
                Console.WriteLine("PartTime");
            }
            else if (AttendanceVariable==IsAbsent)
            {
                WorkingHour = 0;
                Console.WriteLine("Employee is Absent");
            }

            DailyWage = WagePerHour * WorkingHour;
            Console.WriteLine("Daily wage of employee is " + DailyWage);

        }
    }
}
