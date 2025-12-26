namespace BuiltIn;
/* Create a program that checks whether a given number is a prime number.
 */
public class PrimeNumber
{
    public bool CheckPrime(int num)
    {
        if (num <= 1)
            return false;

        for (int i = 2; i <= num / 2; i++)
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }
}
