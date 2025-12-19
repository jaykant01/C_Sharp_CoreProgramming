namespace ProblemSet2;

public class Problem6
{
    public void Greater(int number)
    {
        int gf = 1;

        for(int i=number -1; i>=1; i--)
        {
            if (number % i == 0)
            {
                gf = i;
                break;
            }
        }
        Console.WriteLine(gf);
    }
}
