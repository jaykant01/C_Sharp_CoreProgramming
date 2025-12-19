//using System;

namespace ProblemSet1;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Class1 c1 = new Class1();
            c1.CheckDivisible(number);

            Console.ReadLine();
        }
    }

