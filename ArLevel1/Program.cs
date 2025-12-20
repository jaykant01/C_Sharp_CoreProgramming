namespace ArLevel1;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1
        Console.WriteLine("Enter the size of an Array: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Enter the age for {n} persons: ");
        Problem1 p1 = new Problem1();
        p1.Age(n);

        Console.ReadKey();
    }
}
