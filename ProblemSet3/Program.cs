namespace ProblemSet3;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1
        Console.WriteLine("Enter the number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Problem1 p1 = new Problem1();
        p1.Armstrong(number);

        Console.ReadKey();
    }
}
