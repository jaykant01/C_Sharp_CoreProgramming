using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level2
{
    internal class Problem1 
    {
        public void Calculate(int num1, int num2)
        {
            int quot = num1 / num2;
            int rem = num1 % num2;

            Console.WriteLine($"The Quotient is {quot} and Remainder is {rem} of two numbers {num1} and {num2}");
        }
        
    }
}
