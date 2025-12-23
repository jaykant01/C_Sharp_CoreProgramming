namespace Method_Level2;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1 Factors
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] factors = FindFactors.Factors(number);
        // Print Factors
        Console.WriteLine("Factors are:");
        for (int i = 0; i < factors.Length; i++)
        {
            Console.Write(factors[i] + " ");
        }
        Console.WriteLine();

        int sum = FindFactors.FindSum(factors);
        long product = FindFactors.FindProduct(factors);
        double sumOfSquares = FindFactors.FindSumOfSquares(factors);

        Console.WriteLine($"Sum of factors = {sum}");
        Console.WriteLine($"Product of factors = {product}");
        Console.WriteLine($"Sum of squares of factors = {sumOfSquares}");



        Console.ReadKey();
    }
}
