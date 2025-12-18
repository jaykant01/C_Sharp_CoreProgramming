using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level2
{
    internal class Problem5
    {
        public void FahrToCelsius(double fahre)
        {
            double celsius = (fahre - 32) * 5 / 9;
            Console.WriteLine($"The {fahre} Fahrenheit is {celsius} Celsius");
        }
    }
}