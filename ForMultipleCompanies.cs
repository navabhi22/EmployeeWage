using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class ForMultipleCompanies
    {
        public void WagesForMultipleCompanies(int NumberOfCompanies)
        {
            
            for ( int i = 0; i < NumberOfCompanies; i++ )
            {
                Console.WriteLine("Welcome to Employee Wage Program for multiple Companies");
                Console.WriteLine("Enter the Name of company");
                string company = Console.ReadLine();
                Console.WriteLine("Enter the wage rate of {0} company", company);
                int WagePerHour = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the number of working days per month in {0} company", company);
                int MaxWorkingDays = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the number of maximum working hour per month in {0} company", company);
                int MaxWorkingHour = Convert.ToInt32(Console.ReadLine());

                MonthlyWagesForMultipleCompanies monthlyWage = new MonthlyWagesForMultipleCompanies();
                monthlyWage.WageForMonth(company, WagePerHour, MaxWorkingDays, MaxWorkingHour);
                
            }
        }
    }
}
