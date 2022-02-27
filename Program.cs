using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of companies");
            int num = Convert.ToInt32(Console.ReadLine());
            ForMultipleCompanies wage = new ForMultipleCompanies();
            wage.WagesForMultipleCompanies(num);

        }
            
    }
}