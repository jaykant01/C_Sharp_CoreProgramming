namespace ProblemSet1;

public class Problem12
{
    public void NatCompare(int a)
    {
        int n = a * (a + 1) / 2;
        int m = 0;
        while (a > 0)
        {
            m += a;
            a--;
        }

        if (m == n)
        {
            Console.WriteLine("Both are same");
        }
        else
        {
            Console.WriteLine("Not same");
        }
    }
}
