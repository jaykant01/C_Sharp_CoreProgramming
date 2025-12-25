namespace Method_Level3;
/* Extend or Create a NumberChecker utility class and perform the following task. Call
from the main() method the different methods and display results. Make sure all are static
methods
 */
public class NumberChecker3
{
    // Prime Number
    public static bool IsPrime(int n)
    {
        if (n <= 1)
            return false;

        for (int i = 2; i <= n / 2; i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }

    //Neon Number
    public static bool IsNeon(int n)
    {
        int square = n * n;
        int sum = 0;

        while (square > 0)
        {
            sum += square % 10;
            square /= 10;
        }
        return sum == n;
    }

    //Spy Number
    public static bool IsSpy(int n)
    {
        int sum = 0;
        int product = 1;

        while (n > 0)
        {
            int digit = n % 10;
            sum += digit;
            product *= digit;
            n /= 10;
        }
        return sum == product;
    }

    //Automorphic Number
    public static bool IsAutomorphic(int n)
    {
        int square = n * n;
        int temp = n;

        while (temp > 0)
        {
            if (square % 10 != temp % 10)
                return false;

            square /= 10;
            temp /= 10;
        }
        return true;
    }

    //Buzz Number
    public static bool IsBuzz(int n)
    {
        return (n % 7 == 0) || (n % 10 == 7);
    }
}
