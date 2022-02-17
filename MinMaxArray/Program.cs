using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[10];
            Random rnd = new Random();
            int min, max;
            for (int i = 0; i < n.Length; i++)
            {
                n[i] = rnd.Next(1, 100);
                Console.WriteLine(n[i]);
            }
            min = n[0];
            max = n[0];
            for (int i = 0; i < n.Length;i++)
            {
                if (min > n[i])
                {
                    min = n[i];
                }
                if (max < n[i])
                {
                    max = n[i];
                }                   
            }
            Console.WriteLine("The Highest number in the array is " + max);
            Console.WriteLine("The Lowest number in the array is " + min);
            Console.ReadKey();

        }
    }
}
