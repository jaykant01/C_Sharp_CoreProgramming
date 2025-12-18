using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level2
{
    internal class Problem11
    {
        public void SPInterest(int principal, int rate, int time)
        {
            int sI = (principal * rate * time) / 100;
            Console.WriteLine($"The Simple Interest is {sI} for Principal {principal}, Rate of Interest {rate} and Time {time}");
        }
    }
}
