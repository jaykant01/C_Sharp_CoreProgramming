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
        Console.WriteLine("Enter number n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        NaturalNoRecursive nat = new NaturalNoRecursive();
        int res1 = nat.Formula(n);
        int res2 = nat.Recursion(n);
        Console.WriteLine("Natural no From Formula " +  res1);
        Console.WriteLine("Natural no From Recursion " +  res1);

        if(res1 == res2)
        {
            Console.WriteLine("Both are Equal");
        }

        Console.ReadKey();
    }
}
