namespace ProblemSet1;

    class Program
    {
        static void Main(string[] args)
        {
            // Problem 1
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Problem1 c1 = new Problem1();
            c1.CheckDivisible(number);

            
            



            Console.ReadLine();
        }
    }

