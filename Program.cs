using System;

namespace Employee
{
    class Program
    {
        //public const int EmpRatePerHrs= 20;

        // public const int Num_Of_Working_Days = 20;
        //public const int WorkingHrs = 60;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation!\n");
            EmpWageCompute emp = new EmpWageCompute();

            emp.addCompanyEmpWage("DMart", 20, 20, 60);
            emp.addCompanyEmpWage("Reliance", 20, 15, 30);
            emp.addCompanyEmpWage("VMware", 10, 20, 30);
            emp.addCompanyEmpWage("Rolex", 15, 10, 60);
            emp.ComputeEmpWage();






        }

    }
}