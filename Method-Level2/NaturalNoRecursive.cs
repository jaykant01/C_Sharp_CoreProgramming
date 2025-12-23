namespace Method_Level2;

public class NaturalNoRecursive
{
    public int Formula(int n)
    {
        int natural = n * (n + 1) / 2;
        return natural;
    }

    public int Recursion(int n)
    {
        if(n == 0)
        {
            return n;
        }
        int sum = 0;
        sum += n;
        return sum;
    }
}
