namespace ProblemSet1;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1
        //Console.Write("Enter a number: ");
        //int number = Convert.ToInt32(Console.ReadLine());

        //Problem1 c1 = new Problem1();
        //c1.CheckDivisible(number);


        // Problem 2
        Console.WriteLine("Enter number a, b & c: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        Problem2 p2 = new Problem2();
        p2.Smallest(a, b, c);




        

        Console.ReadKey();
    }
}

