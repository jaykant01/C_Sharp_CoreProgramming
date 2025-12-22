namespace Method_Level1;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1 calculate Simple Interest
        //Console.WriteLine("Enter Principal, Rate, time: ");
        //double principal = Convert.ToDouble(Console.ReadLine());
        //double rate = Convert.ToDouble(Console.ReadLine());
        //double time = Convert.ToDouble(Console.ReadLine());

        //SimpleInterest obj = new SimpleInterest();
        //Console.WriteLine("SI is: " + obj.CalculateSI(principal, rate, time));



        // Problem 2 
        Console.WriteLine("Enter number of students:");
        int n = Convert.ToInt32(Console.ReadLine());
        HandShakes obj = new HandShakes();
        int result = obj.CalculateHandshakes(n);

        Console.WriteLine("Maximum number of handshakes = " + result);



        Console.ReadKey();
    }
}
