namespace ProblemSet2;

public class Problem9
{
    public void Multiple(int x)
    {
        for(int i = x; i > 0; i--)
        {
            if (x % i == 0)
            {
                Console.WriteLine(i);

            }
            else
            {
                continue;
            }
        }
    }
}
