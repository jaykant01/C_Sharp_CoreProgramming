namespace ProblemSet2;

public class Problem8
{
    public void GreatFactor(int numbe)
    {
        int gif = 1;

        for (int i = numbe - 1; i >= 1; i--)
        {
            if (numbe % i == 0)
            {
                gif = i;
                break;
            }
        }
        Console.WriteLine(gif);
    }
}
