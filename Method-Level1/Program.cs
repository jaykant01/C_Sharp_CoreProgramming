namespace Method_Level1;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1 calculate Simple Interest
        Console.WriteLine("Enter Principal, Rate, time: ");
        double principal = Convert.ToDouble(Console.ReadLine());
        double rate = Convert.ToDouble(Console.ReadLine());
        double time = Convert.ToDouble(Console.ReadLine());

        SimpleInterest obj = new SimpleInterest();
        Console.WriteLine("SI is: " + obj.CalculateSI(principal, rate, time));

        Console.ReadKey();
    }
}
