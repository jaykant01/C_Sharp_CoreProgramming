namespace ProblemSet2;

class Program
{
    static void Main(string[] args)
    {
        // Problem 0 -> 0
        Console.WriteLine("Enter the Year: ");
        int year = int.Parse(Console.ReadLine());

        Problem0 p0 = new Problem0();
        p0.LeapYear(year);


        Console.ReadKey();
    }
}
