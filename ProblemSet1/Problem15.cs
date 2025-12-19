namespace ProblemSet1;

public class Problem15
{
    public void Fact(int num)
    {
        int f = 1;
        for(int i=1; i<=num; i++)
        {
            f *= i;
        }
        Console.WriteLine("Factorail is " + f);
    }
}
