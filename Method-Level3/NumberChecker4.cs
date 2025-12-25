namespace Method_Level3;

public class NumberChecker4
{
    // Factors
    public static int[] GetFactors(int n)
    {
        int count = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
                count++;
        }

        int[] factors = new int[count];
        int index = 0;

        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
                factors[index++] = i;
        }

        Console.WriteLine("Factors: " + string.Join(" ", factors));
        return factors;
    }

    // Greatest factor
    public static void PrintGreatestFactor(int[] factors)
    {
        Console.WriteLine("Greatest Factor: " + factors[factors.Length - 1]);
    }

    // Sum of factors
    public static void PrintSumOfFactors(int[] factors)
    {
        int sum = 0;
        foreach (int f in factors)
            sum += f;

        Console.WriteLine("Sum of Factors: " + sum);
    }

    // Product of factors
    public static void PrintProductOfFactors(int[] factors)
    {
        long product = 1;
        foreach (int f in factors)
            product *= f;

        Console.WriteLine("Product of Factors: " + product);
    }

    // Product of cube of factors
    public static void PrintProductOfCubeOfFactors(int[] factors)
    {
        double product = 1;
        foreach (int f in factors)
            product *= Math.Pow(f, 3);

        Console.WriteLine("Product of Cube of Factors: " + product);
    }

    // Perfect number
    public static void PrintPerfect(int n, int[] factors)
    {
        int sum = 0;
        for (int i = 0; i < factors.Length - 1; i++)
            sum += factors[i];

        Console.WriteLine(sum == n
            ? "Perfect Number"
            : "Not a Perfect Number");
    }

    // Abundant number
    public static void PrintAbundant(int n, int[] factors)
    {
        int sum = 0;
        for (int i = 0; i < factors.Length - 1; i++)
            sum += factors[i];

        Console.WriteLine(sum > n
            ? "Abundant Number"
            : "Not an Abundant Number");
    }

    // Deficient number
    public static void PrintDeficient(int n, int[] factors)
    {
        int sum = 0;
        for (int i = 0; i < factors.Length - 1; i++)
            sum += factors[i];

        Console.WriteLine(sum < n
            ? "Deficient Number"
            : "Not a Deficient Number");
    }

    // Strong number
    public static void PrintStrong(int n)
    {
        int temp = n;
        int sum = 0;

        while (temp > 0)
        {
            int digit = temp % 10;
            sum += Factorial(digit);
            temp /= 10;
        }

        Console.WriteLine(sum == n
            ? "Strong Number"
            : "Not a Strong Number");
    }

    private static int Factorial(int n)
    {
        int fact = 1;
        for (int i = 1; i <= n; i++)
            fact *= i;
        return fact;
    }
}
