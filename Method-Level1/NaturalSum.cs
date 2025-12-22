namespace Method_Level1;

public class NaturalSum
{
    public int CalculateSum(int n)
    {
        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }

        return sum;
    }
}
