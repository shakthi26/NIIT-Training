using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("To Find Leap Year or Not :");
            Console.WriteLine("Enter the Year");
            year = Convert.ToInt32(Console.ReadLine());
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0 ))
            {
                Console.WriteLine("{0} is a leap year",year);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year", year);
            }
            Console.ReadKey();
        }
    }
}
