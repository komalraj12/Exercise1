using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_num
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, temp=0,m=0;
            Console.WriteLine("Enter number");
            n = Convert.ToInt32(Console.ReadLine());
            m = n / 2;
            for(int i=2;i<=m;i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("Not Prime number");
                    temp = 1;
                    break;
                }
            }
            if (temp == 0)
            {
                Console.WriteLine("Prime number");
            }
            
        }
    }
}
