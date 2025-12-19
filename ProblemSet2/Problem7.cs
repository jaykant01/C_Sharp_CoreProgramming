namespace ProblemSet2;

public class Problem7
{
    public void Power(int numb, int power)
    {
        int result = 1;

        for (int i = 1; i <= power; i++)
        {
            result *= numb;
        }

        Console.WriteLine(result);
    }
}
