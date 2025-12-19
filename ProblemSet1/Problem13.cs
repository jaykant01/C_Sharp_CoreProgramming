namespace ProblemSet1;

public class Problem13
{
    public void NatCompareNew(int a)
    {
        int n = a * (a + 1) / 2;
        int m = 0;
        
        for(int i=0; i<=a; i++)
        {
            m += i;
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
