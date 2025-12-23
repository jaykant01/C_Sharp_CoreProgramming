namespace Method_Level2;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1 Factors
        //Console.WriteLine("Enter a number:");
        //int number = Convert.ToInt32(Console.ReadLine());

        //int[] factors = FindFactors.Factors(number);
        //// Print Factors
        //Console.WriteLine("Factors are:");
        //for (int i = 0; i < factors.Length; i++)
        //{
        //    Console.Write(factors[i] + " ");
        //}
        //Console.WriteLine();

        //int sum = FindFactors.FindSum(factors);
        //long product = FindFactors.FindProduct(factors);
        //double sumOfSquares = FindFactors.FindSumOfSquares(factors);

        //Console.WriteLine($"Sum of factors = {sum}");
        //Console.WriteLine($"Product of factors = {product}");
        //Console.WriteLine($"Sum of squares of factors = {sumOfSquares}");



        // Problem 2 Natural number using Recursion
        //Console.WriteLine("Enter number n: ");
        //int n = Convert.ToInt32(Console.ReadLine());

        //NaturalNoRecursive nat = new NaturalNoRecursive();
        //int res1 = nat.Formula(n);
        //int res2 = nat.Recursion(n);
        //Console.WriteLine("Natural no From Formula " +  res1);
        //Console.WriteLine("Natural no From Recursion " +  res1);

        //if(res1 == res2)
        //{
        //    Console.WriteLine("Both are Equal");
        //}


        // Problem 3 Leap Year
        //Console.WriteLine("Enter the year:");
        //int year = Convert.ToInt32(Console.ReadLine());

        //LeapYear lp = new LeapYear();
        //bool res = lp.CheckLeapYear(year);

        //if (res)
        //{
        //    Console.WriteLine("It is a Leap year");
        //}
        //else
        //{
        //    Console.WriteLine("Not a Leap Year");
        //}


        // Problem 4 Unit Convertor
        Console.WriteLine("Enter the km, miles, meter, feet");
        double km = Convert.ToDouble(Console.ReadLine());
        double miles = Convert.ToDouble(Console.ReadLine());
        double meters = Convert.ToDouble(Console.ReadLine());
        double feet = Convert.ToDouble(Console.ReadLine());

        double res1 = UnitConvertor.KmToMiles(km);
        double res2 = UnitConvertor.MilesTokm(miles);
        double res3 = UnitConvertor.MetersToFeet(meters);
        double res4 = UnitConvertor.FeetTometers(feet);
        Console.WriteLine("Convert KmToMiles " + res1);
        Console.WriteLine("Convert MilesTokm " + res2);
        Console.WriteLine("Convert MetersToFeet " + res3);
        Console.WriteLine("Convert FeetTometers " + res4);

        Console.ReadKey();
    }
}
