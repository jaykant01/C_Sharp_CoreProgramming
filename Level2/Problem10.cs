using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level2
{
    internal class Problem10
    {
        public void Chocolates(int n, int m)
        {
            int div = n / m;
            int remChoc = n % m;

            Console.WriteLine($"The number of chocolates each child gets is {div} and the number of remaaining choclate is {remChoc}");
        }
    }
}

