using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level2
{
    internal class Problem6
    {
        public void TotalIncome(int salary, int bonus)
        {
            int income = salary + bonus;
            Console.WriteLine($"The salary is INR {salary} and bonus is INR {bonus}. Hence Total Income is INR {income}");
        }
    }
}

