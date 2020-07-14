using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, avg;
            Console.WriteLine("Enter 3 numbers for average");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            avg = (a + b + c) / 3;
            Console.WriteLine("Average of given numbers are : " +avg);
        }
    }
}
