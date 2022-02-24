using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
        public class CalculateDailyWage
        {

        /// <summary>
        /// The is present
        /// </summary>
                public static int IsPresent = 1;
                public static int WagePerHour = 20;
                public static int FullDayHour = 8;
                public static int WorkingHour;
                public static int DailyWage;
                public static int AttendanceVariable;

            public void DailyWageCalculated()
            {
                
                Random random = new Random();
                AttendanceVariable = random.Next(2);
                
                if (AttendanceVariable == IsPresent)

                {
                    WorkingHour = FullDayHour;
                    Console.WriteLine("Employee is Present");
                }
                else
                {
                    WorkingHour = 0;
                    Console.WriteLine("Employee is Absent");
                }

                DailyWage = WagePerHour * WorkingHour;
                Console.WriteLine("Daily wage of employee is " + DailyWage);
            }
        }
}

