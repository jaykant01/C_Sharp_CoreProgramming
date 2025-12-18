using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level2
{
    internal class Problem3
    {
        public void DoubleOpt(double x, double y, double z)
        {
            double op1 = x + y * z;
            double op2 = x * y + z;
            double op3 = z + x / y;

            Console.WriteLine($"The results of Int Operations are {op1}, {op2}, and {op3}");
        }

    }
}