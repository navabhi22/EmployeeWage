using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeWageBuilderObject dMart = new EmployeeWageBuilderObject("dMart",30,25,120);
            EmployeeWageBuilderObject Parle = new EmployeeWageBuilderObject("Parle", 30, 25, 120);
            dMart.ComputeEmpWage();
            Console.WriteLine(dMart.ToString());
            Parle.ComputeEmpWage();
            Console.WriteLine(Parle.ToString());
        }
            
    }
}