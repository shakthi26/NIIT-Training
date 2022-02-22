using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Employee
    {
        double Salary,House_Rent_Allowance, Transport_Allowance, Provident_Fund, Income_Tax, Insurance;

        public void Salary_Cal()
        {
            Console.WriteLine("Enter the Basic Salary");

            int Basic_Salary = Convert.ToInt32(Console.ReadLine());
            House_Rent_Allowance = 0.4 * Basic_Salary;
            Transport_Allowance = 0.2 * Basic_Salary;
            Provident_Fund = 0.1 * Basic_Salary;
            Income_Tax = 0.3 * Basic_Salary;
            Insurance = 0.5 * Basic_Salary;

            Salary = Basic_Salary + House_Rent_Allowance + Transport_Allowance 
            Salary = Salary – Provident_Fund – Income_Tax – Insurance;

            Console.WriteLine("Total Salary for a month is {0}", Salary);
            
        }

    }
}
