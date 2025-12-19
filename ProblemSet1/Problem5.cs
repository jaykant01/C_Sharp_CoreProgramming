namespace ProblemSet1;

public class Problem5
{
    public void Vote(int age)
    {
        if (age > 18)
        {
            Console.WriteLine($"The person's age is {age} and can vote");
        }else
        {
            Console.WriteLine($"The person's age is {age} and cannot vote");
        }
    }
}
