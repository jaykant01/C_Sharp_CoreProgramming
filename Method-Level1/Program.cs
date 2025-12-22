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



        // Problem 2 hand Shakes
        //Console.WriteLine("Enter number of students:");
        //int n = Convert.ToInt32(Console.ReadLine());
        //HandShakes obj = new HandShakes();
        //int result = obj.CalculateHandshakes(n);

        //Console.WriteLine("Maximum number of handshakes = " + result);



        // Problem 4 Athlete runs
        Console.WriteLine("Enter side 1, side 2, side 3 (in meters):");
        double side1 = Convert.ToDouble(Console.ReadLine());
        double side2 = Convert.ToDouble(Console.ReadLine());
        double side3 = Convert.ToDouble(Console.ReadLine());

        AthleteRun obj = new AthleteRun();
        double result = obj.CalculateRounds(side1, side2, side3);

        Console.WriteLine("Number of rounds to complete 5 km run = " + result);

        Console.ReadKey();
    }
}
