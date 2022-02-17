using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApplication1
{
    class Program
    {
        static void AreaRectangle()
        {
            int l, b, ar;
            Console.WriteLine("Enter the Length");
            l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Breadth");
            b = Convert.ToInt32(Console.ReadLine());
            ar = l * b;
            Console.WriteLine("Area of the Rectangle = " + ar);
        }



        static void AreaCircle()
        {
            int r;
            double ac;
            Console.WriteLine("Enter the Radius");
            r = Convert.ToInt32(Console.ReadLine());
            ac = 3.14 * r * r;
            Console.WriteLine("Area of the Circle = " + ac);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("To find Area of the Rectangle:");
            AreaRectangle();
            Console.WriteLine("--------------------------");
            Console.WriteLine("To find Area of the Circle:");
            AreaCircle();
            Console.ReadKey();
        }
    }
}