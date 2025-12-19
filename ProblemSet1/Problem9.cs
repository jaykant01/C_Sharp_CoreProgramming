namespace ProblemSet1;

public class Problem9
{
    public void Counter(int p)
    {
        for (int i = p; i >= 1; i--)
        {
            Console.WriteLine(i);
            if (i == 1)
            {
                Console.WriteLine("Rocket Launched");
            }
        }
    }
}
