using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Employee
    {
        double Monthly_Salary,Basic_Salary, House_Rent_Allowance, Transport_Allowance, Provident_Fund, Income_Tax, Insurance;

        public void Salary_Cal()
        {
            Console.WriteLine("Enter the Annual Package");

            int Annual_Package = Convert.ToInt32(Console.ReadLine());
            Basic_Salary = 0.2 * Annual_Package;
            House_Rent_Allowance = 0.2 * Annual_Package;
            Transport_Allowance = 0.1 * Annual_Package;
            Provident_Fund = 0.1 * Annual_Package;
            Income_Tax = 0.1 * Annual_Package;
            Insurance = 0.2 * Annual_Package;

            Monthly_Salary = Basic_Salary + House_Rent_Allowance + Transport_Allowance - Provident_Fund - Income_Tax - Insurance;
            

            Console.WriteLine("Total Salary for a month is {0}", Monthly_Salary); 

        }

    }
}
