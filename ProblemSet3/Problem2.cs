namespace ProblemSet3;

public class Problem2
{
    public void Counter(int num)
    {
        int count = 0;

        while (num > 0)
        {
            int rem = num % 10;
            count += 1;
            num /= 10;
        }

        Console.WriteLine(count);
    }
}
