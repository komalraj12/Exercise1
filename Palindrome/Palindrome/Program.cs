using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, rem, temp, sum = 0;
            Console.WriteLine("Enter number");
            n = Convert.ToInt32(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                rem = n % 10;
                sum = sum * 10 + rem;
                n = n / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("Palindrome");
            }
            else 
            {
                Console.WriteLine("Not Palindrome");
            }
        }
    }
}
