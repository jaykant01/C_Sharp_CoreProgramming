using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level2
{
    internal class Problem9
    {
        public void TrinagularPark(int side1, int side2, int side3)
        {
            int distance = 5 * 1000;
            int perim = side1 + side2 + side3;

            int rounds = distance / perim;

            Console.WriteLine($"The total number of rounds the athlete will run is {rounds} to complete 5 km");
        }
    }
}
