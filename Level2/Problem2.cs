using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level2
{
    internal class Problem2
    {
        public void Precedence(int num1, int num2, int num3)
        {
            int op1 = num1 + num2 * num3;
            int op2 = num1 * num2 + num3;
            int op3 = num3 + num1 / num2;

            Console.WriteLine($"The results of Int Operations are {op1}, {op2}, and {op3}");
        }

    }
}
