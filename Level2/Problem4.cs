using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level2
{
    internal class Problem4
    {
        public void CelciusToFahr(double celsius)
        {
            double farh = (celsius * 9 / 5) + 32;
            Console.WriteLine($"The {celsius} Celsius is {farh} Fahrenheit");
        }

    }
}