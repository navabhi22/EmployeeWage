using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal interface Interface1
    {
        void ComputeEmpWage();
        string tostring();
    }
    public class EmployeeWageBuilder : Interface1
    {
        /// <summary>
        /// Calculate employe wage and save Total wage by company
        /// </summary>
        public const int IsPresent = 1;
        public const int IsPartTime = 2;
        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;
        public EmployeeWageBuilder(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)

        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void ComputeEmpWage()
        {
            //variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            //Computation
            while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkingDays <= this.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case (IsPresent):
                        empHrs = 8;
                        break;
                    case (IsPartTime):
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;

                }

                totalEmpHrs += empHrs;
                Console.WriteLine("Day# " + totalWorkingDays + "  Emp Hrs " + empHrs);
            }
            totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage for company:" + company + " is " + totalEmpWage);
        }
        public string tostring()
        {
            return "Total Emp Wage for company : " + company + " is " + totalEmpWage;
        }
    }
}
