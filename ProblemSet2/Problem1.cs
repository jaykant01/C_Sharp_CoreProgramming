namespace ProblemSet2;

public class Problem1
{
     public void IsPrime(int num)
    {
        bool flag = true;
        for (int i=2; i<num; i++)
        {
            if (num % i == 0)
            {
                flag = false;
                break;
            }else
            {
                flag = true;
            }
        }

        Console.WriteLine(flag);
    }
}
