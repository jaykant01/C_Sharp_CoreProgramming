namespace Method_Level3;

public class NumberChecker2
{
    public static int CountDigit(int n)
    {
        int count = 0;

        while (n > 0)
        {
            int rem = n % 10;
            count = count + 1;
            n /= 10;
        }
        return count;
    }

    // Store Digit in Array
    public static int[] StoreDigit(int n)
    {
        int[] digit = new int[CountDigit(n)];
        int i = 0;
        while (n > 0)
        {
            int rem = n % 10;
            digit[i] = rem;
            n /= 10;
            i++;
        }

        return digit;
    }

    // Palindrome
    public static bool Palindrome(int n)
    {
        int[] digits = StoreDigit(n);

        for(int i=0; i<digits.Length/2; i++)
        {
            if (digits[i] != digits[digits.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }

}
