namespace ProblemSet3;

public class Problem3
{
    public void HarshadNum(int n)
    {
        int sum = 0;
        int og = n;

        while (n > 0)
        {
            int rem = n % 10;
            sum += rem;
            n /= 10;
        }

        Console.WriteLine(sum);

        if (og % sum == 0)
        {
            Console.WriteLine("Yes it is Harshad Number");
        }else
        {
            Console.WriteLine("No it is not Harshad Number");
        }
    }
}
