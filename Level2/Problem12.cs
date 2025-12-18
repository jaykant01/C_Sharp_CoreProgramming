using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level2
{
    internal class Problem12
    {
        public void WeightConv(double weight)
        {
            double kgweight = weight / 2.2;
            Console.WriteLine($"The weight of the person in pounds is {weight} and in kg is {kgweight}");

        }
    }
}
