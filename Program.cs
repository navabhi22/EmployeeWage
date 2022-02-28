using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("dMart", 30, 25, 120);
            empWageBuilder.addCompanyEmpWage("Parle", 30, 25, 120);
            empWageBuilder.computeEmpWage();
        }
            
    }
}