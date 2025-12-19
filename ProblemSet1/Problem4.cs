namespace ProblemSet1;

public class Problem4
{
    public void Natural(int num)
    {
        int sum = num * (num + 1) / 2;

        if (num >= 0)
        {
            Console.WriteLine("The sum of {0} natural numbers is {1}", num, sum);
        }
        else
        {
            Console.WriteLine("The number {0} is not natural number", num);
        }
    }
}
