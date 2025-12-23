namespace Method_Level2;

public class FindFactors
{
    public static int[] Factors(int number)
    {
        int count = 0;

        for(int i=1;  i<number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }

        int[] factors = new int[count];
        int index = 0;

        for(int i=1;  i<number; i++)
        {
            if (number % i == 0)
            {
                factors[index++] = i;
            }
        }
        return factors;
        
    }


    // Find Sum of factors
    public static int FindSum(int[] factors)
    {
        int sum = 0;
        for (int i = 0; i < factors.Length; i++)
        {
            sum += factors[i];
        }
        return sum;
    }


    // Method to find product
    public static long FindProduct(int[] factors)
    {
        long product = 1;
        for (int i = 0; i < factors.Length; i++)
        {
            product *= factors[i];
        }
        return product;
    }


    // method to find Sum of Square factors
    public static double FindSumOfSquares(int[] factors)
    {
        double sumOfSquares = 0;
        for (int i = 0; i < factors.Length; i++)
        {
            sumOfSquares += Math.Pow(factors[i], 2);
        }
        return sumOfSquares;
    }
}
