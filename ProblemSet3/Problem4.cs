namespace ProblemSet3;

public class Problem4
{
    public void AbundantNum(int no)
    {
        int sum = 0;

        for (int i=1; i<no; i++)
        {
            if (no % i == 0)
            {
                sum += i;
            }
            else
            {
                continue;
            }
        }

        if (sum > no)
        {
            Console.WriteLine("Yes it is Abundant Number");
        }else
        {
            Console.WriteLine("Not an Abundant Number");
        }
    }
}
