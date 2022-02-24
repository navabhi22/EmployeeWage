using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Program");
            MonthyWage monthlyWage = new MonthyWage();
            monthlyWage.CalculateWageForMonth();
        }
    }
}