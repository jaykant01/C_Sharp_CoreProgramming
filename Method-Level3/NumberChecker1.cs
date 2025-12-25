namespace Method_Level3;

public class NumberChecker1
{
    public int CountDigit(int n)
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
    public int[] StoreDigit(int n)
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

    public double SumNumber(int n)
    {
        double sum = 0;

        while (n > 0)
        {
            double rem = n % 10;
            sum += rem;
            n /= 10;
        }
        return sum;
    }

    public double SumSquare(int n)
    {
        double num = SumNumber(n);
        double square = Math.Pow(num, 2);
        return square;
    }

    public bool HarshadNumber(int n)
    {
        bool res = (n % SumNumber(n) == 0) ? true : false;
        return res;
    }
}
